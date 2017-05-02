using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
	class Program
	{
		static void Main(string[] args)
		{
			Shape[] shapes = new Shape[4];
			
			shapes[0] = new Circle(5);
			shapes[1] = new Rectangle(10, 2);
			shapes[2] = new Triangle(8, 6);
			shapes[3] = new Square(5);

			foreach(Shape shape in shapes)
			{
				Console.WriteLine(shape.GeneralInformation);

				string type = shape.GetShapeType();
				double area = shape.CalculateArea();

				Console.WriteLine(string.Format("The size of the {0} area is {1:#.##}\n", type, area));
			}

			Rectangle rectangle = new Rectangle(2, 3);
			Square square = new Square(5);
			Console.WriteLine(string.Format("\nThe size of the {0} area is {1:#.##}\n", rectangle.GetShapeType(), rectangle.CalculateRectangleArea()));
			Console.WriteLine(string.Format("The size of the {0} area is {1:#.##}\n", square.GetShapeType(), square.CalculateRectangleArea()));

			Console.ReadLine();
		}
	}
}
