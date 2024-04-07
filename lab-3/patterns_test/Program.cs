using Adapter;
using Decorator;
using Bridge;
using Proxy;
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


//=============================Testing Proxy pattern=============================
SmartTextReader reader = new SmartTextReader();
string[,] textArray = reader.ReadText("../../../../Proxy/TestText.txt");
reader.DisplayTextArray(textArray);

ITextReader smartTextChecker = new SmartTextChecker(reader);
string[,] textArray1 = smartTextChecker.ReadText("../../../../Proxy/TestText.txt");

ITextReader smartTextLocker = new SmartTextReaderLocker(reader, @"test\d\.txt");
string[,] textArray2 = smartTextLocker.ReadText("test1.txt"); // Access denied!
//=============================Testing Proxy pattern=============================