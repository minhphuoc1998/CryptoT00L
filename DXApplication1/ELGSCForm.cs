using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Security.Cryptography;
using System.IO;
using System.Numerics;

namespace DXApplication1
{
    public partial class ELGSCForm : DevExpress.XtraEditors.XtraUserControl
    {
        private static ELGSCForm _instance;

        public static ELGSCForm Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ELGSCForm();
                return _instance;
            }
        }

        public ELGSCForm()
        {
            InitializeComponent();
            valid.Hide();
            invalid.Hide();
        }

        private const int ElgamalRandomExponentMax = 100;
        private static BigInteger ElgamalPrime = BigInteger.Parse("1665997633093155705263923663680487185948531888850484859473375695734301776192932338784530163");
        private static BigInteger ElgamalGenerator = BigInteger.Parse("170057347237941209366519667629336535698946063913573988287540019819022183488419112350737049");

        public static BigInteger MultiplicativeInverse(BigInteger a, BigInteger m)
        {
            BigInteger x0 = 0;
            BigInteger x1 = 1;
            var m0 = m;

            if (m == 0)
                return 1;

            while (a > 1)
            {
                var q = a / m;
                var t = m;
                m = a % m;
                a = t;

                t = x0;
                x0 = x1 - q * x0;
                x1 = t;
            }

            if (x1 < 0)
                x1 += m0;

            return x1;
        }

        public void ElgamalGenerateKeys(string path)
        {
            var prime = ElgamalPrime;
            var generator = ElgamalGenerator;

            var random = new Random();
            var aliceK = random.Next(1, ElgamalRandomExponentMax);

            // Alice public key - generator to random number K (g ^ aliceK)
            var alicePublicKey = BigInteger.ModPow(generator, aliceK, prime);

            var priKey = Convert.ToBase64String(Encoding.ASCII.GetBytes(prime + "," + generator + "," + aliceK));
            var pubKey = Convert.ToBase64String(Encoding.ASCII.GetBytes(prime + "," + generator + "," + alicePublicKey));
            File.WriteAllText(path + "/ELGSC.prikey", priKey);
            File.WriteAllText(path + "/ELGSC.pubkey", pubKey);
        }

        public void ElgamalSign(string privateKeyFileName, string messageFileName)
        {
            var privKey = Encoding.ASCII.GetString(Convert.FromBase64String(File.ReadAllText(privateKeyFileName))).Split(',');

            var hashFunction = MD5.Create();
            var message = new BigInteger(hashFunction.ComputeHash(File.ReadAllBytes(messageFileName)));
            Console.WriteLine(message);
            var prime = BigInteger.Parse(privKey[0]);
            var generator = BigInteger.Parse(privKey[1]);
            var aliceK = BigInteger.Parse(privKey[2]);

            var random = new Random();

            // generate r
            int k;
            while (true)
            {
                var primeInt = prime < int.MaxValue ? (int)prime : int.MaxValue;
                k = random.Next(1, primeInt);
                var relativelyPrime = BigInteger.GreatestCommonDivisor(k, prime - 1) == 1;
                if (relativelyPrime)
                    break;
            }
            var r = BigInteger.ModPow(generator, k, prime);

            // generate x
            var kInverse = MultiplicativeInverse(k, prime - 1);
            var mod = prime - 1;
            // ensure modulo operations are performed on positive numbers
            // by adding a "span (modulo bound * any high-enough multiplier)
            var x1 = message - (aliceK * r) + (mod * 10000);
            var x = (x1 * kInverse) % mod;
            if (x < 0)
                x += mod;
            var output = r + Environment.NewLine + x + Environment.NewLine;
            File.WriteAllText(messageFileName + ".sig", output);
        }
        
        public bool ElgamalVerifySignature(string publicKeyFileName, string messageFileName, string signatureFileName)
        {
            var publKey = Encoding.ASCII.GetString(Convert.FromBase64String(File.ReadAllText(publicKeyFileName))).Split(',');

            var messageLines = File.ReadAllLines(messageFileName);
            var signatureLines = File.ReadAllLines(signatureFileName);

            var hashFunction = MD5.Create();
            var message = new BigInteger(hashFunction.ComputeHash(File.ReadAllBytes(messageFileName)));

            var prime = BigInteger.Parse(publKey[0]);
            var generator = BigInteger.Parse(publKey[1]);
            var publicKey = BigInteger.Parse(publKey[2]);

            var r = BigInteger.Parse(signatureLines[0]);
            var x = BigInteger.Parse(signatureLines[1]);
            Console.WriteLine(generator);
            Console.WriteLine(message);
            Console.WriteLine(prime);
            var left = BigInteger.ModPow(generator, message, prime);
            var right = (BigInteger.ModPow(publicKey, r, prime) * BigInteger.ModPow(r, x, prime)) % prime;

            //string output;
            if (r >= 1 && r < prime && left == right)
                //output = "Valid signature";
                return true;
            else
                //output = "Invalid signature";
                return false;

            //File.WriteAllText("e", output);
            //return output;
        }

        private void key_Click(object sender, EventArgs e)
        {
            keyPath.Text = Form1.Instance.getFile();
        }

        private void file_Click(object sender, EventArgs e)
        {
            filePath.Text = Form1.Instance.getFile();
        }

        private void signature_Click(object sender, EventArgs e)
        {
            signPath.Text = Form1.Instance.getFile();
        }

        private void gen_Click(object sender, EventArgs e)
        {
            valid.Hide();
            invalid.Hide();
            string dir = Form1.Instance.getFolder();
            if (dir == null)
                return;
            ElgamalGenerateKeys(dir);
        }

        private void sign_Click(object sender, EventArgs e)
        {
            valid.Hide();
            invalid.Hide();
            ElgamalSign(keyPath.Text, filePath.Text);
        }

        private void verify_Click(object sender, EventArgs e)
        {
            try
            {
                if (ElgamalVerifySignature(keyPath.Text, filePath.Text, signPath.Text))
                {
                    valid.Show();
                    invalid.Hide();
                }
                else
                {
                    valid.Hide();
                    invalid.Show();
                }
            }
            catch (Exception c)
            {
                valid.Hide();
                invalid.Show();
            }
        }
    }
}
