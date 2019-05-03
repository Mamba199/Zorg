﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZorgPractice.ItemSystem
{
	internal class Weapon : Item
	{
		#region Constructor
		public Weapon(int damage, int speed)
		{
			_Damage = damage;
			_Speed = speed;
		}
		#endregion

		#region Fields
		private int _Damage;
		private int _Speed;
		#endregion
	}
}
