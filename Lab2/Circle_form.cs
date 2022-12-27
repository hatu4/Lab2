using System;
using System.Windows.Forms;
using FiguresLibrary;

namespace Lab2
{
    public partial class Circle_form : Form
    {
        public Circle_form()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int r = int.Parse(ci_r.Text);
                if (Init.figuresListBox.SelectedIndex == -1)
                {
                    MessageBox.Show("Вы не выбрали фигуру.");
                    return;
                }
                Figure figure = (Figure)Init.figuresListBox.SelectedItem;
                if (figure.ToString() != "FiguresLibrary.Circle")
                {
                    MessageBox.Show("Вы выбрали не окружность.");
                    return;
                }
                if (figure.CoordsCheck(figure.x, figure.y, r * 2, r * 2))
                {
                    figure.w = r * 2;
                    figure.h = r * 2;
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
