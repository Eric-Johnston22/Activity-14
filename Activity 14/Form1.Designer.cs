namespace Activity_14
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
            this.listBox_images = new System.Windows.Forms.ListBox();
            this.checkBox_name = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_display = new System.Windows.Forms.Button();
            this.checkBox_date = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radio_lightmode = new System.Windows.Forms.RadioButton();
            this.radio_darkmode = new System.Windows.Forms.RadioButton();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox_images
            // 
            this.listBox_images.FormattingEnabled = true;
            this.listBox_images.Items.AddRange(new object[] {
            "Dragon",
            "Planet",
            "Rooster"});
            this.listBox_images.Location = new System.Drawing.Point(34, 29);
            this.listBox_images.Name = "listBox_images";
            this.listBox_images.Size = new System.Drawing.Size(139, 121);
            this.listBox_images.TabIndex = 0;
            // 
            // checkBox_name
            // 
            this.checkBox_name.AutoSize = true;
            this.checkBox_name.Location = new System.Drawing.Point(14, 13);
            this.checkBox_name.Name = "checkBox_name";
            this.checkBox_name.Size = new System.Drawing.Size(54, 17);
            this.checkBox_name.TabIndex = 1;
            this.checkBox_name.Text = "Name";
            this.checkBox_name.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(331, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(446, 370);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btn_display
            // 
            this.btn_display.Location = new System.Drawing.Point(34, 371);
            this.btn_display.Name = "btn_display";
            this.btn_display.Size = new System.Drawing.Size(121, 40);
            this.btn_display.TabIndex = 3;
            this.btn_display.Text = "Show Image";
            this.btn_display.UseVisualStyleBackColor = true;
            this.btn_display.Click += new System.EventHandler(this.btn_display_Click);
            // 
            // checkBox_date
            // 
            this.checkBox_date.AutoSize = true;
            this.checkBox_date.Location = new System.Drawing.Point(14, 37);
            this.checkBox_date.Name = "checkBox_date";
            this.checkBox_date.Size = new System.Drawing.Size(49, 17);
            this.checkBox_date.TabIndex = 4;
            this.checkBox_date.Text = "Date";
            this.checkBox_date.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBox_name);
            this.panel1.Controls.Add(this.checkBox_date);
            this.panel1.Location = new System.Drawing.Point(34, 280);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(121, 68);
            this.panel1.TabIndex = 5;
            // 
            // radio_lightmode
            // 
            this.radio_lightmode.AutoSize = true;
            this.radio_lightmode.Location = new System.Drawing.Point(14, 15);
            this.radio_lightmode.Name = "radio_lightmode";
            this.radio_lightmode.Size = new System.Drawing.Size(77, 17);
            this.radio_lightmode.TabIndex = 6;
            this.radio_lightmode.TabStop = true;
            this.radio_lightmode.Text = "Light mode";
            this.radio_lightmode.UseVisualStyleBackColor = true;
            // 
            // radio_darkmode
            // 
            this.radio_darkmode.AutoSize = true;
            this.radio_darkmode.Location = new System.Drawing.Point(14, 38);
            this.radio_darkmode.Name = "radio_darkmode";
            this.radio_darkmode.Size = new System.Drawing.Size(78, 17);
            this.radio_darkmode.TabIndex = 7;
            this.radio_darkmode.TabStop = true;
            this.radio_darkmode.Text = "Dark Mode";
            this.radio_darkmode.UseVisualStyleBackColor = true;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(464, 398);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(0, 13);
            this.lbl_name.TabIndex = 8;
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(610, 398);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(0, 13);
            this.lbl_date.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radio_lightmode);
            this.panel2.Controls.Add(this.radio_darkmode);
            this.panel2.Location = new System.Drawing.Point(34, 174);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(121, 86);
            this.panel2.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_display);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listBox_images);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_images;
        private System.Windows.Forms.CheckBox checkBox_name;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_display;
        private System.Windows.Forms.CheckBox checkBox_date;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radio_lightmode;
        private System.Windows.Forms.RadioButton radio_darkmode;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Panel panel2;
    }
}

