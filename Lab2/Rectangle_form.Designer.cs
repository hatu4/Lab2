namespace Lab2
{
    partial class Rectangle_form
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
            this.button1 = new System.Windows.Forms.Button();
            this.rect_h = new System.Windows.Forms.TextBox();
            this.rect_w = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(51, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "изменить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rect_h
            // 
            this.rect_h.Location = new System.Drawing.Point(78, 69);
            this.rect_h.Name = "rect_h";
            this.rect_h.Size = new System.Drawing.Size(76, 22);
            this.rect_h.TabIndex = 12;
            // 
            // rect_w
            // 
            this.rect_w.Location = new System.Drawing.Point(78, 41);
            this.rect_w.Name = "rect_w";
            this.rect_w.Size = new System.Drawing.Size(76, 22);
            this.rect_w.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "H=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "W=";
            // 
            // Rectangle_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 172);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rect_h);
            this.Controls.Add(this.rect_w);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "Rectangle_form";
            this.Text = "Rectangle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox rect_h;
        private System.Windows.Forms.TextBox rect_w;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}