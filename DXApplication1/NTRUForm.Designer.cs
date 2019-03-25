namespace DXApplication1
{
    partial class NTRUForm
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
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.file = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.keyPath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filePath.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // keyPath
            // 
            this.keyPath.Location = new System.Drawing.Point(140, 160);
            this.keyPath.Name = "keyPath";
            this.keyPath.Size = new System.Drawing.Size(300, 20);
            this.keyPath.TabIndex = 0;
            // 
            // filePath
            // 
            this.filePath.Location = new System.Drawing.Point(140, 210);
            this.filePath.Name = "filePath";
            this.filePath.Size = new System.Drawing.Size(300, 20);
            this.filePath.TabIndex = 1;
            // 
            // gen
            // 
            this.gen.Location = new System.Drawing.Point(480, 108);
            this.gen.Name = "gen";
            this.gen.Size = new System.Drawing.Size(75, 23);
            this.gen.TabIndex = 2;
            this.gen.Text = "Gen";
            this.gen.Click += new System.EventHandler(this.gen_Click);
            // 
            // key
            // 
            this.key.Location = new System.Drawing.Point(480, 158);
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(75, 23);
            this.key.TabIndex = 3;
            this.key.Text = "Key";
            this.key.Click += new System.EventHandler(this.key_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(170, 270);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(75, 23);
            this.simpleButton3.TabIndex = 4;
            this.simpleButton3.Text = "Encrypt";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Location = new System.Drawing.Point(330, 270);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(75, 23);
            this.simpleButton4.TabIndex = 5;
            this.simpleButton4.Text = "Decrypt";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // file
            // 
            this.file.Location = new System.Drawing.Point(480, 208);
            this.file.Name = "file";
            this.file.Size = new System.Drawing.Size(75, 23);
            this.file.TabIndex = 6;
            this.file.Text = "File";
            this.file.Click += new System.EventHandler(this.file_Click);
            // 
            // NTRUForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DXApplication1.Properties.Resources.w4;
            this.Controls.Add(this.file);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.key);
            this.Controls.Add(this.gen);
            this.Controls.Add(this.filePath);
            this.Controls.Add(this.keyPath);
            this.Name = "NTRUForm";
            this.Size = new System.Drawing.Size(600, 350);
            ((System.ComponentModel.ISupportInitialize)(this.keyPath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filePath.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit keyPath;
        private DevExpress.XtraEditors.TextEdit filePath;
        private DevExpress.XtraEditors.SimpleButton gen;
        private DevExpress.XtraEditors.SimpleButton key;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton file;
    }
}
