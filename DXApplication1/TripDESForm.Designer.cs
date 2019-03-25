namespace DXApplication1
{
    partial class TripDESForm
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
            this.boxMode = new DevExpress.XtraEditors.ComboBoxEdit();
            this.textKey = new DevExpress.XtraEditors.TextEdit();
            this.textPath = new DevExpress.XtraEditors.TextEdit();
            this.genKey = new DevExpress.XtraEditors.SimpleButton();
            this.openFile1 = new DevExpress.XtraEditors.SimpleButton();
            this.decrypt = new DevExpress.XtraEditors.SimpleButton();
            this.encrypt = new DevExpress.XtraEditors.SimpleButton();
            this.progressBarControl1 = new DevExpress.XtraEditors.ProgressBarControl();
            this.toggle = new DevExpress.XtraEditors.ToggleSwitch();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.boxMode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textKey.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggle.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // boxMode
            // 
            this.boxMode.Location = new System.Drawing.Point(20, 45);
            this.boxMode.Name = "boxMode";
            this.boxMode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.boxMode.Size = new System.Drawing.Size(66, 20);
            this.boxMode.TabIndex = 1;
            // 
            // textKey
            // 
            this.textKey.Location = new System.Drawing.Point(140, 160);
            this.textKey.Name = "textKey";
            this.textKey.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.textKey.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.textKey.Properties.Appearance.Options.UseBackColor = true;
            this.textKey.Properties.Appearance.Options.UseForeColor = true;
            this.textKey.Size = new System.Drawing.Size(300, 20);
            this.textKey.TabIndex = 3;
            // 
            // textPath
            // 
            this.textPath.Location = new System.Drawing.Point(140, 210);
            this.textPath.Name = "textPath";
            this.textPath.Size = new System.Drawing.Size(300, 20);
            this.textPath.TabIndex = 4;
            // 
            // genKey
            // 
            this.genKey.Location = new System.Drawing.Point(480, 158);
            this.genKey.Name = "genKey";
            this.genKey.Size = new System.Drawing.Size(75, 23);
            this.genKey.TabIndex = 6;
            this.genKey.Text = "Gen";
            this.genKey.Click += new System.EventHandler(this.genKey_Click);
            // 
            // openFile1
            // 
            this.openFile1.Location = new System.Drawing.Point(480, 208);
            this.openFile1.Name = "openFile1";
            this.openFile1.Size = new System.Drawing.Size(75, 23);
            this.openFile1.TabIndex = 7;
            this.openFile1.Text = "Open";
            this.openFile1.Click += new System.EventHandler(this.openFile1_Click);
            // 
            // decrypt
            // 
            this.decrypt.Location = new System.Drawing.Point(330, 270);
            this.decrypt.Name = "decrypt";
            this.decrypt.Size = new System.Drawing.Size(75, 23);
            this.decrypt.TabIndex = 9;
            this.decrypt.Text = "Decrypt";
            this.decrypt.Click += new System.EventHandler(this.decrypt_Click);
            // 
            // encrypt
            // 
            this.encrypt.Location = new System.Drawing.Point(170, 270);
            this.encrypt.Name = "encrypt";
            this.encrypt.Size = new System.Drawing.Size(78, 23);
            this.encrypt.TabIndex = 10;
            this.encrypt.Text = "Encrypt";
            this.encrypt.Click += new System.EventHandler(this.encrypt_Click);
            // 
            // progressBarControl1
            // 
            this.progressBarControl1.Location = new System.Drawing.Point(90, 310);
            this.progressBarControl1.Name = "progressBarControl1";
            this.progressBarControl1.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.progressBarControl1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.progressBarControl1.Size = new System.Drawing.Size(420, 20);
            this.progressBarControl1.TabIndex = 11;
            // 
            // toggle
            // 
            this.toggle.Cursor = System.Windows.Forms.Cursors.Default;
            this.toggle.Location = new System.Drawing.Point(20, 75);
            this.toggle.Name = "toggle";
            this.toggle.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.toggle.Properties.Appearance.Options.UseForeColor = true;
            this.toggle.Properties.OffText = "       File";
            this.toggle.Properties.OnText = "       Folder";
            this.toggle.Size = new System.Drawing.Size(136, 24);
            this.toggle.TabIndex = 12;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(110, 48);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(51, 13);
            this.labelControl1.TabIndex = 13;
            this.labelControl1.Text = "Key length";
            // 
            // TripDESForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DXApplication1.Properties.Resources.w6;
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.toggle);
            this.Controls.Add(this.progressBarControl1);
            this.Controls.Add(this.encrypt);
            this.Controls.Add(this.decrypt);
            this.Controls.Add(this.openFile1);
            this.Controls.Add(this.genKey);
            this.Controls.Add(this.textPath);
            this.Controls.Add(this.textKey);
            this.Controls.Add(this.boxMode);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "TripDESForm";
            this.Size = new System.Drawing.Size(600, 350);
            this.Load += new System.EventHandler(this.DESForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.boxMode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textKey.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggle.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ComboBoxEdit boxMode;
        private DevExpress.XtraEditors.TextEdit textKey;
        private DevExpress.XtraEditors.TextEdit textPath;
        private DevExpress.XtraEditors.SimpleButton genKey;
        private DevExpress.XtraEditors.SimpleButton openFile1;
        private DevExpress.XtraEditors.SimpleButton decrypt;
        private DevExpress.XtraEditors.SimpleButton encrypt;
        private DevExpress.XtraEditors.ProgressBarControl progressBarControl1;
        private DevExpress.XtraEditors.ToggleSwitch toggle;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}
