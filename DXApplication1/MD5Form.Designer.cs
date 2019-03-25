namespace DXApplication1
{
    partial class MD5Form
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
            this.btnOpenFile = new DevExpress.XtraEditors.SimpleButton();
            this.textInput = new DevExpress.XtraEditors.TextEdit();
            this.textOutput = new System.Windows.Forms.TextBox();
            this.btnHash = new DevExpress.XtraEditors.SimpleButton();
            this.toggleSwitch1 = new DevExpress.XtraEditors.ToggleSwitch();
            ((System.ComponentModel.ISupportInitialize)(this.textInput.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnOpenFile.Appearance.Options.UseForeColor = true;
            this.btnOpenFile.Location = new System.Drawing.Point(480, 158);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(75, 23);
            this.btnOpenFile.TabIndex = 0;
            this.btnOpenFile.Text = "Open";
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // textInput
            // 
            this.textInput.Location = new System.Drawing.Point(140, 160);
            this.textInput.Name = "textInput";
            this.textInput.Size = new System.Drawing.Size(300, 20);
            this.textInput.TabIndex = 1;
            // 
            // textOutput
            // 
            this.textOutput.Location = new System.Drawing.Point(140, 210);
            this.textOutput.Name = "textOutput";
            this.textOutput.Size = new System.Drawing.Size(300, 21);
            this.textOutput.TabIndex = 4;
            // 
            // btnHash
            // 
            this.btnHash.Location = new System.Drawing.Point(260, 260);
            this.btnHash.Name = "btnHash";
            this.btnHash.Size = new System.Drawing.Size(75, 23);
            this.btnHash.TabIndex = 5;
            this.btnHash.Text = "Hash";
            this.btnHash.Click += new System.EventHandler(this.btnHash_Click);
            // 
            // toggleSwitch1
            // 
            this.toggleSwitch1.Location = new System.Drawing.Point(20, 75);
            this.toggleSwitch1.Name = "toggleSwitch1";
            this.toggleSwitch1.Properties.OffText = "       Text";
            this.toggleSwitch1.Properties.OnText = "       File";
            this.toggleSwitch1.Size = new System.Drawing.Size(123, 24);
            this.toggleSwitch1.TabIndex = 7;
            this.toggleSwitch1.Toggled += new System.EventHandler(this.toggleSwitch1_Toggled);
            // 
            // MD5Form
            // 
            this.Appearance.ForeColor = System.Drawing.Color.White;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DXApplication1.Properties.Resources.q1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.toggleSwitch1);
            this.Controls.Add(this.btnHash);
            this.Controls.Add(this.textOutput);
            this.Controls.Add(this.textInput);
            this.Controls.Add(this.btnOpenFile);
            this.Name = "MD5Form";
            this.Size = new System.Drawing.Size(600, 350);
            ((System.ComponentModel.ISupportInitialize)(this.textInput.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnOpenFile;
        private DevExpress.XtraEditors.TextEdit textInput;
        private System.Windows.Forms.TextBox textOutput;
        private DevExpress.XtraEditors.SimpleButton btnHash;
        private DevExpress.XtraEditors.ToggleSwitch toggleSwitch1;
    }
}
