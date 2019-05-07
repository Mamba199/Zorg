using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZorgPractice.CommonFunctionality;

namespace ZorgPractice.ItemSystem
{
	internal class Weapon : Item
	{
		#region Constructor
		public Weapon(int damage, int speed, WeaponType weapontype)
		{
			_Damage = damage;
			_Speed = speed;
			WeaponType = weapontype;
		}
		#endregion

		#region Fields
		private int _Damage;
		private int _Speed;
		#endregion

		#region Properties
		public WeaponType WeaponType { get; }
		#endregion
	}
}
