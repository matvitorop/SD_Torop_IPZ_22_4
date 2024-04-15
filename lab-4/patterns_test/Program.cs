using CoR;


//=============================Testing CoR pattern=============================
var handler1 = new HandlerLvl1();
var handler2 = new HandlerLvl2();
var handler3 = new HandlerLvl3();
var handler4 = new HandlerLvl4();

handler3.SetNextHandler(handler4);
handler2.SetNextHandler(handler3);
handler1.SetNextHandler(handler2);

while (true)
{
    Console.WriteLine("Do you have a qustion? (to escape print 'exit')");
    var issue = Console.ReadLine();

    if (issue.ToLower() == "exit")
        break;

    var request = new Request(issue);

    handler1.HandleRequest(request);
}
//=============================Testing CoR pattern=============================
