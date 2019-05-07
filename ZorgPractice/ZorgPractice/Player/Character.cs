using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZorgPractice.Player
{
	internal class Character
	{
		#region Constructor
		internal Character()
		{
			Inventory = new Inventory();
		}
		#endregion

		#region Properties
		public Inventory Inventory { get; }
		#endregion


	}
}
