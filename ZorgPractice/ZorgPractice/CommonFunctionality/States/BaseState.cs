using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZorgPractice.CommonFunctionality.States
{
	public class BaseState : Istate
	{

		#region Constructors
		public BaseState()
		{

		}
		#endregion

		public void Finish()
		{
			throw new NotImplementedException();
		}

		public void Initalize()
		{
			throw new NotImplementedException();
		}

		public void PerformTask()
		{
			throw new NotImplementedException();
		}

		public event Action<Type> RequestStateChange;

		public void ChangeState<Type>()
		{
			RequestStateChange.Invoke(typeof(Type));
		}
	}
}
