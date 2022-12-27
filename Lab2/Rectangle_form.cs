using System;
using System.Windows.Forms;
using FiguresLibrary;

namespace Lab2
{
    public partial class Rectangle_form : Form
    {
        public Rectangle_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int w = int.Parse(rect_w.Text);
                int h = int.Parse(rect_h.Text);
                if (Init.figuresListBox.SelectedIndex == -1)
                {
                    MessageBox.Show("Вы не выбрали фигуру.");
                    return;
                }
                Figure figure = (Figure)Init.figuresListBox.SelectedItem;
                if (figure.ToString() != "FiguresLibrary.Rectangle")
                {
                    MessageBox.Show("Вы выбрали не прямоугольник.");
                    return;
                }
                if (figure.CoordsCheck(figure.x, figure.y, w, h))
                {
                    figure.w = w;
                    figure.h = h;
                    figure.DeleteF(figure, false);
                    figure.Draw();
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
    }
}
