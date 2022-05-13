using System;

namespace TestApp
{
    public class Utils
    {
		public static void SwapValues<T>(ref T First, ref T Second)
		{
			T Temp = First;
			First = Second;
			Second = Temp;
		}
	}
}
