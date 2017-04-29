using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
	public abstract class Shape
	{
		public string GeneralInformation { get; private set; }

		protected Shape()
		{
			GeneralInformation = "The figure is a kind of geometric figures";
		}

		public abstract double CalculateArea();

		public abstract string GetShapeType();		
	}
}
