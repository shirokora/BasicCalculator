using System.Collections.Generic;

namespace CalculatorPrivateAssembly_
{
	public class CalculatorPrivateAssembly
	{
		
		public static float Addition(float a, float b)
		{
			float result =  a +  b;
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
			if (a == 0 || b == 0)
			
				throw new DivideByZeroException("Dont do that my friend");
				float result = a / b;
				return result;
			
		}
	}
}
