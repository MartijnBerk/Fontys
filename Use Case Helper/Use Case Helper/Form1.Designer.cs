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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox_Element = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Main)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox_Main
            // 
            this.pictureBox_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_Main.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox_Main.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_Main.Location = new System.Drawing.Point(211, 13);
            this.pictureBox_Main.Name = "pictureBox_Main";
            this.pictureBox_Main.Size = new System.Drawing.Size(594, 471);
            this.pictureBox_Main.TabIndex = 0;
            this.pictureBox_Main.TabStop = false;
            this.pictureBox_Main.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Main_Paint);
            this.pictureBox_Main.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_Main_MouseDown);
            this.pictureBox_Main.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_Main_MouseMove);
            this.pictureBox_Main.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_Main_MouseUp);
            // 
            // listBox_Entities
            // 
            this.listBox_Entities.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox_Entities.FormattingEnabled = true;
            this.listBox_Entities.HorizontalScrollbar = true;
            this.listBox_Entities.ItemHeight = 16;
            this.listBox_Entities.Location = new System.Drawing.Point(820, 32);
            this.listBox_Entities.Name = "listBox_Entities";
            this.listBox_Entities.Size = new System.Drawing.Size(111, 452);
            this.listBox_Entities.TabIndex = 1;
            this.listBox_Entities.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBox_Entities_KeyDown);
            // 
            // label_Entities
            // 
            this.label_Entities.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Entities.AutoSize = true;
            this.label_Entities.Location = new System.Drawing.Point(853, 9);
            this.label_Entities.Name = "label_Entities";
            this.label_Entities.Size = new System.Drawing.Size(54, 17);
            this.label_Entities.TabIndex = 2;
            this.label_Entities.Text = "Entities";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_Element);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 67);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Element";
            // 
            // comboBox_Element
            // 
            this.comboBox_Element.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Element.FormattingEnabled = true;
            this.comboBox_Element.Items.AddRange(new object[] {
            "Use Case",
            "Actor"});
            this.comboBox_Element.Location = new System.Drawing.Point(6, 21);
            this.comboBox_Element.Name = "comboBox_Element";
            this.comboBox_Element.Size = new System.Drawing.Size(181, 24);
            this.comboBox_Element.TabIndex = 0;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 496);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label_Entities);
            this.Controls.Add(this.listBox_Entities);
            this.Controls.Add(this.pictureBox_Main);
            this.Name = "Form_Main";
            this.Text = "Use Case Helper";
            this.LocationChanged += new System.EventHandler(this.Form_Main_LocationChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Main)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Main;
        private System.Windows.Forms.ListBox listBox_Entities;
        private System.Windows.Forms.Label label_Entities;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox_Element;
    }
}

