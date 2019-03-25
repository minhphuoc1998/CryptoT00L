namespace DXApplication1
{
    partial class ECDSAForm
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.keyPath = new DevExpress.XtraEditors.TextEdit();
            this.filePath = new DevExpress.XtraEditors.TextEdit();
            this.gen = new DevExpress.XtraEditors.SimpleButton();
            this.key = new DevExpress.XtraEditors.SimpleButton();
            this.file = new DevExpress.XtraEditors.SimpleButton();
            this.signature = new DevExpress.XtraEditors.SimpleButton();
            this.sign = new DevExpress.XtraEditors.SimpleButton();
            this.signPath = new DevExpress.XtraEditors.TextEdit();
            this.verify = new DevExpress.XtraEditors.SimpleButton();
            this.invalid = new System.Windows.Forms.PictureBox();
            this.valid = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.keyPath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filePath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.signPath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invalid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valid)).BeginInit();
            this.SuspendLayout();
            // 
            // keyPath
            // 
            this.keyPath.Location = new System.Drawing.Point(140, 110);
            this.keyPath.Name = "keyPath";
            this.keyPath.Size = new System.Drawing.Size(300, 20);
            this.keyPath.TabIndex = 0;
            // 
            // filePath
            // 
            this.filePath.Location = new System.Drawing.Point(140, 160);
            this.filePath.Name = "filePath";
            this.filePath.Size = new System.Drawing.Size(300, 20);
            this.filePath.TabIndex = 1;
            // 
            // gen
            // 
            this.gen.Location = new System.Drawing.Point(480, 58);
            this.gen.Name = "gen";
            this.gen.Size = new System.Drawing.Size(75, 23);
            this.gen.TabIndex = 2;
            this.gen.Text = "Gen";
            this.gen.Click += new System.EventHandler(this.gen_Click);
            // 
            // key
            // 
            this.key.Location = new System.Drawing.Point(480, 108);
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(75, 23);
            this.key.TabIndex = 3;
            this.key.Text = "Key";
            this.key.Click += new System.EventHandler(this.key_Click);
            // 
            // file
            // 
            this.file.Location = new System.Drawing.Point(480, 158);
            this.file.Name = "file";
            this.file.Size = new System.Drawing.Size(75, 23);
            this.file.TabIndex = 4;
            this.file.Text = "File";
            this.file.Click += new System.EventHandler(this.file_Click);
            // 
            // signature
            // 
            this.signature.Location = new System.Drawing.Point(480, 208);
            this.signature.Name = "signature";
            this.signature.Size = new System.Drawing.Size(75, 23);
            this.signature.TabIndex = 5;
            this.signature.Text = "Signature";
            this.signature.Click += new System.EventHandler(this.signature_Click);
            // 
            // sign
            // 
            this.sign.Location = new System.Drawing.Point(170, 270);
            this.sign.Name = "sign";
            this.sign.Size = new System.Drawing.Size(75, 23);
            this.sign.TabIndex = 6;
            this.sign.Text = "Sign";
            this.sign.Click += new System.EventHandler(this.sign_Click);
            // 
            // signPath
            // 
            this.signPath.Location = new System.Drawing.Point(140, 210);
            this.signPath.Name = "signPath";
            this.signPath.Size = new System.Drawing.Size(300, 20);
            this.signPath.TabIndex = 7;
            // 
            // verify
            // 
            this.verify.Location = new System.Drawing.Point(330, 270);
            this.verify.Name = "verify";
            this.verify.Size = new System.Drawing.Size(75, 23);
            this.verify.TabIndex = 8;
            this.verify.Text = "Verify";
            this.verify.Click += new System.EventHandler(this.verify_Click);
            // 
            // invalid
            // 
            this.invalid.BackgroundImage = global::DXApplication1.Properties.Resources.cross;
            this.invalid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.invalid.Location = new System.Drawing.Point(480, 250);
            this.invalid.Name = "invalid";
            this.invalid.Size = new System.Drawing.Size(75, 75);
            this.invalid.TabIndex = 10;
            this.invalid.TabStop = false;
            // 
            // valid
            // 
            this.valid.BackgroundImage = global::DXApplication1.Properties.Resources.check;
            this.valid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.valid.Location = new System.Drawing.Point(480, 250);
            this.valid.Name = "valid";
            this.valid.Size = new System.Drawing.Size(75, 75);
            this.valid.TabIndex = 11;
            this.valid.TabStop = false;
            // 
            // ECDSAForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DXApplication1.Properties.Resources.e1;
            this.Controls.Add(this.valid);
            this.Controls.Add(this.invalid);
            this.Controls.Add(this.verify);
            this.Controls.Add(this.signPath);
            this.Controls.Add(this.sign);
            this.Controls.Add(this.signature);
            this.Controls.Add(this.file);
            this.Controls.Add(this.key);
            this.Controls.Add(this.gen);
            this.Controls.Add(this.filePath);
            this.Controls.Add(this.keyPath);
            this.Name = "ECDSAForm";
            this.Size = new System.Drawing.Size(600, 350);
            ((System.ComponentModel.ISupportInitialize)(this.keyPath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filePath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.signPath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invalid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit keyPath;
        private DevExpress.XtraEditors.TextEdit filePath;
        private DevExpress.XtraEditors.SimpleButton gen;
        private DevExpress.XtraEditors.SimpleButton key;
        private DevExpress.XtraEditors.SimpleButton file;
        private DevExpress.XtraEditors.SimpleButton signature;
        private DevExpress.XtraEditors.SimpleButton sign;
        private DevExpress.XtraEditors.TextEdit signPath;
        private DevExpress.XtraEditors.SimpleButton verify;
        private System.Windows.Forms.PictureBox invalid;
        private System.Windows.Forms.PictureBox valid;
    }
}
