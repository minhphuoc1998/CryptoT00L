﻿using System;
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

namespace DXApplication1
{
    public partial class SHA256Form : DevExpress.XtraEditors.XtraUserControl
    {
        private static SHA256Form _instance;
        private bool _isText = true;


        public static SHA256Form Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new SHA256Form();
                return _instance;
            }
        }

        public SHA256Form()
        {
            InitializeComponent();
        }

        private string hash(string data, Object a)
        {
            SHA256 hashFunction = SHA256.Create();
            byte[] hashData = hashFunction.ComputeHash(ASCIIEncoding.Default.GetBytes(data));
            StringBuilder returnValue = new StringBuilder();
            for (int i = 0; i < hashData.Length; i++)
            {
                returnValue.Append(hashData[i].ToString("X").PadLeft(2, '0'));
            }
            return returnValue.ToString();
        }

        private void btnHash_Click(object sender, EventArgs e)
        {
            try
            {
                if (this._isText)
                {
                    textOutput.Text = Cryptography.hash(textInput.Text, SHA256.Create());
                }
                else
                {
                    textOutput.Text = Cryptography.hash(Utility.readFile(textInput.Text), SHA256.Create());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Encryption failed " + ex.Message);
            }
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            textInput.Text = Form1.Instance.getFile();
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            if (_isText)
                _isText = false;
            else
                _isText = true;
        }

        private void toggleSwitch1_Toggled(object sender, EventArgs e)
        {
            _isText = !_isText;
        }
    }
}
