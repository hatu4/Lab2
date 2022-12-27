namespace FiguresLibrary
{
    public abstract class Figure
    {
        public int id, x, y, w, h;
        public string name;

        public Figure(int id, int x, int y)
        {
            this.id = id;
            this.x = x;
            this.y = y;
        }
        public void DeleteF(Figure figure, bool flag = true)
        {
            ShapeContainer.figureList.Remove(figure);
            Init.Clear();
            Init.pictureBox.Image = Init.bitmap;
            foreach (Figure f in ShapeContainer.figureList)
            {
                f.Draw();
            }
            if (flag == false)
            {
                ShapeContainer.figureList.Add(figure);
            }
        }
        public void MoveTo(int x, int y)
        {
            this.x += x;
            this.y += y;
            this.DeleteF(this, false);
            this.Draw();
        }
        public bool CoordsCheck(int x, int y, int w, int h)
        {
            if (!((x < 0) || (y < 0) || (x + w > Init.pictureBox.Width) || (y + h > Init.pictureBox.Height)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        abstract public void Draw();
        public string Info
            { get { return name + " " + id.ToString(); } }
    }
}
