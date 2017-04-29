using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
	public class Circle : Shape
	{
		public int _radius { get; private set; }

		public Circle(int radius)
		{
			_radius = radius;
		}

		public override double CalculateArea()
		{
			return Math.PI * (_radius ^ 2);
		}

		public override string GetShapeType()
		{
			return typeof(Circle).Name;
		}
	}
}
