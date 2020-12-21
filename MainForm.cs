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
            Load(shapeAccumulator);
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
                    labelX1.Visible = true;
                    textBoxX1.Visible = true;
                    labelY1.Visible = true;
                    textBoxY1.Visible = true;
                    labelX2.Text = "R";
                    labelX2.Visible = true;
                    textBoxX2.Visible = true;
                    labelY2.Visible = false;
                    textBoxY2.Visible = false;
                    labelX3.Visible = false;
                    textBoxX3.Visible = false;
                    labelY3.Visible = false;
                    textBoxY3.Visible = false;
                    labelX4.Visible = false;
                    textBoxX4.Visible = false;
                    labelY4.Visible = false;
                    textBoxY4.Visible = false;
                    buttonSubmit.Visible = true;
                    break;

                case 2:
                    labelX1.Visible = true;
                    textBoxX1.Visible = true;
                    labelY1.Visible = true;
                    textBoxY1.Visible = true;
                    labelX2.Text = "X2";
                    labelX2.Visible = true;
                    textBoxX2.Visible = true;
                    labelY2.Visible = true;
                    textBoxY2.Visible = true;
                    labelX3.Visible = true;
                    textBoxX3.Visible = true;
                    labelY3.Visible = true;
                    textBoxY3.Visible = true;
                    labelX4.Visible = true;
                    textBoxX4.Visible = true;
                    labelY4.Visible = true;
                    textBoxY4.Visible = true;
                    buttonSubmit.Visible = true;
                    break;

                case 3:
                    labelX1.Visible = true;
                    textBoxX1.Visible = true;
                    labelY1.Visible = true;
                    textBoxY1.Visible = true;
                    labelX2.Text = "X2";
                    labelX2.Visible = true;
                    textBoxX2.Visible = true;
                    labelY2.Visible = true;
                    textBoxY2.Visible = true;
                    labelX3.Visible = true;
                    textBoxX3.Visible = true;
                    labelY3.Visible = true;
                    textBoxY3.Visible = true;
                    labelX4.Visible = true;
                    textBoxX4.Visible = true;
                    labelY4.Visible = true;
                    textBoxY4.Visible = true;
                    buttonSubmit.Visible = true;
                    break;

                case 4:
                    labelX1.Visible = true;
                    textBoxX1.Visible = true;
                    labelY1.Visible = true;
                    textBoxY1.Visible = true;
                    labelX2.Text = "X2";
                    labelX2.Visible = true;
                    textBoxX2.Visible = true;
                    labelY2.Visible = true;
                    textBoxY2.Visible = true;
                    labelX3.Visible = true;
                    textBoxX3.Visible = true;
                    labelY3.Visible = true;
                    textBoxY3.Visible = true;
                    labelX4.Visible = false;
                    textBoxX4.Visible = false;
                    labelY4.Visible = false;
                    textBoxY4.Visible = false;
                    buttonSubmit.Visible = true;
                    break;

                case 5:
                    labelX1.Visible = false;
                    textBoxX1.Visible = false;
                    labelY1.Visible = false;
                    textBoxY1.Visible = false;
                    labelX2.Visible = false;
                    textBoxX2.Visible = false;
                    labelY2.Visible = false;
                    textBoxY2.Visible = false;
                    labelX3.Visible = false;
                    textBoxX3.Visible = false;
                    labelY3.Visible = false;
                    textBoxY3.Visible = false;
                    labelX4.Visible = false;
                    textBoxX4.Visible = false;
                    labelY4.Visible = false;
                    textBoxY4.Visible = false;
                    buttonSubmit.Visible = false;
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
                        points[0].X = Convert.ToInt32(textBoxX1.Text);
                        points[0].Y = Convert.ToInt32(textBoxY1.Text);
                        points[1].X = Convert.ToInt32(textBoxX2.Text) + points[0].X;
                        points[1].Y = points[0].Y;
                        Circle circle = new Circle(points);
                        shapeAccumulator.Add(circle);
                        break;

                    case 2:
                        points = new Point[4];
                        points[0].X = Convert.ToInt32(textBoxX1.Text);
                        points[0].Y = Convert.ToInt32(textBoxY1.Text);
                        points[1].X = Convert.ToInt32(textBoxX2.Text);
                        points[1].Y = Convert.ToInt32(textBoxY2.Text);
                        points[2].X = Convert.ToInt32(textBoxX3.Text);
                        points[2].Y = Convert.ToInt32(textBoxY3.Text);
                        points[3].X = Convert.ToInt32(textBoxX4.Text);
                        points[3].Y = Convert.ToInt32(textBoxY4.Text);
                        Square square = new Square(points);
                        shapeAccumulator.Add(square);
                        break;

                    case 3:
                        points = new Point[4];
                        points[0].X = Convert.ToInt32(textBoxX1.Text);
                        points[0].Y = Convert.ToInt32(textBoxY1.Text);
                        points[1].X = Convert.ToInt32(textBoxX2.Text);
                        points[1].Y = Convert.ToInt32(textBoxY2.Text);
                        points[2].X = Convert.ToInt32(textBoxX3.Text);
                        points[2].Y = Convert.ToInt32(textBoxY3.Text);
                        points[3].X = Convert.ToInt32(textBoxX4.Text);
                        points[3].Y = Convert.ToInt32(textBoxY4.Text);
                        Rectangle rectangle = new Rectangle(points);
                        shapeAccumulator.Add(rectangle);
                        break;

                    case 4:
                        points = new Point[3];
                        points[0].X = Convert.ToInt32(textBoxX1.Text);
                        points[0].Y = Convert.ToInt32(textBoxY1.Text);
                        points[1].X = Convert.ToInt32(textBoxX2.Text);
                        points[1].Y = Convert.ToInt32(textBoxY2.Text);
                        points[2].X = Convert.ToInt32(textBoxX3.Text);
                        points[2].Y = Convert.ToInt32(textBoxY3.Text);
                        Triangle triangle = new Triangle(points);
                        shapeAccumulator.Add(triangle);
                        break;

                    default:
                        return;
                }
                FiguresBox.Items.Add(shapeAccumulator.figures[shapeAccumulator.figures.Count - 1]);
                textBoxX1.Text = "";
                textBoxY1.Text = "";
                textBoxX2.Text = "";
                textBoxY2.Text = "";
                textBoxX3.Text = "";
                textBoxY3.Text = "";
                textBoxX4.Text = "";
                textBoxY4.Text = "";
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
                Graphics graphics = pictureBox1.CreateGraphics();
                graphics.Clear(BackColor);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Delete_Save(shapeAccumulator);
            Save(shapeAccumulator);
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
                Graphics graphics = pictureBox1.CreateGraphics();
                graphics.Clear(BackColor);
            }
        }
    }
}