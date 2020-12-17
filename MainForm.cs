using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_6
{
    public partial class Form1 : Form
    {
        private ShapeAccumulator shapeAccumulator = new ShapeAccumulator();
        private Form2 form2;

        public Form1()
        {
            InitializeComponent();
            shapeAccumulator.Load();
            for (int i = 0; i < shapeAccumulator.figures.Count; i++)
                FiguresBox.Items.Add(shapeAccumulator.figures[i]);
            form2 = new Form2(this);
        }

        private void FiguresBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Graphics graphics = pictureBox1.CreateGraphics();
            Pen pen = new Pen(Color.Black);
            graphics.TranslateTransform(pictureBox1.Width / 2, pictureBox1.Height / 2);
            graphics.ScaleTransform(1, -1);
            graphics.Clear(BackColor);
            if (FiguresBox.SelectedIndex != -1)
            {
                if (shapeAccumulator.figures[FiguresBox.SelectedIndex].GetPoints().Length == 2)
                {
                    int radius = shapeAccumulator.figures[FiguresBox.SelectedIndex].GetPoints()[1].X - shapeAccumulator.figures[FiguresBox.SelectedIndex].GetPoints()[0].X;
                    Point buf = shapeAccumulator.figures[FiguresBox.SelectedIndex].GetPoints()[0];
                    graphics.DrawEllipse(pen, buf.X - buf.X / 2, buf.Y - buf.Y / 2, radius, radius);
                }
                else
                {
                    graphics.DrawLines(pen, shapeAccumulator.figures[FiguresBox.SelectedIndex].GetPoints());
                    graphics.DrawLine(pen, shapeAccumulator.figures[FiguresBox.SelectedIndex].GetPoints()[0], shapeAccumulator.figures[FiguresBox.SelectedIndex].GetPoints()[shapeAccumulator.figures[FiguresBox.SelectedIndex].GetPoints().Length - 1]);
                }
            }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            form2.Visible = true;
        }

        public void ShowBoxes()
        {
            switch (form2.usersButton)
            {
                case 1:
                    label1.Visible = true;
                    textBox1.Visible = true;
                    label2.Visible = true;
                    textBox2.Visible = true;
                    label3.Text = "R";
                    label3.Visible = true;
                    textBox3.Visible = true;
                    label4.Visible = false;
                    textBox4.Visible = false;
                    label5.Visible = false;
                    textBox5.Visible = false;
                    label6.Visible = false;
                    textBox6.Visible = false;
                    label7.Visible = false;
                    textBox7.Visible = false;
                    label8.Visible = false;
                    textBox8.Visible = false;
                    button1.Visible = true;
                    break;

                case 2:
                    label1.Visible = true;
                    textBox1.Visible = true;
                    label2.Visible = true;
                    textBox2.Visible = true;
                    label3.Text = "X2";
                    label3.Visible = true;
                    textBox3.Visible = true;
                    label4.Visible = true;
                    textBox4.Visible = true;
                    label5.Visible = true;
                    textBox5.Visible = true;
                    label6.Visible = true;
                    textBox6.Visible = true;
                    label7.Visible = true;
                    textBox7.Visible = true;
                    label8.Visible = true;
                    textBox8.Visible = true;
                    button1.Visible = true;
                    break;

                case 3:
                    label1.Visible = true;
                    textBox1.Visible = true;
                    label2.Visible = true;
                    textBox2.Visible = true;
                    label3.Text = "X2";
                    label3.Visible = true;
                    textBox3.Visible = true;
                    label4.Visible = true;
                    textBox4.Visible = true;
                    label5.Visible = true;
                    textBox5.Visible = true;
                    label6.Visible = true;
                    textBox6.Visible = true;
                    label7.Visible = true;
                    textBox7.Visible = true;
                    label8.Visible = true;
                    textBox8.Visible = true;
                    button1.Visible = true;
                    break;

                case 4:
                    label1.Visible = true;
                    textBox1.Visible = true;
                    label2.Visible = true;
                    textBox2.Visible = true;
                    label3.Text = "X2";
                    label3.Visible = true;
                    textBox3.Visible = true;
                    label4.Visible = true;
                    textBox4.Visible = true;
                    label5.Visible = true;
                    textBox5.Visible = true;
                    label6.Visible = true;
                    textBox6.Visible = true;
                    label7.Visible = false;
                    textBox7.Visible = false;
                    label8.Visible = false;
                    textBox8.Visible = false;
                    button1.Visible = true;
                    break;

                case 5:
                    label1.Visible = false;
                    textBox1.Visible = false;
                    label2.Visible = false;
                    textBox2.Visible = false;
                    label3.Visible = false;
                    textBox3.Visible = false;
                    label4.Visible = false;
                    textBox4.Visible = false;
                    label5.Visible = false;
                    textBox5.Visible = false;
                    label6.Visible = false;
                    textBox6.Visible = false;
                    label7.Visible = false;
                    textBox7.Visible = false;
                    label8.Visible = false;
                    textBox8.Visible = false;
                    button1.Visible = false;
                    break;

                default:
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Point[] points;
                switch (form2.usersButton)
                {
                    case 1:
                        points = new Point[2];
                        points[0].X = Convert.ToInt32(textBox1.Text);
                        points[0].Y = Convert.ToInt32(textBox2.Text);
                        points[1].X = Convert.ToInt32(textBox3.Text) + points[0].X;
                        points[1].Y = points[0].Y;
                        Circle circle = new Circle(points);
                        shapeAccumulator.Add(circle);
                        break;

                    case 2:
                        points = new Point[4];
                        points[0].X = Convert.ToInt32(textBox1.Text);
                        points[0].Y = Convert.ToInt32(textBox2.Text);
                        points[1].X = Convert.ToInt32(textBox3.Text);
                        points[1].Y = Convert.ToInt32(textBox4.Text);
                        points[2].X = Convert.ToInt32(textBox5.Text);
                        points[2].Y = Convert.ToInt32(textBox6.Text);
                        points[3].X = Convert.ToInt32(textBox7.Text);
                        points[3].Y = Convert.ToInt32(textBox8.Text);
                        Square square = new Square(points);
                        shapeAccumulator.Add(square);
                        break;

                    case 3:
                        points = new Point[4];
                        points[0].X = Convert.ToInt32(textBox1.Text);
                        points[0].Y = Convert.ToInt32(textBox2.Text);
                        points[1].X = Convert.ToInt32(textBox3.Text);
                        points[1].Y = Convert.ToInt32(textBox4.Text);
                        points[2].X = Convert.ToInt32(textBox5.Text);
                        points[2].Y = Convert.ToInt32(textBox6.Text);
                        points[3].X = Convert.ToInt32(textBox7.Text);
                        points[3].Y = Convert.ToInt32(textBox8.Text);
                        Rectangle rectangle = new Rectangle(points);
                        shapeAccumulator.Add(rectangle);
                        break;

                    case 4:
                        points = new Point[3];
                        points[0].X = Convert.ToInt32(textBox1.Text);
                        points[0].Y = Convert.ToInt32(textBox2.Text);
                        points[1].X = Convert.ToInt32(textBox3.Text);
                        points[1].Y = Convert.ToInt32(textBox4.Text);
                        points[2].X = Convert.ToInt32(textBox5.Text);
                        points[2].Y = Convert.ToInt32(textBox6.Text);
                        Triangle triangle = new Triangle(points);
                        shapeAccumulator.Add(triangle);
                        break;

                    default:
                        return;
                }
                FiguresBox.Items.Add(shapeAccumulator.figures[shapeAccumulator.figures.Count - 1]);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (FiguresBox.SelectedIndex != -1)
            {
                shapeAccumulator.figures.RemoveAt(FiguresBox.SelectedIndex);
                FiguresBox.Items.RemoveAt(FiguresBox.SelectedIndex);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (FiguresBox.SelectedIndex > 0)
            {
                shapeAccumulator.figures.Insert(FiguresBox.SelectedIndex - 1, shapeAccumulator.figures[FiguresBox.SelectedIndex]);
                shapeAccumulator.figures.RemoveAt(FiguresBox.SelectedIndex + 1);
                FiguresBox.Items.Clear();
                for (int i = 0; i < shapeAccumulator.figures.Count; i++)
                    FiguresBox.Items.Add(shapeAccumulator.figures[i]);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            shapeAccumulator.Delete_Save();
            shapeAccumulator.Save();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((FiguresBox.SelectedIndex != -1) && (FiguresBox.SelectedIndex < FiguresBox.Items.Count - 1))
            {
                shapeAccumulator.figures.Insert(FiguresBox.SelectedIndex, shapeAccumulator.figures[FiguresBox.SelectedIndex + 1]);
                shapeAccumulator.figures.RemoveAt(FiguresBox.SelectedIndex + 2);
                FiguresBox.Items.Clear();
                for (int i = 0; i < shapeAccumulator.figures.Count; i++)
                    FiguresBox.Items.Add(shapeAccumulator.figures[i]);
            }
        }
    }
}