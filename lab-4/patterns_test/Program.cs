using CoR;
using Strategy;
using Memento;
using Observer;

//=============================Testing CoR pattern=============================
//var handler1 = new HandlerLvl1();
//var handler2 = new HandlerLvl2();
//var handler3 = new HandlerLvl3();
//var handler4 = new HandlerLvl4();
//
//handler3.SetNextHandler(handler4);
//handler2.SetNextHandler(handler3);
//handler1.SetNextHandler(handler2);
//
//while (true)
//{
//    Console.WriteLine("Do you have a qustion? (to escape print 'exit')");
//    var issue = Console.ReadLine();
//
//    if (issue.ToLower() == "exit")
//        break;
//
//    var request = new Request(issue);
//
//    handler1.HandleRequest(request);
//}
//=============================Testing CoR pattern=============================

//=============================Testing Strategy pattern=============================
ImageLoader imageLoader = new ImageLoader();


string href = "https://example.jpg";


if (href.Contains("https://") || href.Contains("http://"))
{
    imageLoader.SetImageLoadingStrategy(new InetImageLoad());
}
else
{
    imageLoader.SetImageLoadingStrategy(new FileImageLoad());
}

imageLoader.ImageLoad(href);
//=============================Testing Strategy pattern=============================

//=============================Testing Memento pattern=============================
//TextDocument document = new TextDocument("Version of text #1");
//
//TextEditor td = new TextEditor(document);
//td.PrintDocument();
//td.Backup();
//td.textAppend("\nAdditional part for version #2");
//td.Backup();
//td.PrintDocument();
//td.ChangeText("\nWrong version #3");
//td.PrintDocument();
//Console.WriteLine("\nRestored version:");
//td.Restore();
//td.PrintDocument();
//Console.WriteLine("\nAgain restored version:");
//td.Restore();
//td.PrintDocument();
//=============================Testing Memento pattern=============================

//=============================Testing Observer pattern=============================
LightElementNode element = new LightElementNode("button", "block", "closing", new List<string>() { "btn", "btn-body" });

ClickEventListener clickListener = new ClickEventListener();
MouseOverEventListener mouseOverListener = new MouseOverEventListener();

element.AddEventListener(clickListener);
element.AddEventListener(mouseOverListener);

element.TriggerEvent("click");
element.TriggerEvent("mouseover");
//=============================Testing Observer pattern=============================