using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
	public class Triangle : Shape
	{
		public int _height { get; private set; }
		public int _baseLenght { get; private set; }

		public Triangle(int height, int baseLenght)
		{
			_height = height;
			_baseLenght = baseLenght;
		}

		public override double CalculateArea()
		{
			return 0.5 * _height * _baseLenght;
		}

		public override string GetShapeType()
		{
			return typeof(Triangle).Name;
		}
	}
}
