using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace DXApplication1
{
    public partial class Form1 : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        private static Form1 _instance;

        public static Form1 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Form1();
                return _instance;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        public String getFile()
        {
            xtraOpenFileDialog1.Filter = "All Files (*.*)|*.*";
            xtraOpenFileDialog1.FileName = "";
            if (xtraOpenFileDialog1.ShowDialog(this) == DialogResult.OK)
                return xtraOpenFileDialog1.FileName;
            return null;
        }

        public String getFolder()
        {
            if (xtraFolderBrowserDialog1.ShowDialog(this) == DialogResult.OK)
                return xtraFolderBrowserDialog1.SelectedPath;
            return null;
        }

        private void accordionControlElement1_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement5_Click(object sender, EventArgs e)
        {

        }

        private void accordionContentContainer1_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement4_Click(object sender, EventArgs e)
        {
            if (!this.Controls.Contains(MD5Form.Instance))
            {
                this.Controls.Add(MD5Form.Instance);
                MD5Form.Instance.Dock = DockStyle.Fill;
                MD5Form.Instance.BringToFront();
            }
            MD5Form.Instance.BringToFront();
        }

        private void accordionControlElement5_Click_1(object sender, EventArgs e)
        {
            if (!this.Controls.Contains(SHA1Form.Instance))
            {
                this.Controls.Add(SHA1Form.Instance);
                SHA1Form.Instance.Dock = DockStyle.Fill;
                SHA1Form.Instance.BringToFront();
            }
            SHA1Form.Instance.BringToFront();
        }

        private void accordionControlElement6_Click(object sender, EventArgs e)
        {
            if (!this.Controls.Contains(SHA256Form.Instance))
            {
                this.Controls.Add(SHA256Form.Instance);
                SHA256Form.Instance.Dock = DockStyle.Fill;
                SHA256Form.Instance.BringToFront();
            }
            SHA256Form.Instance.BringToFront();
        }

        private void accordionControlElement10_Click(object sender, EventArgs e)
        {
            if (!this.Controls.Contains(SHA384Form.Instance))
            {
                this.Controls.Add(SHA384Form.Instance);
                SHA384Form.Instance.Dock = DockStyle.Fill;
                SHA384Form.Instance.BringToFront();
            }
            SHA384Form.Instance.BringToFront();
        }

        private void accordionControlElement11_Click(object sender, EventArgs e)
        {
            if (!this.Controls.Contains(SHA512Form.Instance))
            {
                this.Controls.Add(SHA512Form.Instance);
                SHA512Form.Instance.Dock = DockStyle.Fill;
                SHA512Form.Instance.BringToFront();
            }
            SHA512Form.Instance.BringToFront();
        }

        private void accordionControlElement7_Click(object sender, EventArgs e)
        {
            if (!this.Controls.Contains(AESForm.Instance))
            {
                this.Controls.Add(AESForm.Instance);
                AESForm.Instance.Dock = DockStyle.Fill;
                AESForm.Instance.BringToFront();
            }
            AESForm.Instance.BringToFront();
        }

        private void accordionControlElement8_Click(object sender, EventArgs e)
        {
            if (!this.Controls.Contains(DESForm.Instance))
            {
                this.Controls.Add(DESForm.Instance);
                DESForm.Instance.Dock = DockStyle.Fill;
                DESForm.Instance.BringToFront();
            }
            DESForm.Instance.BringToFront();
        }

        private void accordionControlElement9_Click(object sender, EventArgs e)
        {
            if (!this.Controls.Contains(TripDESForm.Instance))
            {
                this.Controls.Add(TripDESForm.Instance);
                TripDESForm.Instance.Dock = DockStyle.Fill;
                TripDESForm.Instance.BringToFront();
            }
            TripDESForm.Instance.BringToFront();
        }

        private void accordionControlElement12_Click(object sender, EventArgs e)
        {
            if (!this.Controls.Contains(RSAForm.Instance))
            {
                this.Controls.Add(RSAForm.Instance);
                RSAForm.Instance.Dock = DockStyle.Fill;
                RSAForm.Instance.BringToFront();
            }
            RSAForm.Instance.BringToFront();
        }

        private void accordionControlElement13_Click(object sender, EventArgs e)
        {
            if (!this.Controls.Contains(ElgamalForm.Instance))
            {
                this.Controls.Add(ElgamalForm.Instance);
                ElgamalForm.Instance.Dock = DockStyle.Fill;
                ElgamalForm.Instance.BringToFront();
            }
            ElgamalForm.Instance.BringToFront();
        }

        private void accordionControlElement15_Click(object sender, EventArgs e)
        {
            if (!this.Controls.Contains(ECDSAForm.Instance))
            {
                this.Controls.Add(ECDSAForm.Instance);
                ECDSAForm.Instance.Dock = DockStyle.Fill;
                ECDSAForm.Instance.BringToFront();
            }
            ECDSAForm.Instance.BringToFront();
        }

        private void accordionControlElement16_Click(object sender, EventArgs e)
        {
            if (!this.Controls.Contains(ELGSCForm.Instance))
            {
                this.Controls.Add(ELGSCForm.Instance);
                ELGSCForm.Instance.Dock = DockStyle.Fill;
                ELGSCForm.Instance.BringToFront();
            }
            ELGSCForm.Instance.BringToFront();
        }

        private void accordionControlElement17_Click(object sender, EventArgs e)
        {
            if (!this.Controls.Contains(NTRUForm.Instance))
            {
                this.Controls.Add(NTRUForm.Instance);
                NTRUForm.Instance.Dock = DockStyle.Fill;
                NTRUForm.Instance.BringToFront();
            }
            NTRUForm.Instance.BringToFront();
        }
    }
    
}
