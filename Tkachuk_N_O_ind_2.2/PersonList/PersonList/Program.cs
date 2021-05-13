/*
 * Created by SharpDevelop.
 * User: guyver
 * Date: 17.02.2020
 * Time: 9:57
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace carList
{
	class Program
	{
		public static bool Add(int x, int y, out int z)
		{
			z=x+y;
			return true;
		}
		public static void Main(string[] args)
		{
			carList list=new carList(new car("porshe0","puk","6666", "20.584", 20));
			list.Addcar(new car("porshe1", "puk", "6666", "20.584", 2));
			list.Addcar(new car("porshe2", "puk", "6666", "20.584", 10));
			list.Addcar(new car("porshe3", "puk", "6664", "20.584", 8));
			list.Addcar(new car("porshe4", "puk", "6664", "20.584", 6));
			list.Addcar(new car("porshe5", "puk", "6666", "20.584", 2));
			Console.WriteLine(list);
			car res=list.Findcar("porshe5");
			Console.WriteLine(res);
			
            carList resList=list.FindAllcar("6664");
			Console.WriteLine(resList);			
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}