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
			_ItemCollection = new Dictionary<Item, int>();
		}
		#endregion

		#region Fields
		public Dictionary<Item, int> _ItemCollection;
		#endregion

		#region Internal Methods
		internal void Add(Item itemToAdd, int quantity)
		{
			_ItemCollection.Add(itemToAdd, quantity);
		}
		#endregion
	}
}
