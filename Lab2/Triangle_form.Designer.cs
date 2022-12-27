namespace Lab2
{
    partial class Triangle_form
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
            this.btnDraw = new System.Windows.Forms.Button();
            this.y_3 = new System.Windows.Forms.TextBox();
            this.x_3 = new System.Windows.Forms.TextBox();
            this.y_2 = new System.Windows.Forms.TextBox();
            this.x_2 = new System.Windows.Forms.TextBox();
            this.y_1 = new System.Windows.Forms.TextBox();
            this.x_1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(28, 142);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(307, 35);
            this.btnDraw.TabIndex = 19;
            this.btnDraw.Text = "создать";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // y_3
            // 
            this.y_3.Location = new System.Drawing.Point(286, 102);
            this.y_3.Name = "y_3";
            this.y_3.Size = new System.Drawing.Size(49, 22);
            this.y_3.TabIndex = 18;
            // 
            // x_3
            // 
            this.x_3.Location = new System.Drawing.Point(286, 65);
            this.x_3.Name = "x_3";
            this.x_3.Size = new System.Drawing.Size(49, 22);
            this.x_3.TabIndex = 17;
            // 
            // y_2
            // 
            this.y_2.Location = new System.Drawing.Point(174, 102);
            this.y_2.Name = "y_2";
            this.y_2.Size = new System.Drawing.Size(49, 22);
            this.y_2.TabIndex = 16;
            // 
            // x_2
            // 
            this.x_2.Location = new System.Drawing.Point(174, 65);
            this.x_2.Name = "x_2";
            this.x_2.Size = new System.Drawing.Size(49, 22);
            this.x_2.TabIndex = 15;
            // 
            // y_1
            // 
            this.y_1.Location = new System.Drawing.Point(64, 101);
            this.y_1.Name = "y_1";
            this.y_1.Size = new System.Drawing.Size(49, 22);
            this.y_1.TabIndex = 14;
            // 
            // x_1
            // 
            this.x_1.Location = new System.Drawing.Point(64, 64);
            this.x_1.Name = "x_1";
            this.x_1.Size = new System.Drawing.Size(49, 22);
            this.x_1.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(23, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Y";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(23, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "X";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(43, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Задайте координаты точек треугольника";
            // 
            // Triangle_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 239);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.y_3);
            this.Controls.Add(this.x_3);
            this.Controls.Add(this.y_2);
            this.Controls.Add(this.x_2);
            this.Controls.Add(this.y_1);
            this.Controls.Add(this.x_1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Triangle_form";
            this.Text = "Triangle_form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.TextBox y_3;
        private System.Windows.Forms.TextBox x_3;
        private System.Windows.Forms.TextBox y_2;
        private System.Windows.Forms.TextBox x_2;
        private System.Windows.Forms.TextBox y_1;
        private System.Windows.Forms.TextBox x_1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}