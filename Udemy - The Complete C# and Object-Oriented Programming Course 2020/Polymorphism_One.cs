using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Complete_cSharp
{
    public class Polymorphism_One
    {
        List<Shape> shapes = new List<Shape>();
        public void DisplayShapes()
        {
            shapes.Add(new Shape());
            shapes.Add(new Circle());
            shapes.Add(new Line());
            shapes.Add(new Triangle());

            //foreach (var shape in shapes)
              foreach (Shape shape in shapes)
              {
                shape.Draw(); 
              }
        }
    }

    public class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("This is a simple shape"); 
        }
    }
    public class Circle: Shape
    {
        public override void Draw()
        {
            Console.WriteLine("This is a simple circle");
        }
    }
    public class Line : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("This is a simple line");
        }
    }
    public class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("This is a simple circle");
        }
    }
}
