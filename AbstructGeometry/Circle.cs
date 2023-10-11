using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


namespace AbstructGeometry
{
    class Circle : Shape
    {
        public static readonly double PI = 3.14159265359;
        double radius;
        public double Radius
        {
            get { return radius; }
            set
            {
                if (value < MIN_SIZE) value = MIN_SIZE;
                if (value > MAX_SIZE) value = MAX_SIZE;
                radius = value;
            }
        }
      
        public Circle(double radius, int start_x, int start_y, int line_width, Color color)
            : base(start_x, start_y, line_width, color)
        {
            Radius = radius;
        }
        public override double GetArea()
        {
            return PI*Math.Pow(Radius,2);
        }
        public override double GetPerimiter()
        {
            return 2*PI*Radius;
        }
        public override void Draw(PaintEventArgs e)
        {
            Pen pen = new Pen(Color, LineWidth);
            e.Graphics.DrawEllipse(pen, StartX, StartY, StartX + (int)(2 * Radius), StartY + (int)(2 * Radius));
        }
        public override void Info(PaintEventArgs e)
        {
            Console.WriteLine($"Радиус окружности: {Radius}");
            Console.WriteLine($"Длинна окружности: {GetPerimiter()}");
        }
    }
}
