using System;
using MediatorPattern.colleagues;

namespace MediatorPattern.mediator
{
	// 具體mediator
	public class ProductManager : Mediator
	{
        // 聚合Colleague, 一個儲存colleague物件的dictionary
        private Dictionary<teamType, Colleague> colleagues = new Dictionary<teamType, Colleague>();

        public override void Register(teamType type, Colleague colleague)
        {
            colleague.setMediator(this);
            this.colleagues.Add(type, colleague);
        }

        public override void Relay(teamType type, string msg)
        {
            Colleague toColleague = this.colleagues[type];
            toColleague.receive(msg);
        }
    }
}

