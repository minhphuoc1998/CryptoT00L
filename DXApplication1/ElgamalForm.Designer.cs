namespace DXApplication1
{
    partial class ElgamalForm
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
            this.keyGen = new DevExpress.XtraEditors.SimpleButton();
            this.openFile = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.filePath = new DevExpress.XtraEditors.TextEdit();
            this.keyPath = new DevExpress.XtraEditors.TextEdit();
            this.importKey = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.filePath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyPath.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // keyGen
            // 
            this.keyGen.Location = new System.Drawing.Point(480, 108);
            this.keyGen.Name = "keyGen";
            this.keyGen.Size = new System.Drawing.Size(75, 23);
            this.keyGen.TabIndex = 0;
            this.keyGen.Text = "Gen";
            this.keyGen.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // openFile
            // 
            this.openFile.Location = new System.Drawing.Point(480, 208);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(75, 23);
            this.openFile.TabIndex = 1;
            this.openFile.Text = "Open";
            this.openFile.Click += new System.EventHandler(this.openFile_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(170, 270);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(75, 23);
            this.simpleButton3.TabIndex = 2;
            this.simpleButton3.Text = "encrypt";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Location = new System.Drawing.Point(330, 270);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(75, 23);
            this.simpleButton4.TabIndex = 3;
            this.simpleButton4.Text = "decrypt";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // filePath
            // 
            this.filePath.Location = new System.Drawing.Point(140, 210);
            this.filePath.Name = "filePath";
            this.filePath.Size = new System.Drawing.Size(300, 20);
            this.filePath.TabIndex = 5;
            // 
            // keyPath
            // 
            this.keyPath.Location = new System.Drawing.Point(140, 160);
            this.keyPath.Name = "keyPath";
            this.keyPath.Size = new System.Drawing.Size(300, 20);
            this.keyPath.TabIndex = 6;
            // 
            // importKey
            // 
            this.importKey.Location = new System.Drawing.Point(480, 158);
            this.importKey.Name = "importKey";
            this.importKey.Size = new System.Drawing.Size(75, 23);
            this.importKey.TabIndex = 7;
            this.importKey.Text = "Key";
            this.importKey.Click += new System.EventHandler(this.importKey_Click);
            // 
            // ElgamalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DXApplication1.Properties.Resources.w3;
            this.Controls.Add(this.importKey);
            this.Controls.Add(this.keyPath);
            this.Controls.Add(this.filePath);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.openFile);
            this.Controls.Add(this.keyGen);
            this.Name = "ElgamalForm";
            this.Size = new System.Drawing.Size(600, 350);
            ((System.ComponentModel.ISupportInitialize)(this.filePath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyPath.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton keyGen;
        private DevExpress.XtraEditors.SimpleButton openFile;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.TextEdit filePath;
        private DevExpress.XtraEditors.TextEdit keyPath;
        private DevExpress.XtraEditors.SimpleButton importKey;
    }
}
