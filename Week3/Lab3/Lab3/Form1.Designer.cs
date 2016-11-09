namespace Lab3
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
            this.btnZipCode = new System.Windows.Forms.Button();
            this.btnGetNerbyZip = new System.Windows.Forms.Button();
            this.btnGetForeCast = new System.Windows.Forms.Button();
            this.rtForeCast = new System.Windows.Forms.RichTextBox();
            this.rtZipResults = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnZipCode
            // 
            this.btnZipCode.Location = new System.Drawing.Point(27, 308);
            this.btnZipCode.Name = "btnZipCode";
            this.btnZipCode.Size = new System.Drawing.Size(138, 23);
            this.btnZipCode.TabIndex = 0;
            this.btnZipCode.Text = "Get Cities By Zip Code";
            this.btnZipCode.UseVisualStyleBackColor = true;
            this.btnZipCode.Click += new System.EventHandler(this.btnZipCode_Click);
            // 
            // btnGetNerbyZip
            // 
            this.btnGetNerbyZip.Location = new System.Drawing.Point(27, 337);
            this.btnGetNerbyZip.Name = "btnGetNerbyZip";
            this.btnGetNerbyZip.Size = new System.Drawing.Size(140, 23);
            this.btnGetNerbyZip.TabIndex = 1;
            this.btnGetNerbyZip.Text = "Get Near By Cities Zip Code";
            this.btnGetNerbyZip.UseVisualStyleBackColor = true;
            this.btnGetNerbyZip.Click += new System.EventHandler(this.btnGetNerbyZip_Click);
            // 
            // btnGetForeCast
            // 
            this.btnGetForeCast.Location = new System.Drawing.Point(39, 30);
            this.btnGetForeCast.Name = "btnGetForeCast";
            this.btnGetForeCast.Size = new System.Drawing.Size(388, 23);
            this.btnGetForeCast.TabIndex = 2;
            this.btnGetForeCast.Text = "Get Forecast";
            this.btnGetForeCast.UseVisualStyleBackColor = true;
            this.btnGetForeCast.Click += new System.EventHandler(this.btnGetForeCast_Click);
            // 
            // rtForeCast
            // 
            this.rtForeCast.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtForeCast.Location = new System.Drawing.Point(39, 59);
            this.rtForeCast.Name = "rtForeCast";
            this.rtForeCast.Size = new System.Drawing.Size(388, 195);
            this.rtForeCast.TabIndex = 3;
            this.rtForeCast.Text = "";
            // 
            // rtZipResults
            // 
            this.rtZipResults.Location = new System.Drawing.Point(168, 272);
            this.rtZipResults.Name = "rtZipResults";
            this.rtZipResults.Size = new System.Drawing.Size(259, 88);
            this.rtZipResults.TabIndex = 4;
            this.rtZipResults.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter Zip:";
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(76, 282);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(88, 20);
            this.txtZip.TabIndex = 6;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(154, 373);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(140, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 408);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtZip);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtZipResults);
            this.Controls.Add(this.rtForeCast);
            this.Controls.Add(this.btnGetForeCast);
            this.Controls.Add(this.btnGetNerbyZip);
            this.Controls.Add(this.btnZipCode);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnZipCode;
        private System.Windows.Forms.Button btnGetNerbyZip;
        private System.Windows.Forms.Button btnGetForeCast;
        private System.Windows.Forms.RichTextBox rtForeCast;
        private System.Windows.Forms.RichTextBox rtZipResults;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.Button btnClear;
    }
}

