using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZorgPractice.CommonFunctionality;

namespace ZorgPractice.ItemSystem
{
	internal class Armour : Item
	{
		#region Constructor
		public Armour(int resistance, int weight, ArmourType armourtype)
		{
			_Resistance = resistance;
			_Weight = weight;
			ArmourType = armourtype;
		}
		#endregion

		#region Fields
		private int _Resistance;
		private int _Weight;
		#endregion

		#region Properties
		public ArmourType ArmourType { get; }
		#endregion
	}
}
