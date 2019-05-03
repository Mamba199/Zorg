using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZorgPractice.ItemSystem
{
	internal class Armour : Item
	{
		#region Constructor
		public Armour(int resistance, int weight)
		{
			_Resistance = resistance;
			_Weight = weight;
		}
		#endregion

		#region Fields
		private int _Resistance;
		private int _Weight;
		#endregion
	}
}
