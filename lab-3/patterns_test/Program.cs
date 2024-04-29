using Adapter;
using Decorator;
using Bridge;
using Proxy;
using Composite;
using static System.Net.Mime.MediaTypeNames;
using System.Threading;
//=============================Testing ADAPTER pattern=============================
Logger log = new Logger();
log.Log("Hello");
log.Error("Error");
log.Warn("Warning");

FileWriter fileWriter = new FileWriter();
fileWriter.Write("Text in current line ");
fileWriter.WriteLine("Text in next line");


FileWriterAdapter adapter = new FileWriterAdapter(fileWriter);
adapter.Log("Hello");
adapter.Error("Error");
adapter.Warn("Warning");

//=============================Testing ADAPTER pattern=============================


//=============================Testing DECORATOR pattern=============================
IHero warrior = new Warrior();
IHero mage = new Mage();
IHero paladin = new Paladin();

paladin = new ArmorDecorator(paladin);
paladin = new WeaponDecorator(paladin);

paladin.showEquipment();
//=============================Testing DECORATOR pattern=============================


//=============================Testing BRIDGE pattern=============================
Console.WriteLine();
IRender vectorRenderer = new VectorRender();

IRender rasterRenderer = new RasterRender();

Shape circle = new Circle(vectorRenderer);
Shape square = new Square(rasterRenderer);
Shape triangle = new Triangle(vectorRenderer);

circle.Draw();
square.Draw();
triangle.Draw();

circle.changeRender(rasterRenderer);
circle.Draw();
//=============================Testing BRIDGE pattern=============================


//=============================Testing PROXY pattern=============================
SmartTextReader reader = new SmartTextReader();
string[,] textArray = reader.ReadText("../../../../Proxy/TestText.txt");
reader.DisplayTextArray(textArray);

ITextReader smartTextChecker = new SmartTextChecker(reader);
string[,] textArray1 = smartTextChecker.ReadText("../../../../Proxy/TestText.txt");

ITextReader smartTextLocker = new SmartTextReaderLocker(reader, @"test\d\.txt");
string[,] textArray2 = smartTextLocker.ReadText("test1.txt"); // Access denied!
//=============================Testing PROXY pattern=============================

//=============================Testing COMPOSITE pattern=============================
Console.WriteLine();

LightElementNode body = new LightElementNode("body", "block", "closing", new List<string>());

LightElementNode div = new LightElementNode("div", "block", "closing", new List<string> { "container" });
LightElementNode h1 = new LightElementNode("h1", "inline", "closing", new List<string>());
h1.addChild(new LightTextNode("Welcome to LightHTML!"));
div.addChild(h1);

LightElementNode p = new LightElementNode("p", "block", "closing", new List<string>());
p.addChild(new LightTextNode("This is a simple example of using LightHTML."));
div.addChild(p);

LightElementNode img = new LightElementNode("img", "inline", "self-closing", new List<string> { "img-responsive" });
img.addChild(new LightTextNode(""));
div.addChild(img);

body.addChild(div);



/*Console.WriteLine("\nТЕСТУВАННЯ ПАТЕРНУ STATE\n");
LightElementNode div_state = new LightElementNode("div", "block", "closing", new List<string> { "container" });
LightElementNode p_state = new LightElementNode("p", "inline", "closing", new List<string> { "paragraph" });
LightTextNode text_state = new LightTextNode("Sample text");
div_state.addChild(p_state);
p_state.addChild(text_state);

Console.WriteLine(div_state.OuterHTML());*/

//ДОДАВАННЯ ЕЛЕМЕНТІВ ДЛЯ ПЕРЕВІРКИ ІТЕРАТОРА
/*LightElementNode div_two = new LightElementNode("div", "block", "closing", new List<string> { "container" });
LightElementNode p_two = new LightElementNode("p", "block", "closing", new List<string>());
p_two.addChild(new LightTextNode("Just testing ITERATOR."));

div_two.addChild(p_two);

body.addChild(div_two);

IIterator iterator = body.CreateIterator();

Console.WriteLine("Depth-First Search:");
foreach (var node in iterator.TraverseDepthFirst())
{
    Console.WriteLine(node.OuterHTML());
}

Console.WriteLine("\nBreadth-First Search:");
foreach (var node in iterator.TraverseBreadthFirst())
{
    Console.WriteLine(node.OuterHTML());
}
*/

//ДОДАВАННЯ ЕЛЕМЕНТІВ ДЛЯ ПЕРЕВІРКИ COMMAND
Console.WriteLine("\nTESTING COMMAND PATTERN: \n");
LightElementNode element = new LightElementNode("body", "block", "closing", new List<string>());

ICommand addChildCommand = new AddChildCommand(element, new LightTextNode("Hello, world!"));
ICommand addClassCommand = new AddClassCommand(element, "example-class");

Invoker invoker = new Invoker(new List<ICommand>
{
    addChildCommand,
    addClassCommand
});

Console.WriteLine("\nAFTER EXECUTE: \n");
invoker.ExecuteCommands();
Console.WriteLine(element.OuterHTML());

Console.WriteLine("\nAFTER UNDO: \n");
invoker.UndoLastCommand();
invoker.UndoLastCommand();
invoker.UndoLastCommand();
Console.WriteLine(element.OuterHTML());

// Виведення сторінки в консоль
//Console.WriteLine(body.OuterHTML());
//=============================Testing COMPOSITE pattern=============================