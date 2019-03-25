namespace DXApplication1
{
    partial class RSAForm
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
            this.genKey = new DevExpress.XtraEditors.SimpleButton();
            this.encrypt = new DevExpress.XtraEditors.SimpleButton();
            this.decrypt = new DevExpress.XtraEditors.SimpleButton();
            this.openFile = new DevExpress.XtraEditors.SimpleButton();
            this.textPath = new DevExpress.XtraEditors.TextEdit();
            this.importKey = new DevExpress.XtraEditors.SimpleButton();
            this.boxLength = new DevExpress.XtraEditors.ComboBoxEdit();
            this.keyPath = new DevExpress.XtraEditors.TextEdit();
            this.progressBarControl1 = new DevExpress.XtraEditors.ProgressBarControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.toggleSwitch1 = new DevExpress.XtraEditors.ToggleSwitch();
            this.progressPanel1 = new DevExpress.XtraWaitForm.ProgressPanel();
            ((System.ComponentModel.ISupportInitialize)(this.textPath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxLength.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyPath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // genKey
            // 
            this.genKey.Location = new System.Drawing.Point(480, 108);
            this.genKey.Name = "genKey";
            this.genKey.Size = new System.Drawing.Size(75, 23);
            this.genKey.TabIndex = 1;
            this.genKey.Text = "Gen";
            this.genKey.Click += new System.EventHandler(this.genKey_Click);
            // 
            // encrypt
            // 
            this.encrypt.Location = new System.Drawing.Point(170, 270);
            this.encrypt.Name = "encrypt";
            this.encrypt.Size = new System.Drawing.Size(75, 23);
            this.encrypt.TabIndex = 2;
            this.encrypt.Text = "Encrypt";
            this.encrypt.Click += new System.EventHandler(this.encrypt_Click);
            // 
            // decrypt
            // 
            this.decrypt.Location = new System.Drawing.Point(330, 270);
            this.decrypt.Name = "decrypt";
            this.decrypt.Size = new System.Drawing.Size(75, 23);
            this.decrypt.TabIndex = 3;
            this.decrypt.Text = "Decrypt";
            this.decrypt.Click += new System.EventHandler(this.decrypt_Click);
            // 
            // openFile
            // 
            this.openFile.Location = new System.Drawing.Point(480, 208);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(75, 23);
            this.openFile.TabIndex = 4;
            this.openFile.Text = "Open";
            this.openFile.Click += new System.EventHandler(this.openFile_Click);
            // 
            // textPath
            // 
            this.textPath.Location = new System.Drawing.Point(140, 210);
            this.textPath.Name = "textPath";
            this.textPath.Size = new System.Drawing.Size(300, 20);
            this.textPath.TabIndex = 5;
            // 
            // importKey
            // 
            this.importKey.Location = new System.Drawing.Point(480, 158);
            this.importKey.Name = "importKey";
            this.importKey.Size = new System.Drawing.Size(75, 23);
            this.importKey.TabIndex = 10;
            this.importKey.Text = "Key";
            this.importKey.Click += new System.EventHandler(this.importKey_Click);
            // 
            // boxLength
            // 
            this.boxLength.Location = new System.Drawing.Point(20, 45);
            this.boxLength.Name = "boxLength";
            this.boxLength.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.boxLength.Size = new System.Drawing.Size(66, 20);
            this.boxLength.TabIndex = 11;
            // 
            // keyPath
            // 
            this.keyPath.Location = new System.Drawing.Point(140, 160);
            this.keyPath.Name = "keyPath";
            this.keyPath.Size = new System.Drawing.Size(300, 20);
            this.keyPath.TabIndex = 12;
            // 
            // progressBarControl1
            // 
            this.progressBarControl1.Location = new System.Drawing.Point(90, 310);
            this.progressBarControl1.Name = "progressBarControl1";
            this.progressBarControl1.Size = new System.Drawing.Size(420, 20);
            this.progressBarControl1.TabIndex = 13;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(110, 48);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(51, 13);
            this.labelControl1.TabIndex = 14;
            this.labelControl1.Text = "Key length";
            // 
            // toggleSwitch1
            // 
            this.toggleSwitch1.Location = new System.Drawing.Point(20, 75);
            this.toggleSwitch1.Name = "toggleSwitch1";
            this.toggleSwitch1.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.toggleSwitch1.Properties.Appearance.Options.UseForeColor = true;
            this.toggleSwitch1.Properties.OffText = "       File";
            this.toggleSwitch1.Properties.OnText = "       Folder";
            this.toggleSwitch1.Size = new System.Drawing.Size(122, 24);
            this.toggleSwitch1.TabIndex = 15;
            // 
            // progressPanel1
            // 
            this.progressPanel1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.progressPanel1.Appearance.Options.UseBackColor = true;
            this.progressPanel1.BarAnimationElementThickness = 2;
            this.progressPanel1.Location = new System.Drawing.Point(170, 88);
            this.progressPanel1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.progressPanel1.Name = "progressPanel1";
            this.progressPanel1.Size = new System.Drawing.Size(246, 66);
            this.progressPanel1.TabIndex = 16;
            this.progressPanel1.Text = "progressPanel1";
            // 
            // RSAForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DXApplication1.Properties.Resources.w5;
            this.Controls.Add(this.progressPanel1);
            this.Controls.Add(this.toggleSwitch1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.progressBarControl1);
            this.Controls.Add(this.keyPath);
            this.Controls.Add(this.boxLength);
            this.Controls.Add(this.importKey);
            this.Controls.Add(this.textPath);
            this.Controls.Add(this.openFile);
            this.Controls.Add(this.decrypt);
            this.Controls.Add(this.encrypt);
            this.Controls.Add(this.genKey);
            this.Name = "RSAForm";
            this.Size = new System.Drawing.Size(600, 350);
            this.Load += new System.EventHandler(this.RSAForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textPath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxLength.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyPath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton genKey;
        private DevExpress.XtraEditors.SimpleButton encrypt;
        private DevExpress.XtraEditors.SimpleButton decrypt;
        private DevExpress.XtraEditors.SimpleButton openFile;
        private DevExpress.XtraEditors.TextEdit textPath;
        private DevExpress.XtraEditors.SimpleButton importKey;
        private DevExpress.XtraEditors.ComboBoxEdit boxLength;
        private DevExpress.XtraEditors.TextEdit keyPath;
        private DevExpress.XtraEditors.ProgressBarControl progressBarControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ToggleSwitch toggleSwitch1;
        private DevExpress.XtraWaitForm.ProgressPanel progressPanel1;
    }
}
