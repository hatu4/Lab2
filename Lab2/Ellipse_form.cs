using System;
using System.Windows.Forms;
using FiguresLibrary;

namespace Lab2
{
    public partial class Ellipse_form : Form
    {
        public Ellipse_form()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int r1 = int.Parse(el_r1.Text);
                int r2 = int.Parse(el_r2.Text);
                if (Init.figuresListBox.SelectedIndex == -1)
                {
                    MessageBox.Show("Вы не выбрали фигуру.");
                    return;
                }
                Figure figure = (Figure)Init.figuresListBox.SelectedItem;
                if (figure.ToString() != "FiguresLibrary.Ellipse")
                {
                    MessageBox.Show("Вы выбрали не эллипс.");
                    return;
                }
                if (figure.CoordsCheck(figure.x, figure.y, r1 * 2, r2 * 2))
                {
                    figure.w = r1 * 2;
                    figure.h = r2 * 2;
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
