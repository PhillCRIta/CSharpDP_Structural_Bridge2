using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Bridge2
{
	//this interface is the bridge
	internal interface IDevice
	{
		public void TurnOn();
		public void TurnOff();
		public void SetChannel(int channel);
	}
}
