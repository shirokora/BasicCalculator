using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculator
{
	internal class PrivateAssembly
	{
		public static float Addition(float a, float b)
		{
			float result = a + b;
			return result;
		}

		public static float Subtraction(float a, float b)
		{
			float result = a - b;
			return result;
		}

		public static float Multiplication(float a, float b)
		{
			float result = a * b;
			return result;
		}

		public static float Divide(float a, float b)
		{
			float result = a / b;
			return result;
		}
	}
}
