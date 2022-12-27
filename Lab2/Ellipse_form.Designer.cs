namespace Lab2
{
    partial class Ellipse_form
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
            this.button2 = new System.Windows.Forms.Button();
            this.el_r2 = new System.Windows.Forms.TextBox();
            this.el_r1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(28, 78);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "изменить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // el_r2
            // 
            this.el_r2.Location = new System.Drawing.Point(55, 50);
            this.el_r2.Name = "el_r2";
            this.el_r2.Size = new System.Drawing.Size(76, 22);
            this.el_r2.TabIndex = 12;
            // 
            // el_r1
            // 
            this.el_r1.Location = new System.Drawing.Point(55, 22);
            this.el_r1.Name = "el_r1";
            this.el_r1.Size = new System.Drawing.Size(76, 22);
            this.el_r1.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "R2=";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "R1=";
            // 
            // Ellipse_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.el_r2);
            this.Controls.Add(this.el_r1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Name = "Ellipse_form";
            this.Text = "Ellipse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox el_r2;
        private System.Windows.Forms.TextBox el_r1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}