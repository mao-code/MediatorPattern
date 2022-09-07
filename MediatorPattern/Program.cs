using MediatorPattern.colleagues;
using MediatorPattern.mediator;

// 具體mediator
ProductManager pm = new ProductManager();

//具體colleague
Colleague ds = new DesignTeam();
Colleague eg = new EngineeringTeam();
Colleague mk = new MarketingTeam();
Colleague sv = new ServiceTeam();

//註冊進入mediator
pm.Register(teamType.DESIGN, ds);
pm.Register(teamType.ENGINEERING, eg);
pm.Register(teamType.MARKETING, mk);
pm.Register(teamType.SERVICE, sv);

//執行
ds.send(teamType.ENGINEERING, "UI設計稿完成");
Console.WriteLine(String.Concat(Enumerable.Repeat("-", 10)));

eg.send(teamType.MARKETING, "軟體開發完成");
Console.WriteLine(String.Concat(Enumerable.Repeat("-", 10)));

Console.ReadKey();


