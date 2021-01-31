using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace draw_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label15.Text = "";
            Bitmap bitmap = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height);
            Pen pen = new Pen(Color.Black, 5);
            Init.bitmap = bitmap;
            Init.pictureBox = pictureBox1;
            Init.pen = pen;
            ShapeContainer container = new ShapeContainer();
            //textBox17.Text = "5";
        }
        public void Clear()
        {
            Graphics g = Graphics.FromImage(Init.bitmap);
            g.Clear(Color.White);
        }
        public void saveFigure(Figure figure)
        {
            ShapeContainer.AddFigure(figure);
            listView1.Items.Clear();
            ushort counter = 0;
            foreach ( Figure fig in ShapeContainer.figureList)
            {
                var row = new string[] { (counter+1).ToString(), fig.GetType().Name.ToString(), fig.w.ToString(), fig.h.ToString() };
                var lvi = new ListViewItem(row);
                figure.id = counter;
                lvi.Tag = figure;
                listView1.Items.Add(lvi);
                counter++;
            }
        }
        public void drawContainer()
        {
            foreach (Figure figure in ShapeContainer.figureList)
            {
                Pen pen = new Pen(figure.color, figure.penWidth);
                figure.Draw(pen);
            }
        }

        public void drawViewList() { 
        }
        public Figure drawRectangle()
        {
            Clear();
            drawContainer();
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);
            int w = int.Parse(textBox4.Text);
            int h = int.Parse(textBox3.Text);
            int penWidth = 5;
            Int32.TryParse(textBox17.Text, out penWidth);
            Rectangle rectangle = new Rectangle(x, y, w, h, pictureBox2.BackColor, penWidth);
            rectangle.Draw(Init.pen);
            return rectangle;
        }
        public Figure drawSquare()
        {
            Clear();
            drawContainer();
            int x = int.Parse(textBox8.Text);
            int y = int.Parse(textBox7.Text);
            int w = int.Parse(textBox6.Text);
            int penWidth = 5;
            Int32.TryParse(textBox18.Text, out penWidth);
            Square square = new Square(x, y, w, pictureBox3.BackColor, penWidth);
            square.Draw(Init.pen);
            return square;
        }
        public Figure drawCircle()
        {
            Clear();
            drawContainer();
            int x = int.Parse(textBox10.Text);
            int y = int.Parse(textBox9.Text);
            int w = int.Parse(textBox5.Text);
            int penWidth = 5;
            Int32.TryParse(textBox19.Text, out penWidth);
            Circle circle = new Circle(x, y, w, pictureBox4.BackColor, penWidth);
            circle.Draw(Init.pen);
            return circle;
        }
        public Figure drawEllipse()
        {
            Clear();
            drawContainer();
            int x = int.Parse(textBox14.Text);
            int y = int.Parse(textBox13.Text);
            int w = int.Parse(textBox12.Text);
            int h = int.Parse(textBox11.Text);
            int penWidth = 5;
            Int32.TryParse(textBox20.Text, out penWidth);
            Ellipse ellipse = new Ellipse(x, y, w, h, pictureBox5.BackColor, penWidth);
            ellipse.Draw(Init.pen);
            return ellipse;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                drawRectangle();
            }
            catch
            {
                label15.Text = "Для рисования нужно заполнить все поля";
            }
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                drawRectangle();
            }
            catch
            {
                label15.Text = "Для рисования нужно заполнить все поля";
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                drawRectangle();
            }
            catch
            {
                label15.Text = "Для рисования нужно заполнить все поля";
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                drawRectangle();
            }
            catch
            {
                label15.Text = "Для рисования нужно заполнить все поля";
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            try
            {
                drawSquare();
            }
            catch
            {
                label15.Text = "Для рисования нужно заполнить все поля";
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            try
            {
                drawSquare();
            }
            catch
            {
                label15.Text = "Для рисования нужно заполнить все поля";
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            try
            {
                drawSquare();
            }
            catch
            {
                label15.Text = "Для рисования нужно заполнить все поля";
            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            try
            {
                drawCircle();
            }
            catch
            {
                label15.Text = "Для рисования нужно заполнить все поля";
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            try
            {
                drawCircle();
            }
            catch
            {
                label15.Text = "Для рисования нужно заполнить все поля";
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                drawCircle();
            }
            catch
            {
                label15.Text = "Для рисования нужно заполнить все поля";
            }
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            try
            {
                drawEllipse();
            }
            catch
            {
                label15.Text = "Для рисования нужно заполнить все поля";
            }
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            try
            {
                drawEllipse();
            }
            catch
            {
                label15.Text = "Для рисования нужно заполнить все поля";
            }
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            try
            {
                drawEllipse();
            }
            catch
            {
                label15.Text = "Для рисования нужно заполнить все поля";
            }
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            try
            {
                drawEllipse();
            }
            catch
            {
                label15.Text = "Для рисования нужно заполнить все поля";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                saveFigure(drawRectangle());
            }
            catch { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                saveFigure(drawSquare());
            }
            catch { }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                saveFigure(drawCircle());
            }
            catch { }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                saveFigure(drawEllipse());
            }
            catch { }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var figure = (Figure)listView1.SelectedItems[0].Tag;
            }
         
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                Figure figure = ShapeContainer.figureList[listView1.SelectedIndices[0]];
                figure.DeleteF(figure, listView1.SelectedIndices[0]);
                ushort counter = 0;
                listView1.Items.Clear();
                foreach (Figure fig in ShapeContainer.figureList)
                {
                    
                    var row = new string[] { (counter+1).ToString(), fig.GetType().Name.ToString(), fig.w.ToString(), fig.h.ToString() };
                    var lvi = new ListViewItem(row);
                    figure.id = counter;
                    lvi.Tag = figure;
                    listView1.Items.Add(lvi);
                    counter++;
                }
            }
            catch
            {

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {   
            try
            {
                int x = int.Parse(textBox16.Text);
                int y = int.Parse(textBox15.Text);
                int id = listView1.SelectedIndices[0];
                //Figure figure = ShapeContainer.figureList[listView1.SelectedIndices[0]];
                Figure fig = ShapeContainer.figureList.Find(item => item.id == id );
                fig.MoveTo(x, y, id);
                drawContainer();
            }
            catch
            {
                
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.BackColor = colorDialog1.Color;
                Color color = pictureBox2.BackColor;
                try{
                    float penWidth = float.Parse(textBox17.Text);
                     Pen pen = new Pen(color, penWidth);
                     Init.pen = pen;
                }catch{}

                drawRectangle();
            }
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            pictureBox2.BackColor = colorDialog1.Color;
            Color color = pictureBox2.BackColor;
            try
            {
                float penWidth = float.Parse(textBox17.Text);
                Pen pen = new Pen(color, penWidth);
                Init.pen = pen;
                drawRectangle();
            }
            catch { }
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox3.BackColor = colorDialog1.Color;
                Color color = pictureBox3.BackColor;
                try
                {
                    float penWidth = float.Parse(textBox18.Text);
                    Pen pen = new Pen(color, penWidth);
                    Init.pen = pen;
                }
                catch { }
                drawSquare();
            }
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {
            pictureBox3.BackColor = colorDialog1.Color;
            Color color = pictureBox3.BackColor;
            try
            {
                float penWidth = float.Parse(textBox18.Text);
                Pen pen = new Pen(color, penWidth);
                Init.pen = pen;
                drawSquare();
            }
            catch { }
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox4.BackColor = colorDialog1.Color;
                Color color = pictureBox4.BackColor;
                try{
                    float penWidth = float.Parse(textBox19.Text);
                     Pen pen = new Pen(color, penWidth);
                     Init.pen = pen;
                }catch{}
                drawCircle();
            }
        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {
            pictureBox4.BackColor = colorDialog1.Color;
            Color color = pictureBox4.BackColor;
            try
            {
                float penWidth = float.Parse(textBox19.Text);
                Pen pen = new Pen(color, penWidth);
                Init.pen = pen;
                drawCircle();
            }
            catch { }
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox5.BackColor = colorDialog1.Color;
                Color color = pictureBox5.BackColor;
                try
                {
                    float penWidth = float.Parse(textBox20.Text);
                    Pen pen = new Pen(color, penWidth);
                    Init.pen = pen;
                }
                catch { }
                drawEllipse();
            }
        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {
            pictureBox5.BackColor = colorDialog1.Color;
            Color color = pictureBox5.BackColor;
            try
            {
                float penWidth = float.Parse(textBox20.Text);
                Pen pen = new Pen(color, penWidth);
                Init.pen = pen;
                drawEllipse();
            }
            catch { }
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            string allowedchar = "0123456789-";
            if (allowedchar.IndexOf(e.KeyChar, 0, allowedchar.Length) != -1 || e.KeyChar == ((char)Keys.Back)) return;
            else
                e.Handled = true;
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            string allowedchar = "0123456789-";
            if (allowedchar.IndexOf(e.KeyChar, 0, allowedchar.Length) != -1 || e.KeyChar == ((char)Keys.Back)) return;
            else
                e.Handled = true;
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            string allowedchar = "0123456789-";
            if (allowedchar.IndexOf(e.KeyChar, 0, allowedchar.Length) != -1 || e.KeyChar == ((char)Keys.Back)) return;
            else
                e.Handled = true;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            string allowedchar = "0123456789-";
            if (allowedchar.IndexOf(e.KeyChar, 0, allowedchar.Length) != -1 || e.KeyChar == ((char)Keys.Back)) return;
            else
                e.Handled = true;
        }

        private void textBox17_KeyPress(object sender, KeyPressEventArgs e)
        {
            string allowedchar = "0123456789";
            if (allowedchar.IndexOf(e.KeyChar, 0, allowedchar.Length) != -1 || e.KeyChar == ((char)Keys.Back)) return;
            else
                e.Handled = true;
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            string allowedchar = "0123456789-";
            if (allowedchar.IndexOf(e.KeyChar, 0, allowedchar.Length) != -1 || e.KeyChar == ((char)Keys.Back)) return;
            else
                e.Handled = true;
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            string allowedchar = "0123456789-";
            if (allowedchar.IndexOf(e.KeyChar, 0, allowedchar.Length) != -1 || e.KeyChar == ((char)Keys.Back)) return;
            else
                e.Handled = true;
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            string allowedchar = "0123456789-";
            if (allowedchar.IndexOf(e.KeyChar, 0, allowedchar.Length) != -1 || e.KeyChar == ((char)Keys.Back)) return;
            else
                e.Handled = true;
        }

        private void textBox18_KeyPress(object sender, KeyPressEventArgs e)
        {
            string allowedchar = "0123456789";
            if (allowedchar.IndexOf(e.KeyChar, 0, allowedchar.Length) != -1 || e.KeyChar == ((char)Keys.Back)) return;
            else
                e.Handled = true;
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            string allowedchar = "0123456789-";
            if (allowedchar.IndexOf(e.KeyChar, 0, allowedchar.Length) != -1 || e.KeyChar == ((char)Keys.Back)) return;
            else
                e.Handled = true;
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            string allowedchar = "0123456789-";
            if (allowedchar.IndexOf(e.KeyChar, 0, allowedchar.Length) != -1 || e.KeyChar == ((char)Keys.Back)) return;
            else
                e.Handled = true;
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            string allowedchar = "0123456789-";
            if (allowedchar.IndexOf(e.KeyChar, 0, allowedchar.Length) != -1 || e.KeyChar == ((char)Keys.Back)) return;
            else
                e.Handled = true;
        }

        private void textBox19_KeyPress(object sender, KeyPressEventArgs e)
        {
            string allowedchar = "0123456789";
            if (allowedchar.IndexOf(e.KeyChar, 0, allowedchar.Length) != -1 || e.KeyChar == ((char)Keys.Back)) return;
            else
                e.Handled = true;
        }

        private void textBox14_KeyPress(object sender, KeyPressEventArgs e)
        {
            string allowedchar = "0123456789-";
            if (allowedchar.IndexOf(e.KeyChar, 0, allowedchar.Length) != -1 || e.KeyChar == ((char)Keys.Back)) return;
            else
                e.Handled = true;
        }

        private void textBox13_KeyPress(object sender, KeyPressEventArgs e)
        {
            string allowedchar = "0123456789-";
            if (allowedchar.IndexOf(e.KeyChar, 0, allowedchar.Length) != -1 || e.KeyChar == ((char)Keys.Back)) return;
            else
                e.Handled = true;
        }

        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            string allowedchar = "0123456789-";
            if (allowedchar.IndexOf(e.KeyChar, 0, allowedchar.Length) != -1 || e.KeyChar == ((char)Keys.Back)) return;
            else
                e.Handled = true;
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            string allowedchar = "0123456789-";
            if (allowedchar.IndexOf(e.KeyChar, 0, allowedchar.Length) != -1 || e.KeyChar == ((char)Keys.Back)) return;
            else
                e.Handled = true;
        }

        private void textBox20_KeyPress(object sender, KeyPressEventArgs e)
        {
            string allowedchar = "0123456789";
            if (allowedchar.IndexOf(e.KeyChar, 0, allowedchar.Length) != -1 || e.KeyChar == ((char)Keys.Back)) return;
            else
                e.Handled = true;
        }

        private void textBox16_KeyPress(object sender, KeyPressEventArgs e)
        {
            string allowedchar = "0123456789-";
            if (allowedchar.IndexOf(e.KeyChar, 0, allowedchar.Length) != -1 || e.KeyChar == ((char)Keys.Back)) return;
            else
                e.Handled = true;
        }

        private void textBox15_KeyPress(object sender, KeyPressEventArgs e)
        {
            string allowedchar = "0123456789-";
            if (allowedchar.IndexOf(e.KeyChar, 0, allowedchar.Length) != -1 || e.KeyChar == ((char)Keys.Back)) return;
            else
                e.Handled = true;
        }



       
    }
}
