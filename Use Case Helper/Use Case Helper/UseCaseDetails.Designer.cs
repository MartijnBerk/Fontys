namespace Use_Case_Helper
{
    partial class UseCaseDetails
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
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label_Name = new System.Windows.Forms.Label();
            this.button_Apply = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_Name
            // 
            this.textBox_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Name.Location = new System.Drawing.Point(68, 12);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(202, 22);
            this.textBox_Name.TabIndex = 0;
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(13, 12);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(49, 17);
            this.label_Name.TabIndex = 1;
            this.label_Name.Text = "Name:";
            // 
            // button_Apply
            // 
            this.button_Apply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Apply.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_Apply.Location = new System.Drawing.Point(194, 66);
            this.button_Apply.Name = "button_Apply";
            this.button_Apply.Size = new System.Drawing.Size(75, 30);
            this.button_Apply.TabIndex = 2;
            this.button_Apply.Text = "Apply";
            this.button_Apply.UseVisualStyleBackColor = true;
            this.button_Apply.Click += new System.EventHandler(this.button_Apply_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Cancel.Location = new System.Drawing.Point(13, 66);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 30);
            this.button_Cancel.TabIndex = 3;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            // 
            // UseCaseDetails
            // 
            this.AcceptButton = this.button_Apply;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_Cancel;
            this.ClientSize = new System.Drawing.Size(282, 108);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Apply);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.textBox_Name);
            this.Name = "UseCaseDetails";
            this.Text = "Use Case Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Button button_Apply;
        private System.Windows.Forms.Button button_Cancel;
    }
}