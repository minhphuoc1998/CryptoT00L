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
    public partial class ElgamalForm : DevExpress.XtraEditors.XtraUserControl
    {
        private static ElgamalForm _instance;
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

        public static void ElgamalGenerateKeys(string path)
        {
            var prime = ElgamalPrime;
            var generator = ElgamalGenerator;

            var random = new Random();
            var aliceK = random.Next(1, ElgamalRandomExponentMax);

            // Alice public key - generator to random number K (g ^ aliceK)
            var alicePublicKey = BigInteger.ModPow(generator, aliceK, prime);

            var output = prime + Environment.NewLine + generator + Environment.NewLine;
            var privateKeyText = output + aliceK + Environment.NewLine;
            var publicKeyText = output + alicePublicKey + Environment.NewLine;
            File.WriteAllText(path + "/elgamal.prikey", privateKeyText);
            File.WriteAllText(path + "/elgamal.pubkey", publicKeyText);
        }

        public static void ElgamalEncrypt(string publicKeyFilename, string messageFileName)
        {
            var publicKeyLines = File.ReadAllLines(publicKeyFilename);
            var messageLines = File.ReadAllLines(messageFileName);

            var message = BigInteger.Parse(messageLines[0]);
            var prime = BigInteger.Parse(publicKeyLines[0]);
            if (message >= prime)
                throw new Exception("m < p condition not met");

            var generator = BigInteger.Parse(publicKeyLines[1]);
            var alicePublicKey = BigInteger.Parse(publicKeyLines[2]);

            var random = new Random();
            var bobk = random.Next(1, ElgamalRandomExponentMax);

            // Bobs public key - generator to random number K (g ^ bobk)
            var bobPublicKey = BigInteger.ModPow(generator, bobk, prime);

            // common encryption key - (generator ^ aliceK) ^ bobk
            var encryptionKey = BigInteger.ModPow(alicePublicKey, bobk, prime);

            var encryptedMessage = (message * encryptionKey) % prime;
            var output = bobPublicKey + Environment.NewLine + encryptedMessage + Environment.NewLine;
            File.WriteAllText(messageFileName + ".enc", output);
        }

        public static void ElgamalDecrypt(string privateKeyFilename, string encryptedMessageFilename)
        {
            var privateKeyLines = File.ReadAllLines(privateKeyFilename);
            var encryptedMessageLines = File.ReadAllLines(encryptedMessageFilename);

            var prime = BigInteger.Parse(privateKeyLines[0]);
            var generator = BigInteger.Parse(privateKeyLines[1]);

            var bobPublicKey = BigInteger.Parse(encryptedMessageLines[0]);
            var bobK = 1;
            while (true)
            {
                if (BigInteger.ModPow(generator, bobK, prime) == bobPublicKey)
                    break;
                bobK++;
            }

            // Alice public key => generator ^ aliceK
            var aliceK = BigInteger.Parse(privateKeyLines[2]);
            var alicePublicKey = BigInteger.ModPow(generator, aliceK, prime);

            // encryption key => (generator ^ aliceK) ^ bobK
            var encryptionKey = BigInteger.ModPow(alicePublicKey, bobK, prime);

            var encryptedMessage = BigInteger.Parse(encryptedMessageLines[1]);
            var encryptionKeyInverse = BigInteger.ModPow(encryptionKey, prime - 2, prime);
            var decryptedMessage = (encryptedMessage * encryptionKeyInverse) % prime;

            var output = decryptedMessage + Environment.NewLine;
            File.WriteAllText(encryptedMessageFilename + ".dec", output);
        }
        public static ElgamalForm Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ElgamalForm();
                return _instance;
            }
        }

        public ElgamalForm()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string dir = Form1.Instance.getFolder();
            if (dir == null)
                return;
            ElgamalGenerateKeys(dir);
        }

        private void openFile_Click(object sender, EventArgs e)
        {
            filePath.Text = Form1.Instance.getFile();
        }

        private void importKey_Click(object sender, EventArgs e)
        {
            keyPath.Text = Form1.Instance.getFile();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            ElgamalEncrypt(keyPath.Text, filePath.Text);
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            ElgamalDecrypt(keyPath.Text, filePath.Text);
        }
    }
}
