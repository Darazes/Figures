using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figures
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
       {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
    public class Myobject
    {
        Pen color = Pens.Black;
        Brush brushcolor = Brushes.Black;
        int x;
        int y;
        int width;
        int height;
        int type;
        public Myobject(Pen color, Brush brushcolor, int x, int y, int width, int height, int type)
        {
            this.color = color;
            this.brushcolor = brushcolor;
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.type = type;
        }
        public Pen GetColor()
        {
            return color;
        }
        public Brush GetBrushColor()
        {
            return brushcolor;
        }
        public int GetX()
        {
            return x;
        }
        public int GetY()
        {
            return y;
        }
        public int GetWidth()
        {
            return width;
        }
        public int GetHeight()
        {
            return height;
        }
        public int GetTypeObject()
        {
            return type;
        }
    }
}

