namespace Use_Case_Helper
{
    partial class Form_Main
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
            this.pictureBox_Main = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Main)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_Main
            // 
            this.pictureBox_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_Main.BackColor = System.Drawing.Color.White;
            this.pictureBox_Main.Location = new System.Drawing.Point(152, 13);
            this.pictureBox_Main.Name = "pictureBox_Main";
            this.pictureBox_Main.Size = new System.Drawing.Size(437, 471);
            this.pictureBox_Main.TabIndex = 0;
            this.pictureBox_Main.TabStop = false;
            this.pictureBox_Main.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Main_Paint);
            this.pictureBox_Main.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_Main_MouseDown);
            this.pictureBox_Main.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_Main_MouseMove);
            this.pictureBox_Main.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_Main_MouseUp);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 496);
            this.Controls.Add(this.pictureBox_Main);
            this.Name = "Form_Main";
            this.Text = "Use Case Helper";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Main)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Main;
    }
}

