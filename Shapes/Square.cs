using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
	public class Square : Shape
	{
		public int _side { get; private set; }

		public Square(int side)
		{
			_side = side;
		}

		public override double CalculateArea()
		{
			return _side ^ 2;
		}

		public override string GetShapeType()
		{
			return typeof(Square).Name;
		}
	}
}
