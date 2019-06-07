using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZorgPractice.CommonFunctionality.States
{
	public interface Istate
	{
		void Initalize();
		void PerformTask();
		event Action<Type> RequestStateChange;
		void Finish();
	}
}
