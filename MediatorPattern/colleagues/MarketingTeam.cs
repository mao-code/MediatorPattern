using System;
using MediatorPattern.mediator;

namespace MediatorPattern.colleagues
{
	public class MarketingTeam : Colleague
	{
        public override void receive(string msg)
        {
            Console.WriteLine("產銷團隊收到訊息: " + msg);
        }

        public override void send(teamType type, string msg)
        {
            Console.WriteLine("產銷團隊發送訊息: "+msg);
            if (this.Mediator != null)
            {
                this.Mediator.Relay(type, msg);
            }
        }
    }
}

