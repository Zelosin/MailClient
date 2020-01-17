namespace Mailclient
{
    partial class ReadMailForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MailBody = new System.Windows.Forms.TextBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.WebBrowser = new System.Windows.Forms.WebBrowser();
            this.DisplayTextBtn = new System.Windows.Forms.Button();
            this.DisplayHTMLBtn = new System.Windows.Forms.Button();
            this.DeleteMailBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // MailBody
            // 
            this.MailBody.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MailBody.ForeColor = System.Drawing.Color.White;
            this.MailBody.Location = new System.Drawing.Point(12, 54);
            this.MailBody.Multiline = true;
            this.MailBody.Name = "MailBody";
            this.MailBody.ReadOnly = true;
            this.MailBody.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MailBody.Size = new System.Drawing.Size(377, 294);
            this.MailBody.TabIndex = 18;
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddressLabel.ForeColor = System.Drawing.Color.White;
            this.AddressLabel.Location = new System.Drawing.Point(9, 10);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(0, 14);
            this.AddressLabel.TabIndex = 13;
            // 
            // WebBrowser
            // 
            this.WebBrowser.Location = new System.Drawing.Point(12, 54);
            this.WebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.WebBrowser.Name = "WebBrowser";
            this.WebBrowser.Size = new System.Drawing.Size(377, 294);
            this.WebBrowser.TabIndex = 19;
            this.WebBrowser.Visible = false;
            // 
            // DisplayTextBtn
            // 
            this.DisplayTextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DisplayTextBtn.ForeColor = System.Drawing.Color.White;
            this.DisplayTextBtn.Location = new System.Drawing.Point(12, 354);
            this.DisplayTextBtn.Name = "DisplayTextBtn";
            this.DisplayTextBtn.Size = new System.Drawing.Size(118, 23);
            this.DisplayTextBtn.TabIndex = 20;
            this.DisplayTextBtn.Text = "Показать текст";
            this.DisplayTextBtn.UseVisualStyleBackColor = true;
            this.DisplayTextBtn.Click += new System.EventHandler(this.DisplayTextBtn_Click);
            // 
            // DisplayHTMLBtn
            // 
            this.DisplayHTMLBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DisplayHTMLBtn.ForeColor = System.Drawing.Color.White;
            this.DisplayHTMLBtn.Location = new System.Drawing.Point(136, 354);
            this.DisplayHTMLBtn.Name = "DisplayHTMLBtn";
            this.DisplayHTMLBtn.Size = new System.Drawing.Size(125, 23);
            this.DisplayHTMLBtn.TabIndex = 21;
            this.DisplayHTMLBtn.Text = "Показать в браузере";
            this.DisplayHTMLBtn.UseVisualStyleBackColor = true;
            this.DisplayHTMLBtn.Click += new System.EventHandler(this.DisplayHTMLBtn_Click);
            // 
            // DeleteMailBtn
            // 
            this.DeleteMailBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteMailBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteMailBtn.Location = new System.Drawing.Point(267, 354);
            this.DeleteMailBtn.Name = "DeleteMailBtn";
            this.DeleteMailBtn.Size = new System.Drawing.Size(104, 23);
            this.DeleteMailBtn.TabIndex = 22;
            this.DeleteMailBtn.Text = "Удалить письмо";
            this.DeleteMailBtn.UseVisualStyleBackColor = true;
            this.DeleteMailBtn.Click += new System.EventHandler(this.DeleteMailBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(372, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(31, 363);
            this.panel1.TabIndex = 23;
            // 
            // ReadMailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 389);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DeleteMailBtn);
            this.Controls.Add(this.DisplayHTMLBtn);
            this.Controls.Add(this.DisplayTextBtn);
            this.Controls.Add(this.WebBrowser);
            this.Controls.Add(this.MailBody);
            this.Controls.Add(this.AddressLabel);
            this.Name = "ReadMailForm";
            this.Text = "ReadMailForm";
            this.Load += new System.EventHandler(this.ReadMailForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox MailBody;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.WebBrowser WebBrowser;
        private System.Windows.Forms.Button DisplayTextBtn;
        private System.Windows.Forms.Button DisplayHTMLBtn;
        private System.Windows.Forms.Button DeleteMailBtn;
        private System.Windows.Forms.Panel panel1;
    }
}