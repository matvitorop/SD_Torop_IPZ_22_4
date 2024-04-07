using FlyWeight;
//=============================Testing FLYWEIGHT pattern=============================
MemoryMonitor.CheckCurrentProcess();

//Тестування БЕЗ flyweight
//BookToHTMLConverterNoFW bookConvertorNFW = new BookToHTMLConverterNoFW();
//string text1 = bookConvertorNFW.ConvertToHTML("../../../../FlyWeightTest/TestText.txt");
//Тестування БЕЗ flyweight

//Тестування З flyweight
BookToHTMLConverter bookConvertor = new BookToHTMLConverter();
string text = bookConvertor.ConvertToHTML("../../../../FlyWeightTest/TestText.txt");
//Тестування З flyweight

MemoryMonitor.CheckCurrentProcess();
//=============================Testing FLYWEIGHT pattern=============================