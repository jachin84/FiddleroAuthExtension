namespace FiddlerOAuth
{
    partial class FiddlerOAuthUI
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
            this.enableFilter = new System.Windows.Forms.CheckBox();
            this.optionsGroupBox = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.cmbSignMethod = new System.Windows.Forms.ComboBox();
            this.txtTokenSecret = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtConsumerSecret = new System.Windows.Forms.TextBox();
            this.txtToken = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtConsumerKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtThumbprint = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.optionsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // enableFilter
            // 
            this.enableFilter.AutoSize = true;
            this.enableFilter.Location = new System.Drawing.Point(10, 10);
            this.enableFilter.Name = "enableFilter";
            this.enableFilter.Size = new System.Drawing.Size(141, 17);
            this.enableFilter.TabIndex = 1;
            this.enableFilter.Text = "Enable OAuth Extension";
            this.enableFilter.UseVisualStyleBackColor = true;
            // 
            // optionsGroupBox
            // 
            this.optionsGroupBox.Controls.Add(this.txtThumbprint);
            this.optionsGroupBox.Controls.Add(this.label6);
            this.optionsGroupBox.Controls.Add(this.btnSave);
            this.optionsGroupBox.Controls.Add(this.btnApply);
            this.optionsGroupBox.Controls.Add(this.cmbSignMethod);
            this.optionsGroupBox.Controls.Add(this.txtTokenSecret);
            this.optionsGroupBox.Controls.Add(this.label5);
            this.optionsGroupBox.Controls.Add(this.label4);
            this.optionsGroupBox.Controls.Add(this.txtConsumerSecret);
            this.optionsGroupBox.Controls.Add(this.txtToken);
            this.optionsGroupBox.Controls.Add(this.label2);
            this.optionsGroupBox.Controls.Add(this.label3);
            this.optionsGroupBox.Controls.Add(this.txtConsumerKey);
            this.optionsGroupBox.Controls.Add(this.label1);
            this.optionsGroupBox.Location = new System.Drawing.Point(10, 33);
            this.optionsGroupBox.Name = "optionsGroupBox";
            this.optionsGroupBox.Size = new System.Drawing.Size(458, 251);
            this.optionsGroupBox.TabIndex = 3;
            this.optionsGroupBox.TabStop = false;
            this.optionsGroupBox.Text = "OAuth Params";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(367, 207);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save...";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnApply
            // 
            this.btnApply.Enabled = false;
            this.btnApply.Location = new System.Drawing.Point(220, 207);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 10;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            // 
            // cmbSignMethod
            // 
            this.cmbSignMethod.FormattingEnabled = true;
            this.cmbSignMethod.Items.AddRange(new object[] {
            "HMAC-SHA1",
            "RSA-SHA1",
            "PLAINTEXT"});
            this.cmbSignMethod.Location = new System.Drawing.Point(117, 209);
            this.cmbSignMethod.Name = "cmbSignMethod";
            this.cmbSignMethod.Size = new System.Drawing.Size(78, 21);
            this.cmbSignMethod.TabIndex = 9;
            this.cmbSignMethod.Text = "HMAC-SHA1";
            this.cmbSignMethod.SelectedIndexChanged += new System.EventHandler(this.cmbSignMethod_SelectedIndexChanged);
            // 
            // txtTokenSecret
            // 
            this.txtTokenSecret.Location = new System.Drawing.Point(117, 130);
            this.txtTokenSecret.Name = "txtTokenSecret";
            this.txtTokenSecret.Size = new System.Drawing.Size(325, 20);
            this.txtTokenSecret.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "SignMethod";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "TokenSecret";
            // 
            // txtConsumerSecret
            // 
            this.txtConsumerSecret.Location = new System.Drawing.Point(117, 62);
            this.txtConsumerSecret.Name = "txtConsumerSecret";
            this.txtConsumerSecret.Size = new System.Drawing.Size(325, 20);
            this.txtConsumerSecret.TabIndex = 3;
            // 
            // txtToken
            // 
            this.txtToken.Location = new System.Drawing.Point(117, 96);
            this.txtToken.Name = "txtToken";
            this.txtToken.Size = new System.Drawing.Size(325, 20);
            this.txtToken.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ConsumerSecret";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Token";
            // 
            // txtConsumerKey
            // 
            this.txtConsumerKey.Location = new System.Drawing.Point(117, 28);
            this.txtConsumerKey.Name = "txtConsumerKey";
            this.txtConsumerKey.Size = new System.Drawing.Size(325, 20);
            this.txtConsumerKey.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ConsumerKey";
            // 
            // txtThumbprint
            // 
            this.txtThumbprint.Location = new System.Drawing.Point(117, 164);
            this.txtThumbprint.Name = "txtThumbprint";
            this.txtThumbprint.Size = new System.Drawing.Size(325, 20);
            this.txtThumbprint.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Location = new System.Drawing.Point(24, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Thumbprint";
            // 
            // FiddlerOAuthUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.optionsGroupBox);
            this.Controls.Add(this.enableFilter);
            this.Name = "FiddlerOAuthUI";
            this.Size = new System.Drawing.Size(809, 386);
            this.optionsGroupBox.ResumeLayout(false);
            this.optionsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox enableFilter;
        private System.Windows.Forms.GroupBox optionsGroupBox;
        private System.Windows.Forms.TextBox txtThumbprint;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.ComboBox cmbSignMethod;
        private System.Windows.Forms.TextBox txtTokenSecret;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtConsumerSecret;
        private System.Windows.Forms.TextBox txtToken;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtConsumerKey;
        private System.Windows.Forms.Label label1;
    }
}
