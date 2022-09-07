using System;
using MediatorPattern.mediator;

namespace MediatorPattern.colleagues
{
	public abstract class Colleague
	{
		protected Mediator? Mediator { get; private set; }

		public void setMediator(Mediator mediator)
		{
            this.Mediator = mediator;
		}

		// 接收訊息後如何反應
		public abstract void receive(string msg);

		// 傳送訊息給特定物件
		public abstract void send(teamType type, string msg);
	}
}

