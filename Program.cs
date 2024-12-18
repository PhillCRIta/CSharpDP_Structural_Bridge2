

using Structural_Bridge2;

Console.WriteLine("Create LG remote control");
//this script separate the remote generic controller to the concrete brand of remote
//the bad case was LGRadioAndTVRemote, all together in the same remote
RemoteControl lgRemoteControl = new RemoteControl(new LGRadio());
lgRemoteControl.TurnOn();
lgRemoteControl.TurnOff();

AdvancedRemote sonyAdvanceRemote = new AdvancedRemote(new SonyRadio());
sonyAdvanceRemote.TurnOn();
sonyAdvanceRemote.TurnOff();
sonyAdvanceRemote.SetChannel(2);



RemoteControl apRemoteControl = new RemoteControl(new AppleTV());
apRemoteControl.TurnOn();
apRemoteControl.TurnOff();

AdvancedRemote apAdvanceRemote = new AdvancedRemote(new AppleTV());
apAdvanceRemote.TurnOn();
apAdvanceRemote.TurnOff();
apAdvanceRemote.SetChannel(2);