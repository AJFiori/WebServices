namespace Inclass
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
            this.btnReturnAll = new System.Windows.Forms.Button();
            this.btnReturnMales = new System.Windows.Forms.Button();
            this.btnLastName = new System.Windows.Forms.Button();
            this.rtAllInfo = new System.Windows.Forms.RichTextBox();
            this.rtMales = new System.Windows.Forms.RichTextBox();
            this.rtLastName = new System.Windows.Forms.RichTextBox();
            this.lblVersionDate = new System.Windows.Forms.Label();
            this.lblVersionNumber = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnReturnAll
            // 
            this.btnReturnAll.Location = new System.Drawing.Point(1, 46);
            this.btnReturnAll.Name = "btnReturnAll";
            this.btnReturnAll.Size = new System.Drawing.Size(164, 23);
            this.btnReturnAll.TabIndex = 0;
            this.btnReturnAll.Text = "Return All Info";
            this.btnReturnAll.UseVisualStyleBackColor = true;
            this.btnReturnAll.Click += new System.EventHandler(this.btnReturnAll_Click);
            // 
            // btnReturnMales
            // 
            this.btnReturnMales.Location = new System.Drawing.Point(314, 46);
            this.btnReturnMales.Name = "btnReturnMales";
            this.btnReturnMales.Size = new System.Drawing.Size(171, 23);
            this.btnReturnMales.TabIndex = 1;
            this.btnReturnMales.Text = "Return All Males";
            this.btnReturnMales.UseVisualStyleBackColor = true;
            this.btnReturnMales.Click += new System.EventHandler(this.btnReturnMales_Click);
            // 
            // btnLastName
            // 
            this.btnLastName.Location = new System.Drawing.Point(163, 301);
            this.btnLastName.Name = "btnLastName";
            this.btnLastName.Size = new System.Drawing.Size(145, 23);
            this.btnLastName.TabIndex = 2;
            this.btnLastName.Text = "Get Last Name";
            this.btnLastName.UseVisualStyleBackColor = true;
            this.btnLastName.Click += new System.EventHandler(this.btnLastName_Click);
            // 
            // rtAllInfo
            // 
            this.rtAllInfo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.rtAllInfo.Location = new System.Drawing.Point(1, 75);
            this.rtAllInfo.Name = "rtAllInfo";
            this.rtAllInfo.Size = new System.Drawing.Size(164, 194);
            this.rtAllInfo.TabIndex = 3;
            this.rtAllInfo.Text = "";
            // 
            // rtMales
            // 
            this.rtMales.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.rtMales.Location = new System.Drawing.Point(314, 75);
            this.rtMales.Name = "rtMales";
            this.rtMales.Size = new System.Drawing.Size(171, 194);
            this.rtMales.TabIndex = 4;
            this.rtMales.Text = "";
            // 
            // rtLastName
            // 
            this.rtLastName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.rtLastName.Location = new System.Drawing.Point(1, 327);
            this.rtLastName.Name = "rtLastName";
            this.rtLastName.Size = new System.Drawing.Size(473, 83);
            this.rtLastName.TabIndex = 5;
            this.rtLastName.Text = "";
            // 
            // lblVersionDate
            // 
            this.lblVersionDate.AutoSize = true;
            this.lblVersionDate.Location = new System.Drawing.Point(1, 4);
            this.lblVersionDate.Name = "lblVersionDate";
            this.lblVersionDate.Size = new System.Drawing.Size(35, 13);
            this.lblVersionDate.TabIndex = 6;
            this.lblVersionDate.Text = "label1";
            // 
            // lblVersionNumber
            // 
            this.lblVersionNumber.AutoSize = true;
            this.lblVersionNumber.Location = new System.Drawing.Point(311, 4);
            this.lblVersionNumber.Name = "lblVersionNumber";
            this.lblVersionNumber.Size = new System.Drawing.Size(35, 13);
            this.lblVersionNumber.TabIndex = 7;
            this.lblVersionNumber.Text = "label2";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(163, 275);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(145, 20);
            this.txtLastName.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 414);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblVersionNumber);
            this.Controls.Add(this.lblVersionDate);
            this.Controls.Add(this.rtLastName);
            this.Controls.Add(this.rtMales);
            this.Controls.Add(this.rtAllInfo);
            this.Controls.Add(this.btnLastName);
            this.Controls.Add(this.btnReturnMales);
            this.Controls.Add(this.btnReturnAll);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturnAll;
        private System.Windows.Forms.Button btnReturnMales;
        private System.Windows.Forms.Button btnLastName;
        private System.Windows.Forms.RichTextBox rtAllInfo;
        private System.Windows.Forms.RichTextBox rtMales;
        private System.Windows.Forms.RichTextBox rtLastName;
        private System.Windows.Forms.Label lblVersionDate;
        private System.Windows.Forms.Label lblVersionNumber;
        private System.Windows.Forms.TextBox txtLastName;
    }
}

