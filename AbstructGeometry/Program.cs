//#define RECTANGLE
//#define TRIANGLE
#define CIRCLE
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstructGeometry
{
    class Program
    {
        static void Main(string[] args)
        {
            IntPtr hwnd = GetConsoleWindow();
            System.Drawing.Graphics graphics = Graphics.FromHwnd(hwnd);
            System.Drawing.Rectangle window_rect = new System.Drawing.Rectangle
               (
                   Console.WindowLeft, Console.WindowTop,
                   Console.WindowWidth, Console.WindowHeight
               );
            PaintEventArgs e = new PaintEventArgs(graphics, window_rect);
            int start_x,start_y;
#if RECTANGLE
            Console.WriteLine("Введите размеры прямоугольника:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            start_x = 150;
            start_y = 150 + b;
            Rectangle rect = new Rectangle(a, b, start_x, start_y, 5, Color.SkyBlue);
            rect.Info(e);
#endif
#if TRIANGLE
            Console.WriteLine("Введите размеры треугольника (длина 1-й стороны, длина 2-й стороны, угол между сторонами в градусах):");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int ang = Convert.ToInt32(Console.ReadLine());
            start_x = 150; 
            start_y = 150 + (int)(b * Math.Sin(ang * 0.0174533));
            Triangle triangle = new Triangle(a, b, ang, start_x, start_y, 5, Color.SkyBlue);
            triangle.Draw(e);
            triangle.Info(e);
#endif
#if CIRCLE
            Console.WriteLine("Введите радиус окружности:");
            int r = Convert.ToInt32(Console.ReadLine());
            start_x = 150;
            start_y = 150;
            Circle circle = new Circle(r, start_x, start_y, 5, Color.SkyBlue);
            circle.Draw(e);
            circle.Info(e);

#endif

        }
        [DllImport("kernel32.dll")]
        public static extern IntPtr GetConsoleWindow();
        [DllImport("kernel32.dll")]
        public static extern IntPtr GetDC(IntPtr hwnd);
    }
}
