/*
 * Created by SharpDevelop.
 * User: guyver
 * Date: 17.02.2020
 * Time: 10:32
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Text;

namespace carList
{
	/// <summary>
	/// Description of PersonList.
	/// </summary>
	public class carList
	{
		private carListItem first;
		private carListItem last;
		private uint numElements;
		public uint Count
		{
			get
			{
				return numElements;
			}
		}
		public carList()
		{
			numElements=0;
			first=last=null;
		}
		public carList(car c)
		{
			first=new carListItem(c);
			last=first;
			++numElements;
		}
		
		public void Addcar(car c)
		{
			if(first==null)
			{
				first=new carListItem(c);
			    last=first;
			}
			else
			{
				last.next=new carListItem(c);
				last=last.next;
			}
			++numElements;
		}
		
		public override string ToString()
		{
			StringBuilder strB=new StringBuilder(100);
			carListItem item=first;
			while(item!=null)
			{
				strB.AppendLine("Node: "+item.Cars.ToString());
				item=item.next;
			}
			return strB.ToString();
		}
		public car Findcar(string mark)
		{
			car result;
			carListItem item=first;
			while(item!=null)
			{
				if(mark == item.Cars.mark)
				{
					return item.Cars;
					//break;
				}
				item=item.next;
			}
			throw new System.NullReferenceException();
		}
		public carList FindAllcar(string nomer)
		{
			carList list=new carList();
			carListItem item=first;
			while(item!=null)
			{
				if(nomer==item.Cars.nomer)
				{
					list.Addcar(item.Cars);
				}
				item=item.next;
			}
			return list;
		}
		
	}
}
