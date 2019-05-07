using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZorgPractice.ItemSystem;

namespace ZorgPractice.Player
{
	internal class Inventory
	{
		#region Constructor
		public Inventory()
		{
			ItemCollection = new Dictionary<Item, int>();
		}
		#endregion

		#region Fields
		
		#endregion

		#region Internal Methods
		internal void Add(Item itemToAdd, int quantity)
		{
			ItemCollection.Add(itemToAdd, quantity);
		}
		#endregion

		#region Properties
		public Dictionary<Item, int> ItemCollection { get; }
		#endregion
	}
}
