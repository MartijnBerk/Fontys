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
            this.listBox_Entities = new System.Windows.Forms.ListBox();
            this.label_Entities = new System.Windows.Forms.Label();
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
            this.pictureBox_Main.Size = new System.Drawing.Size(472, 471);
            this.pictureBox_Main.TabIndex = 0;
            this.pictureBox_Main.TabStop = false;
            this.pictureBox_Main.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Main_Paint);
            this.pictureBox_Main.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_Main_MouseDown);
            this.pictureBox_Main.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_Main_MouseMove);
            this.pictureBox_Main.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_Main_MouseUp);
            // 
            // listBox_Entities
            // 
            this.listBox_Entities.FormattingEnabled = true;
            this.listBox_Entities.HorizontalScrollbar = true;
            this.listBox_Entities.ItemHeight = 16;
            this.listBox_Entities.Location = new System.Drawing.Point(630, 32);
            this.listBox_Entities.Name = "listBox_Entities";
            this.listBox_Entities.Size = new System.Drawing.Size(120, 452);
            this.listBox_Entities.TabIndex = 1;
            this.listBox_Entities.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBox_Entities_KeyDown);
            // 
            // label_Entities
            // 
            this.label_Entities.AutoSize = true;
            this.label_Entities.Location = new System.Drawing.Point(667, 14);
            this.label_Entities.Name = "label_Entities";
            this.label_Entities.Size = new System.Drawing.Size(54, 17);
            this.label_Entities.TabIndex = 2;
            this.label_Entities.Text = "Entities";
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 496);
            this.Controls.Add(this.label_Entities);
            this.Controls.Add(this.listBox_Entities);
            this.Controls.Add(this.pictureBox_Main);
            this.Name = "Form_Main";
            this.Text = "Use Case Helper";
            this.LocationChanged += new System.EventHandler(this.Form_Main_LocationChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Main)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Main;
        private System.Windows.Forms.ListBox listBox_Entities;
        private System.Windows.Forms.Label label_Entities;
    }
}

