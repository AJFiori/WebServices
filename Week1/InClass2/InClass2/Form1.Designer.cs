namespace InClass2
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
            this.btnReadXMLValues = new System.Windows.Forms.Button();
            this.btnGetElementByTagName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReadXMLValues
            // 
            this.btnReadXMLValues.Location = new System.Drawing.Point(63, 26);
            this.btnReadXMLValues.Name = "btnReadXMLValues";
            this.btnReadXMLValues.Size = new System.Drawing.Size(240, 100);
            this.btnReadXMLValues.TabIndex = 0;
            this.btnReadXMLValues.Text = "Read XML Value";
            this.btnReadXMLValues.UseVisualStyleBackColor = true;
            this.btnReadXMLValues.Click += new System.EventHandler(this.btnReadXMLValues_Click);
            // 
            // btnGetElementByTagName
            // 
            this.btnGetElementByTagName.Location = new System.Drawing.Point(63, 167);
            this.btnGetElementByTagName.Name = "btnGetElementByTagName";
            this.btnGetElementByTagName.Size = new System.Drawing.Size(240, 117);
            this.btnGetElementByTagName.TabIndex = 9;
            this.btnGetElementByTagName.Text = "Get Element By Tag Name";
            this.btnGetElementByTagName.UseVisualStyleBackColor = true;
            this.btnGetElementByTagName.Click += new System.EventHandler(this.btnGetElementByTagName_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 313);
            this.Controls.Add(this.btnGetElementByTagName);
            this.Controls.Add(this.btnReadXMLValues);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReadXMLValues;
        private System.Windows.Forms.Button btnGetElementByTagName;
    }
}

