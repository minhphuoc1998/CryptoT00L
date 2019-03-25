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
using VTDev.Libraries.CEXEngine.Crypto.Cipher.Asymmetric.Encrypt.NTRU;
using VTDev.Libraries.CEXEngine.Crypto.Cipher.Asymmetric.Interfaces;

namespace DXApplication1
{
    public partial class NTRUForm : DevExpress.XtraEditors.XtraUserControl
    {
        private static NTRUForm _instance;

        public static NTRUForm Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new NTRUForm();
                return _instance;
            }
        }

        public NTRUForm()
        {
            InitializeComponent();
        }

        public void NTRUGenerate(string path)
        {
            NTRUKeyGenerator gen = new NTRUKeyGenerator(NTRUParamSets.APR2011439, false);
            IAsymmetricKeyPair key = gen.GenerateKeyPair();
            File.WriteAllBytes(path + "/ntru.pubkey", key.PublicKey.ToBytes());
            File.WriteAllBytes(path + "/ntru.prikey", key.PrivateKey.ToBytes());
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
            NTRUPrivateKey priKey = new NTRUPrivateKey(File.ReadAllBytes(keyPath));
            NTRUPublicKey pubKey = new NTRUPublicKey(File.ReadAllBytes(keyPath.Substring(0, keyPath.Length - 6) + "pubkey"));
            NTRUKeyPair key = new NTRUKeyPair(pubKey, priKey);

            byte[] cipher = File.ReadAllBytes(filePath);

            NTRUEncrypt dec = new NTRUEncrypt(NTRUParamSets.APR2011439);
            dec.Initialize(key);
            byte[] plain = dec.Decrypt(cipher);
            File.WriteAllBytes(filePath + ".dec", plain);
        }

        private void key_Click(object sender, EventArgs e)
        {
            keyPath.Text = Form1.Instance.getFile();
        }

        private void file_Click(object sender, EventArgs e)
        {
            filePath.Text = Form1.Instance.getFile();
        }

        private void gen_Click(object sender, EventArgs e)
        {
            string dir = Form1.Instance.getFolder();
            if (dir == null)
                return;
            NTRUGenerate(dir);
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            NTRUEncrypt(keyPath.Text, filePath.Text);
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            NTRUDecrypt(keyPath.Text, filePath.Text);
        }
    }
}
