using System;
using System.Linq;

class MainClass
{
	public static void Main ()
	{
		var res = Enumerable.Range (1, 999)
			.Where (x => x % 3 == 0 || x % 5 == 0)
			.Sum ();

		Console.WriteLine (res);
	}
}
