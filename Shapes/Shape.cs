using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
	public abstract class Shape
	{
		public string GeneralInformation 
		{ 
			get { return "The figure is a kind of geometric figures"; }			
		}

		protected Shape()
		{ }

		public abstract double CalculateArea();

		public abstract string GetShapeType();		
	}
}
