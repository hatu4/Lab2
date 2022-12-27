using System;
using System.Drawing;
using System.Windows.Forms;
using FiguresLibrary;

namespace Lab2
{
    public partial class Form1 : Form
    {
        int rect_count = 0;
        int el_count = 0;
        int sq_count = 0;
        int circle_count = 0;
        public Form1()
        {
            InitializeComponent();
            Init.bitmap = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height);
            Init.pen = new Pen(Color.Black, 3);
            Init.pictureBox = pictureBox1;
            Init.figuresListBox = listBox1;

            Init.bs = new BindingSource();
            Init.bs.DataSource = ShapeContainer.figureList;
            listBox1.DataSource = Init.bs;
            listBox1.DisplayMember = "Info";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(rect_x.Text);
                int y = int.Parse(rect_y.Text);
                int w = int.Parse(rect_w.Text);
                int h = int.Parse(rect_h.Text);
                FiguresLibrary.Rectangle rect = new FiguresLibrary.Rectangle(rect_count + 1, x, y, w, h);
                if (rect.CoordsCheck(x, y, w, h))
                {
                    rect_count += 1;
                    ShapeContainer.AddFigure(rect);
                    Init.bs.ResetBindings(false);
                    rect.Draw();
                }
                else
                {
                    MessageBox.Show("Фигура вышла за границы.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Некорректный ввод.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(el_x.Text);
                int y = int.Parse(el_y.Text);
                int r1 = int.Parse(el_r1.Text);
                int r2 = int.Parse(el_r2.Text);
                Ellipse el = new Ellipse(el_count + 1, x, y, r1, r2);
                if (el.CoordsCheck(x, y, r1 * 2, r2 * 2))
                {
                    el_count += 1;
                    ShapeContainer.AddFigure(el);
                    Init.bs.ResetBindings(false);
                    el.Draw();
                }
                else
                {
                    MessageBox.Show("Фигура вышла за границы.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Некорректный ввод.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(sq_x.Text);
                int y = int.Parse(sq_y.Text);
                int w = int.Parse(sq_w.Text);
                Square sq = new Square(sq_count + 1, x, y, w);
                if (sq.CoordsCheck(x, y, w, w))
                {
                    sq_count += 1;
                    ShapeContainer.AddFigure(sq);
                    Init.bs.ResetBindings(false);
                    sq.Draw();
                }
                else
                {
                    MessageBox.Show("Фигура вышла за границы.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Некорректный ввод.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(ci_x.Text);
                int y = int.Parse(ci_y.Text);
                int r = int.Parse(ci_r.Text);
                Circle circle = new Circle(circle_count + 1, x, y, r);
                if (circle.CoordsCheck(x, y, r * 2, r * 2))
                {
                    circle_count += 1;
                    ShapeContainer.AddFigure(circle);
                    Init.bs.ResetBindings(false);
                    circle.Draw();
                }
                else
                {
                    MessageBox.Show("Фигура вышла за границы.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Некорректный ввод.");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form rect_form = new Rectangle_form();
            rect_form.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form ellipse_form = new Ellipse_form();
            ellipse_form.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form sq_form = new Square_form();
            sq_form.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form circle_form = new Circle_form();
            circle_form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(move_x.Text);
                int y = int.Parse(move_y.Text);
                if (Init.figuresListBox.SelectedIndex == -1)
                {
                    MessageBox.Show("Вы не выбрали фигуру.");
                    return;
                }
                Figure figure = (Figure)Init.figuresListBox.SelectedItem;
                if (figure.CoordsCheck(figure.x + x, figure.y + y, figure.w, figure.h))
                {
                    figure.MoveTo(x, y);
                }
                else
                {
                    MessageBox.Show("Фигура вышла за границы.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка ввода.");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Init.figuresListBox.SelectedIndex != -1)
            {
                Figure figure = (Figure)Init.figuresListBox.SelectedItem;
                figure.DeleteF(figure, true);
                Init.bs.ResetBindings(false);
            }   
        }
    }
}
