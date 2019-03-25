using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;
using System.Numerics;
using VTDev.Libraries.CEXEngine.Crypto.Cipher.Asymmetric.Encrypt.NTRU;
using VTDev.Libraries.CEXEngine.Crypto.Cipher.Asymmetric.Interfaces;

namespace DXApplication1
{
    class Cryptography
    {
        private const int ElgamalRandomExponentMax = 100;
        private static BigInteger ElgamalPrime = BigInteger.Parse("1665997633093155705263923663680487185948531888850484859473375695734301776192932338784530163");
        private static BigInteger ElgamalGenerator = BigInteger.Parse("170057347237941209366519667629336535698946063913573988287540019819022183488419112350737049");

        public void NTRUGenerate()
        {
            NTRUKeyGenerator gen = new NTRUKeyGenerator(NTRUParamSets.APR2011439, false);
            IAsymmetricKeyPair key = gen.GenerateKeyPair();
            File.WriteAllBytes("ntru.pubkey", key.PublicKey.ToBytes());
            File.WriteAllBytes("ntru.prikey", key.PrivateKey.ToBytes());
        }

        public void NTRUEncrypt(string keyPath, string filePath)
        {
            NTRUPublicKey key = new NTRUPublicKey(File.ReadAllBytes(keyPath));
            byte[] plain = File.ReadAllBytes(filePath);

            NTRUEncrypt enc = new NTRUEncrypt(NTRUParamSets.APR2011439);
            enc.Initialize(key);
            byte[] cipher = enc.Encrypt(plain);
            File.WriteAllBytes(filePath + ".enc", cipher);
        }

        public void NTRUDecrypt(string keyPath, string filePath)
        {
            NTRUPrivateKey key = new NTRUPrivateKey(File.ReadAllBytes(keyPath));
            byte[] cipher = File.ReadAllBytes(filePath);

            NTRUEncrypt dec = new NTRUEncrypt(NTRUParamSets.APR2011439);
            dec.Initialize(key);
            byte[] plain = dec.Encrypt(cipher);
            File.WriteAllBytes(filePath + ".dec", plain);
        }

        public static string hash(string data, HashAlgorithm hashFunction)
        {
            byte[] hashData = hashFunction.ComputeHash(ASCIIEncoding.Default.GetBytes(data));
            StringBuilder returnValue = new StringBuilder();
            for (int i = 0; i < hashData.Length; i++)
            {
                returnValue.Append(hashData[i].ToString("X"));
            }
            return returnValue.ToString().PadLeft(32, '0');
        }

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

        public static void ElgamalGenerateKeys(string generatorFilename)
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
            File.WriteAllText("elgamal.pri", privateKeyText);
            File.WriteAllText("elgamal.pub", publicKeyText);
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
            File.WriteAllText("c", output);
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
            File.WriteAllText("d", output);
        }

        public static void ElgamalSign(string privateKeyFileName, string messageFileName)
        {
            var privateKeyLines = File.ReadAllLines(privateKeyFileName);
            var messageLines = File.ReadAllLines(messageFileName);

            var prime = BigInteger.Parse(privateKeyLines[0]);
            var generator = BigInteger.Parse(privateKeyLines[1]);
            var aliceK = BigInteger.Parse(privateKeyLines[2]);
            var message = BigInteger.Parse(messageLines[0]);

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

            var output = r + Environment.NewLine + x + Environment.NewLine;
            File.WriteAllText("s", output);
        }

        public static string ElgamalVerifySignature(string publicKeyFileName, string messageFileName, string signatureFileName)
        {
            var publicKeyLines = File.ReadAllLines(publicKeyFileName);
            var messageLines = File.ReadAllLines(messageFileName);
            var signatureLines = File.ReadAllLines(signatureFileName);

            var prime = BigInteger.Parse(publicKeyLines[0]);
            var generator = BigInteger.Parse(publicKeyLines[1]);
            var publicKey = BigInteger.Parse(publicKeyLines[2]);
            var message = BigInteger.Parse(messageLines[0]);
            var r = BigInteger.Parse(signatureLines[0]);
            var x = BigInteger.Parse(signatureLines[1]);

            var left = BigInteger.ModPow(generator, message, prime);
            var right = (BigInteger.ModPow(publicKey, r, prime) * BigInteger.ModPow(r, x, prime)) % prime;

            string output;
            if (r >= 1 && r < prime && left == right)
                output = "Valid signature";
            else
                output = "Invalid signature";

            File.WriteAllText("e", output);
            return output;
        }

        public static void ECDSASign()
        {
            CngKeyCreationParameters keyCreationParameters = new CngKeyCreationParameters();
            keyCreationParameters.ExportPolicy = CngExportPolicies.AllowPlaintextExport;
            keyCreationParameters.KeyUsage = CngKeyUsages.Signing;

            CngKey key = CngKey.Create(CngAlgorithm.ECDsaP256, null, keyCreationParameters);

            ECDsaCng dsa = new ECDsaCng(key);

            byte[] privateKey = dsa.Key.Export(CngKeyBlobFormat.EccPrivateBlob);
            File.WriteAllText("privatekey.txt", String.Join(",", privateKey));

            byte[] publicKey = dsa.Key.Export(CngKeyBlobFormat.EccPublicBlob);
            File.WriteAllText("publicKey.txt", String.Join(",", publicKey));

            CngKey importedKey = CngKey.Import(File.ReadAllText("privatekey.txt").Split(',').Select(m => byte.Parse(m)).ToArray(), CngKeyBlobFormat.EccPrivateBlob);
            ECDsaCng importedDSA = new ECDsaCng(importedKey);
            byte[] signed = importedDSA.SignData(new byte[] { 1, 2, 3, 4, 5 });
            File.WriteAllText("signed.txt", String.Join(",", signed));
        }
    }



}
