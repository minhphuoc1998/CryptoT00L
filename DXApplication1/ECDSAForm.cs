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

namespace DXApplication1
{
    public partial class ECDSAForm : DevExpress.XtraEditors.XtraUserControl
    {
        private static ECDSAForm _instance;

        public static ECDSAForm Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ECDSAForm();
                return _instance;
            }
        }

        public ECDSAForm()
        {
            InitializeComponent();
            valid.Hide();
            invalid.Hide();
        }

        public void ECSDAGen(string path)
        {
            CngKeyCreationParameters keyCreationParameters = new CngKeyCreationParameters();
            keyCreationParameters.ExportPolicy = CngExportPolicies.AllowPlaintextExport;
            keyCreationParameters.KeyUsage = CngKeyUsages.Signing;

            CngKey key = CngKey.Create(CngAlgorithm.ECDsaP256, null, keyCreationParameters);

            ECDsaCng dsa = new ECDsaCng(key);

            byte[] privateKey = dsa.Key.Export(CngKeyBlobFormat.EccPrivateBlob);
            File.WriteAllBytes(path + "/ECDSAKey.prikey", privateKey);

            byte[] publicKey = dsa.Key.Export(CngKeyBlobFormat.EccPublicBlob);
            File.WriteAllBytes(path + "/ECDSAKey.pubkey", publicKey);
        }

        public void ECDSASign(string dataFile, string keyFile)
        {
            CngKey importedKey = CngKey.Import(File.ReadAllBytes(keyFile), CngKeyBlobFormat.EccPrivateBlob);
            ECDsaCng sigKey = new ECDsaCng(importedKey);

            byte[] data = File.ReadAllBytes(dataFile);
            MD5 hashFunction = MD5.Create();
            byte[] hash = hashFunction.ComputeHash(data);

            byte[] sign = sigKey.SignData(hash);

            File.WriteAllBytes(dataFile + ".sig", sign);
        }

        public bool ECDSAVerify(string dataFile, string signFile, string keyFile)
        {
            CngKey importedKey = CngKey.Import(File.ReadAllBytes(keyFile), CngKeyBlobFormat.EccPublicBlob);
            ECDsaCng verKey = new ECDsaCng(importedKey);

            byte[] sign = File.ReadAllBytes(signFile);

            byte[] data = File.ReadAllBytes(dataFile);
            MD5 hashFunction = MD5.Create();
            byte[] hash = hashFunction.ComputeHash(data);
            
            return verKey.VerifyData(hash, sign);
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
            ECSDAGen(dir);
        }

        private void sign_Click(object sender, EventArgs e)
        {
            valid.Hide();
            invalid.Hide();
            ECDSASign(filePath.Text, keyPath.Text);
        }

        private void verify_Click(object sender, EventArgs e)
        {
            if (ECDSAVerify(filePath.Text, signPath.Text, keyPath.Text))
            {
                valid.Show();
                invalid.Hide();
            }
            else
            {
                invalid.Show();
                valid.Hide();
            }
        }
    }
}
