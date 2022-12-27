using System;
using System.Windows.Forms;
using FiguresLibrary;

namespace Lab2
{
    public partial class Square_form : Form
    {
        public Square_form()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int w = int.Parse(sq_w.Text);
                if (Init.figuresListBox.SelectedIndex == -1)
                {
                    MessageBox.Show("Вы не выбрали фигуру.");
                    return;
                }
                Figure figure = (Figure)Init.figuresListBox.SelectedItem;
                if (figure.ToString() != "FiguresLibrary.Square")
                {
                    MessageBox.Show("Вы выбрали не квадрат.");
                    return;
                }
                if (figure.CoordsCheck(figure.x, figure.y, w, w))
                {
                    figure.w = w;
                    figure.h = w;
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
