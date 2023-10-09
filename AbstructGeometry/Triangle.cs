using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


namespace AbstructGeometry
{
    class Triangle : Shape
    {
        double side_a;
        double side_b;
        double angle;
        public double SideA
        {
            get { return side_a; }
            set
            {
                if (value < MIN_SIZE) value = MIN_SIZE;
                if (value > MAX_SIZE) value = MAX_SIZE;
                side_a = value;
            }
        }
        public double SideB
        {
            get { return side_b; }
            set
            {
                if (value < MIN_SIZE) value = MIN_SIZE;
                if (value > MAX_SIZE) value = MAX_SIZE;
                side_b = value;
            }
        }
        public double Angle
        {
            get { return angle; }
            set
            {
                if (value < MIN_ANGLE) value = MIN_ANGLE;
                if (value > MAX_ANGLE) value = MAX_ANGLE;
                angle = value;
            }
        }
        public Triangle(double side_a, double side_b, double angle, int start_x, int start_y, int line_width, Color color)
            : base(start_x, start_y, line_width, color)
        {
            SideA = side_a;
            SideB = side_b;
            Angle = angle;
        }
        public double GetС()
        {
            double angle_grad = Angle * 0.0174533;
            return Math.Sqrt(Math.Pow(SideA, 2) + Math.Pow(SideB, 2)-2*SideA*SideB*Math.Cos(angle_grad));
        }
        public override double GetArea()
        {
            double angle_grad = Angle * 0.0174533;
            return (SideA * SideB * Math.Sin(angle_grad))/2;
        }
        public override double GetPerimiter()
        {
            double angle_grad = Angle* 0.0174533;
            return (SideA + SideB + Math.Sqrt(Math.Pow(SideA, 2) + Math.Pow(SideB, 2) - 2 * SideA * SideB * Math.Cos(angle_grad)));
        }
        public override void Draw(PaintEventArgs e)
        {
            Pen pen = new Pen(Color, LineWidth);
            double angle_grad = Angle * 0.0174533;
            e.Graphics.DrawLine(pen, StartX, StartY, StartX + (int)SideA, StartY);
            e.Graphics.DrawLine(pen, StartX, StartY, StartX+(int)(SideB*Math.Cos(angle_grad)), StartY +(int)(SideB*Math.Sin(angle_grad)));
            e.Graphics.DrawLine(pen, StartX + (int)(SideB * Math.Cos(angle_grad)), StartY + (int)(SideB * Math.Sin(angle_grad)), StartX + (int)SideA, StartY);
        }
        public override void Info(PaintEventArgs e)
        {
            Console.WriteLine($"Сторона A: {SideA}");
            Console.WriteLine($"Сторона B: {SideB}");
            Console.WriteLine($"Сторона С: {this.GetС()}");
            base.Info(e);
        }
    }
}
