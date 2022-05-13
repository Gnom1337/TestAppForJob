using System;

namespace TestApp
{
	public class Circle : IFigure
	{
		public double Radius { get; set; }
		public const double MinRadius = 1e-6;
		public Circle(double Rad)
		{
			if (Rad - MinRadius < Constants.CalculationAccuracy)
				throw new ArgumentException("Неверно указан радиус круга", nameof(Rad));
			Radius = Rad;
		}
		public double GetSquare()
		{
			return Math.PI * Math.Pow(Radius, 2d);
		}
	}
}