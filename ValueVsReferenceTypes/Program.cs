using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueVsReferenceTypes
{
	class Program
	{
		static void Main(string[] args)
		{

			FractionRef fraction1 = new FractionRef()
			{
				Numerator = 1,
				Denominator = 2
			};

			FractionRef fraction2 = fraction1;

			fraction2.Numerator = 100;

			Console.WriteLine(fraction1.Numerator);

			FractionVal frac1 = new FractionVal()
			{
				Numerator = 1,
				Denominator = 2
			};

			FractionVal frac2 = frac1;

			frac2.Numerator = 100;

			Console.WriteLine(frac1.Numerator);

			Console.ReadLine();
		}
	}

	class FractionRef
	{
		public int Numerator { get; set; }
		public int Denominator { get; set; }
	}

	struct FractionVal
	{
		public int Numerator { get; set; }
		public int Denominator { get; set; }
	}
}
