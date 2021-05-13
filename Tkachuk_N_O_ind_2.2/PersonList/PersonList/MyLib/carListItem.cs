/*
 * Created by SharpDevelop.
 * User: guyver
 * Date: 17.02.2020
 * Time: 10:18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace carList
{
	/// <summary>
	/// Description of PersonListItem.
	/// </summary>
	public class carListItem
	{
		public car Cars {get;set;}
		public carListItem next {get;set;}
		public carListItem()
		{
			Cars.sitplace = 0;
			Cars.model = "n/d";
			Cars.nomer = "n/d";
			Cars.mark = "n/d";
			Cars.way = "n/d";
			//next=null;
		}
		public carListItem(byte sitplace, string model, string nomer, string mark, string way)
		{
			Cars.sitplace = sitplace;
			Cars.model = model;
			Cars.nomer = nomer;
			Cars.mark = mark;
			Cars.way = way;
			//next=null;
		}
		public carListItem(car c)
		{
			Cars = c;
			//next=null;
		}
		
	}
}
