using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Bridge2
{
	internal class RemoteControl
	{
		//ABSTRACTION , composite by IDevice (IMPLEMENTOR)
		//use polimorphism to keep class nice and flexible
		//the remote control delegate the function turn on/off to the bridge with composition
		private IDevice _device;

		public RemoteControl(IDevice device)
		{
			_device = device;
		}
		public void TurnOn()
		{
			_device.TurnOn();
		}
		public void TurnOff()
		{
			_device.TurnOff();
		}

	}
}
