
using System;

namespace carList
{
	public class  car : IEquatable<car>
	{
		public string mark {get;set;}
		public string model {get;set;}
		public string nomer {get;set;}
		public string way { get; set; }
		public byte sitplace{get;set;}
		public car()
		{
			sitplace=0;
			mark = model = nomer = way =  " ";
		}
		public car (string mark, string model, string nomer, string way, byte sitplace = 0)
		{
			this.mark=mark;
			this.model = model;
			this.nomer=nomer;
			this.way = way;
			this.sitplace = sitplace;
		}
		public override string ToString()
		{
			return mark + " " + model + " "+ nomer + " " + way + ""+sitplace;
		} 
		
		public override bool Equals(object obj)
		{
			if (obj is car)
				return Equals((car)obj); // use Equals method below
			else
				return false;
		}
		
		public bool Equals(car other)
		{
			// add comparisions for all members here
			if(this.mark != other.mark)
				return false;
			if(model != other.model)
				return false;
			if(nomer != other.nomer)
				return false;
			if(way != other.way)
				return false;
			if (sitplace != other.sitplace)
				return false;
			return true;
		}
		
		public override int GetHashCode()
		{
			// combine the hash codes of all members here (e.g. with XOR operator ^)
			return mark.GetHashCode();
		}
		
		public static bool operator ==(car left, car right)
		{
			return left.Equals(right);
		}
		
		public static bool operator !=(car left, car right)
		{
			return !left.Equals(right);
		}
	}
}
