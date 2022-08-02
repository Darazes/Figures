using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figures
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //ChooseFigure
            ChooseFigure.Items.Add("Круг");
            ChooseFigure.Items.Add("Квадрат");
            ChooseFigure.Items.Add("Треугольник");
            ChooseFigure.Items.Add("Проверка точки в последней фигуре");
            ChooseFigure.SelectedIndex = 0;

            //ChooseFill
            ChooseFill.Items.Add("Без заливки");
            ChooseFill.Items.Add("Сплошной цвет");
            ChooseFill.SelectedIndex = 0;

            //ChooseColor
            ChooseColor.Items.Add("Черный");
            ChooseColor.Items.Add("Белый");
            ChooseColor.Items.Add("Красный");
            ChooseColor.Items.Add("Зелёный");
            ChooseColor.SelectedIndex = 0;

            //ChooseFillColor
            ChooseFillColor.Items.Add("Черный");
            ChooseFillColor.Items.Add("Белый");
            ChooseFillColor.Items.Add("Красный");
            ChooseFillColor.Items.Add("Зелёный");
            ChooseFillColor.SelectedIndex = 0;

        }

        Graphics graphics;
        Myobject myobject;
        Point click;
        Pen color;
        Brush brushcolor;

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            graphics = CreateGraphics();
            click = e.Location;

            switch (ChooseColor.SelectedIndex)
            {
                case 0:
                    color = new Pen(Color.Black, 5);
                    break;
                case 1:
                    color = new Pen(Color.White, 5);
                    break;
                case 2:
                    color = new Pen(Color.Red, 5);
                    break;
                case 3:
                    color = new Pen(Color.Green, 5);
                    break;
            }
            switch (ChooseFillColor.SelectedIndex)
            {
                case 0:
                    brushcolor = Brushes.Black;
                    break;
                case 1:
                    brushcolor = Brushes.White;
                    break;
                case 2:
                    brushcolor = Brushes.Red;
                    break;
                case 3:
                    brushcolor = Brushes.Green;
                    break;
            }
            if (ChooseFigure.SelectedIndex != 3)
            {
                myobject = new Myobject(color, brushcolor, click.X, click.Y, Convert.ToInt32(WidthValue.Text), Convert.ToInt32(HeightValue.Text), ChooseFigure.SelectedIndex);
                CreateFigure(graphics, myobject);
            }
            else switch (myobject.GetTypeObject())
                    {
                    case 0:
                        double radius = myobject.GetWidth() / 2;
                        double raschet = Math.Sqrt(Math.Pow(Convert.ToDouble(myobject.GetX()) - click.X, 2) + Math.Pow(Convert.ToDouble(myobject.GetY()) - Convert.ToDouble(click.Y), 2));
                        if (raschet < radius)
                            Info.Text = "Заданная точка лежит в фигуре Координаты точки = " + click.X + ", " + click.Y +
                                        '\n' + "Стартовые координаты объекта = " + myobject.GetX() + "," + myobject.GetY();
                        else
                            Info.Text = "Заданная точка не лежит в фигуре Координаты точки = " + click.X + ", " + click.Y +
                                        '\n' + "Стартовые координаты объекта = " + myobject.GetX() + "," + myobject.GetY();

                        if (myobject.GetWidth() == myobject.GetHeight())
                            Info.Text += " Радиус круга = " + radius;
                        else
                            Info.Text += ('\n' + " Формула под овал не писалась. Радиус не расчитывается.");
                        break;

                    case 1:
                        if (click.X < myobject.GetX() + myobject.GetWidth() / 2 && click.X > myobject.GetX() - myobject.GetWidth() / 2 &&
                            click.Y < myobject.GetY() + myobject.GetHeight() / 2 && click.Y > myobject.GetY() - myobject.GetHeight() / 2)

                            Info.Text = "Заданная точка лежит в фигуре Координаты точки = " + click.X + ", " + click.Y +
                                        '\n' + "Стартовые координаты объекта = " + myobject.GetX() + "," + myobject.GetY();
                        else
                            Info.Text = "Заданная точка не лежит в фигуре Координаты точки = " + click.X + ", " + click.Y +
                                        '\n' + "Стартовые координаты объекта = " + myobject.GetX() + "," + myobject.GetY();
                        break;

                    case 2:

                        int x0 = click.X;
                        int y0 = click.Y;
                        int x1 = myobject.GetX() - myobject.GetWidth() / 2;
                        int y1 = myobject.GetY() - myobject.GetHeight() / 2;
                        int x2 = myobject.GetX() - myobject.GetWidth() / 2;
                        int y2 = myobject.GetY() + myobject.GetHeight() / 2;
                        int x3 = myobject.GetX() + myobject.GetWidth() / 2;
                        int y3 = myobject.GetY() + myobject.GetHeight() / 2;

                        int a = (x1 - x0) * (y2 - y1) - (x2 - x1) * (y1 - y0);
                        int b = (x2 - x0) * (y3 - y2) - (x3 - x2) * (y2 - y0);
                        int c = (x3 - x0) * (y1 - y3) - (x1 - x3) * (y3 - y0);

                        if ((a >= 0 && b >= 0 && c >= 0) || (a <= 0 && b <= 0 && c <= 0))

                            Info.Text = "Заданная точка лежит в фигуре Координаты точки = " + click.X + ", " + click.Y +
                                        '\n' + "Стартовые координаты объекта = " + myobject.GetX() + "," + myobject.GetY();
                        else
                            Info.Text = "Заданная точка не лежит в фигуре Координаты точки = " + click.X + ", " + click.Y +
                                        '\n' + "Стартовые координаты объекта = " + myobject.GetX() + "," + myobject.GetY();

                        double Angle = Math.Atan(myobject.GetWidth() / myobject.GetHeight()) * (180.0 / Math.PI);
                        Info.Text += ('\n' + "Углы треугольника равны: " + Angle + " и " + (90 - Angle));
                        break;

                    }

        }

        public void CreateFigure(Graphics graphics, Myobject obj)
        {

            switch (obj.GetTypeObject())
            {

                case 0:
                    if (ChooseFill.SelectedIndex == 0)
                        graphics.DrawEllipse(obj.GetColor(), obj.GetX() - obj.GetWidth() / 2, obj.GetY() - obj.GetHeight() / 2, obj.GetWidth(), obj.GetHeight());
                    else
                        graphics.FillEllipse(obj.GetBrushColor(), obj.GetX() - obj.GetWidth() / 2, obj.GetY() - obj.GetHeight() / 2, obj.GetWidth(), obj.GetHeight());
                    graphics.DrawEllipse(obj.GetColor(), obj.GetX() - obj.GetWidth() / 2, obj.GetY() - obj.GetHeight() / 2, obj.GetWidth(), obj.GetHeight());
                    break;

                case 1:
                    if (ChooseFill.SelectedIndex == 0)
                        graphics.DrawRectangle(obj.GetColor(), obj.GetX() - obj.GetWidth() / 2, obj.GetY() - obj.GetHeight() / 2, obj.GetWidth(), obj.GetHeight());
                    else
                        graphics.FillRectangle(obj.GetBrushColor(), obj.GetX() - obj.GetWidth() / 2, obj.GetY() - obj.GetHeight() / 2, obj.GetWidth(), obj.GetHeight());
                    graphics.DrawRectangle(obj.GetColor(), obj.GetX() - obj.GetWidth() / 2, obj.GetY() - obj.GetHeight() / 2, obj.GetWidth(), obj.GetHeight());
                    break;

                case 2:
                    Point[] points = {
                        new Point(obj.GetX() - obj.GetWidth() / 2, obj.GetY() - obj.GetHeight() / 2),
                        new Point(obj.GetX() - obj.GetWidth() / 2, obj.GetY() + obj.GetHeight() / 2),
                        new Point(obj.GetX() + obj.GetWidth() / 2, obj.GetY() + obj.GetHeight() / 2)
                    };

                    if (ChooseFill.SelectedIndex == 0)
                        graphics.DrawPolygon(obj.GetColor(), points);
                    else
                        graphics.FillPolygon(obj.GetBrushColor(), points);
                    graphics.DrawPolygon(obj.GetColor(), points);
                    break;
            }
        }
    }
}

  


