namespace Fiori_Lab1
{
    partial class Form1
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
            this.btnGetContacts = new System.Windows.Forms.Button();
            this.rResults = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnGetContacts
            // 
            this.btnGetContacts.Location = new System.Drawing.Point(1, 3);
            this.btnGetContacts.Name = "btnGetContacts";
            this.btnGetContacts.Size = new System.Drawing.Size(287, 51);
            this.btnGetContacts.TabIndex = 1;
            this.btnGetContacts.Text = "Get All Contacts";
            this.btnGetContacts.UseVisualStyleBackColor = true;
            this.btnGetContacts.Click += new System.EventHandler(this.btnGetContacts_Click);
            // 
            // rResults
            // 
            this.rResults.Location = new System.Drawing.Point(1, 61);
            this.rResults.Name = "rResults";
            this.rResults.Size = new System.Drawing.Size(287, 199);
            this.rResults.TabIndex = 2;
            this.rResults.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.rResults);
            this.Controls.Add(this.btnGetContacts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnGetContacts;
        private System.Windows.Forms.RichTextBox rResults;
    }
}

