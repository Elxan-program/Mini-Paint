using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_7_WPF_part_2
{
    public partial class Form1 : Form
    {
        IFactory FigureFactory { get; set; }
        public Form1()
        {
            InitializeComponent();
            List<string> figures = new List<string>
            {
                "Rectangle",
                "Triangle",
                "Circle"
            };
            FiguresComboBox.Items.AddRange(figures.ToArray());
            FiguresComboBox.SelectedIndex = 1;

        }

        interface IFigure
        {
            Point Point { get; set; }
            Size Size { get; set; }
            Color Colour { get; set; }
            bool IsFilled { get; set; }
        }

        class Rectangle : IFigure
        {
            public Point Point { get; set; }
            public Size Size { get; set; }
            public Color Colour { get; set; }
            public bool IsFilled { get; set; }

        }

        class Triangle : IFigure
        {
            public Point Point { get; set; }
            public Size Size { get; set; }
            public Color Colour { get; set; }
            public bool IsFilled { get; set; }

        }

        class Circle : IFigure
        {
            public Point Point { get; set; }
            public Size Size { get; set; }
            public Color Colour { get; set; }
            public bool IsFilled { get; set; }

        }

        interface IFactory
        {
            IFigure GetFigure();
        }

        class CircleFactory : IFactory
        {
            public IFigure GetFigure()
            {
                return new Circle();
            }
        }

        class TriangleFactory : IFactory
        {
            public IFigure GetFigure()
            {
                return new Triangle();
            }
        }

        class RectangleFactory : IFactory
        {
            public IFigure GetFigure()
            {
                return new Rectangle();
            }
        }

        List<IFigure> Figures = new List<IFigure>();
        private void FiguresComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = FiguresComboBox.SelectedItem.ToString();
            if (item == "Triangle")
            {
                FigureFactory = new TriangleFactory();
            }
            else if (item == "Rectangle")
            {
                FigureFactory = new RectangleFactory();
            }
            else if (item == "Circle")
            {
                FigureFactory = new CircleFactory();
            }
        }
        public Color FigureColor { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            var result = colorDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                FigureColor = colorDialog.Color;
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (FigureFactory.GetFigure() is Rectangle rect)
            {
                if (Fill_Btn.Checked)
                {
                    rect.Colour = FigureColor;
                    rect.Point = e.Location;
                    rect.Size = new Size(int.Parse(Width.Text), int.Parse(Height.Text));
                    rect.IsFilled = true;
                    Figures.Add(rect);
                }
                else
                {
                    rect.Colour = FigureColor;
                    rect.Point = e.Location;
                    rect.Size = new Size(int.Parse(Width.Text), int.Parse(Height.Text));
                    rect.IsFilled = false;
                    Figures.Add(rect);
                }
                
            }
            else if (FigureFactory.GetFigure() is Circle circ)
            {
                if (Fill_Btn.Checked)
                {
                    circ.Colour = FigureColor;
                    circ.Point = e.Location;
                    circ.Size = new Size(int.Parse(Width.Text), int.Parse(Height.Text));
                    circ.IsFilled = true;
                    Figures.Add(circ);
                }
                else
                {
                    circ.Colour = FigureColor;
                    circ.Point = e.Location;
                    circ.Size = new Size(int.Parse(Width.Text), int.Parse(Height.Text));
                    circ.IsFilled = false;
                    Figures.Add(circ);
                }
            }
            else if (FigureFactory.GetFigure() is Triangle tria)
            {
                if (Fill_Btn.Checked)
                {
                    tria.Colour = FigureColor;
                    tria.Point = e.Location;
                    tria.Size = new Size(int.Parse(Width.Text),int.Parse(Height.Text));
                    tria.IsFilled = true;
                    Figures.Add(tria);
                }
                else
                {
                    tria.Colour = FigureColor;
                    tria.Point = e.Location;
                    tria.Size = new Size(int.Parse(Width.Text), int.Parse(Height.Text));
                    tria.IsFilled = false;
                    Figures.Add(tria);
                }
            }
            this.Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(FigureColor,3);
            SolidBrush brush = new SolidBrush(FigureColor);

            using (var a = e.Graphics)
            {
                foreach (var item in Figures)
                {
                    if (item is Rectangle rect)
                    {
                        if (rect.IsFilled)
                        {
                            a.FillRectangle(brush,rect.Point.X,rect.Point.Y,rect.Size.Width,rect.Size.Height);
                        }
                        else
                        {
                            a.DrawRectangle(pen,rect.Point.X, rect.Point.Y, rect.Size.Width, rect.Size.Height);
                        }
                    }
                    else if (item is  Circle circ)
                    {
                        if (circ.IsFilled)
                        {
                            a.FillEllipse(brush, circ.Point.X, circ.Point.Y, circ.Size.Width, circ.Size.Height);
                        }
                        else
                        {
                            a.DrawEllipse(pen, circ.Point.X, circ.Point.Y, circ.Size.Width, circ.Size.Height);
                        }
                    }
                    else if (item is Triangle tria)
                    {
                        if (!tria.IsFilled)
                        {
                            Point top = new Point(tria.Point.X + tria.Size.Width / 2, tria.Point.Y);
                            Point right = new Point(tria.Point.X + tria.Size.Width, tria.Point.Y + tria.Size.Height);
                            Point left = new Point(tria.Point.X, tria.Point.Y + tria.Size.Height);
                            Point[] curvePoints = { top, right, left };

                            e.Graphics.DrawPolygon(pen, curvePoints);
                        }
                        else
                        {
                            Point top = new Point(tria.Point.X + tria.Size.Width / 2, tria.Point.Y);
                            Point right = new Point(tria.Point.X + tria.Size.Width, tria.Point.Y + tria.Size.Height);
                            Point left = new Point(tria.Point.X, tria.Point.Y + tria.Size.Height);
                            Point[] trianglesPoints = { top, right, left };

                            e.Graphics.FillPolygon(brush,trianglesPoints);
                        }
                    }
                }
            }
        }
    }
}
//UwU