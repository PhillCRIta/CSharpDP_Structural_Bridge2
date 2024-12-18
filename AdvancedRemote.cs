using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Bridge2
{
	internal class AdvancedRemote : RemoteControl
	{
		private readonly IDevice device;

		public AdvancedRemote(IDevice device) : base(device)
		{
			this.device = device;
		}
		public void SetChannel(int channel)
		{
			Console.WriteLine("I'm setting channel on device: " + this.device.GetType().Name);
		}
	}
}
