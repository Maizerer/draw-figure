using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace draw_app
{
    public class Rectangle : Figure
    {
        public Rectangle(int x, int y, int w, int h, Color color, int penWidth)
        {
            this.x = x;
            this.y = y;
            this.w = w;
            this.h = h;
            this.color = color;
            this.penWidth = penWidth;
        }
        public Rectangle()
        {
            this.x = 0;
            this.y = 0;
            this.w = 0;
            this.h = 0;
        }
        public override void Draw(Pen pen)
        {
            try
            {
                Graphics g = Graphics.FromImage(Init.bitmap);
                g.DrawRectangle(pen, this.x, this.y, this.w, this.h);
                Init.pictureBox.Image = Init.bitmap;
            }
            catch { }

        }

        public override void MoveTo(int x, int y, int index)
        {
            if (!((this.x+x<0 && this.y+y<0)||(this.y+y<0)||(this.x+x>Init.pictureBox.Width && this.y+y<0)|| (this.x+this.w+x> Init.pictureBox.Width)|| (this.x+x> Init.pictureBox.Width && this.y+y>Init.pictureBox.Height)|| (this.y+this.h+y>Init.pictureBox.Height)||(this.x+x<0 && this.y+y> Init.pictureBox.Height)|| (this.x+x<0)))
            {
                Figure figure = ShapeContainer.figureList.Find(item => item.id == id);
                figure.x += x;
                figure.y += y;
                figure.DeleteF(figure, index, false);
                Pen pen = new Pen(this.color, this.penWidth);
            }
        }
    }
}
