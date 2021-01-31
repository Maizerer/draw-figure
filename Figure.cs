using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace draw_app
{
    abstract public class Figure
    {
        public int id;
        public int x;
        public int y;
        public int w;
        public int h;
        public Color color;
        public int penWidth;
        abstract public void Draw(Pen pen);
        abstract public void MoveTo(int x, int y, int index);
        public void DeleteF(Figure figure,int index ,bool flag = true)
        {
            if (flag == true)
            {
                Graphics g = Graphics.FromImage(Init.bitmap);
                ShapeContainer.figureList.Remove(ShapeContainer.figureList[index]);
                this.Clear();
                Init.pictureBox.Image = Init.bitmap;
                foreach (Figure f in ShapeContainer.figureList)
                {
                    Pen pen = new Pen(f.color, f.penWidth);
                    f.Draw(pen);
                }
            }
            else
            {
                Graphics g = Graphics.FromImage(Init.bitmap);
                Figure fig = ShapeContainer.figureList[figure.id];
                ShapeContainer.figureList.Remove(ShapeContainer.figureList[index]);
                this.Clear();
                Init.pictureBox.Image = Init.bitmap;
                foreach (Figure f in ShapeContainer.figureList)
                {
                    Pen pen = new Pen(f.color, f.penWidth);
                    f.Draw(pen);
                }
                ShapeContainer.figureList.Add(fig);
            }
        }
        public void Clear()
        {
            Graphics g = Graphics.FromImage(Init.bitmap);
            g.Clear(Color.White);
        }
    }
}
