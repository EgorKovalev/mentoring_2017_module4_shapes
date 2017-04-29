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
			Shape[] shapes = new Shape[3];
			
			shapes[0] = new Circle(5);
			shapes[1] = new Square(10);
			shapes[2] = new Triangle(8, 6);

			foreach(Shape shape in shapes)
			{
				Console.WriteLine(shape.GeneralInformation);

				string type = shape.GetShapeType();
				double area = shape.CalculateArea();

				Console.WriteLine(string.Format("The size of the {0} area is {1:#.##}\n", type, area));
			}

			Console.ReadLine();
		}
	}
}
