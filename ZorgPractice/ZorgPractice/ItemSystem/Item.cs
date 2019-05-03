using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZorgPractice.ItemSystem
{
	internal class Item
	{
		#region Constructor
		public Item()
		{
			
		}
		#endregion

		#region Properties
		public string ItemName { get; set; }

		public string Description { get; set; }

		public uint Cost { get; set; }
		#endregion
	}
}
