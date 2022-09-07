using System;
using MediatorPattern.colleagues;

namespace MediatorPattern.mediator
{
    // 團隊列舉
    public enum teamType
    {
        ENGINEERING, DESIGN, SERVICE, MARKETING
    }

    // 抽象mediator
    public abstract class Mediator
	{
		public abstract void Register(teamType type, Colleague colleague); //註冊進入mediator
		public abstract void Relay(teamType type, string msg); //轉發;傳遞
	}
}

