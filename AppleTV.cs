using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Bridge2
{
	internal class AppleTV : IDevice
	{
		public void SetChannel(int channel)
		{
			throw new NotImplementedException();
		}

		public void TurnOff()
		{
			Console.WriteLine("Turn off AppleTV ");
		}

		public void TurnOn()
		{
			Console.WriteLine("Turn on AppleTV ");
		}
	}
}
