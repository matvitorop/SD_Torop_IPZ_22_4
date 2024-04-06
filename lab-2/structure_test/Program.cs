using Subscription;
using AbstractFactory;
using Singleton;
using Prototypes;
using Builder;

//=================================FACTORY METHOD TEST=================================
ISubscriptionFactoryMethod webSiteResponse = new WebSite(); //Працюємо з абстрактним творцем-фабрикою

Subscription.Subscription subscription;//загальний ти підписки

subscription = webSiteResponse.CreateSubscription("ForPremium");

subscription.GetStatus(); //об'єкт має властивості типу PremiumSubscription
//=================================FACTORY METHOD TEST=================================


//=================================ABSTRACT FABRIC TEST=================================
IAbstractFactory factoryOne = new ArasakaFacroty();

ILaptop laptopOne = factoryOne.CreateLaptop();

laptopOne.GetLaptop();//Створення ноутбуку з першої фабрики


IAbstractFactory factoryTwo = new SasungFacroty();

ISmartphone SmatphoneTwo = factoryTwo.CreateSmartphone();

SmatphoneTwo.GetSmartphone();//Створення смартфона з дургої фабрики

//=================================ABSTRACT FABRIC TEST=================================

//=================================SINGLETON TEST=================================
Authenticator authenticator = Authenticator.GetInstance();
Authenticator authenticator2 = Authenticator.GetInstance();//конструктор викликається лише 1 раз
//=================================SINGLETON TEST=================================


//=================================PROTOTYPE TEST=================================
// Створення вірусів
Virus virus1 = new Virus("Virus1", 1.5, 1, "Type1");
Virus virus2 = new Virus("Virus2", 2.0, 2, "Type2");
Virus virus3 = new Virus("Virus3", 1.8, 3, "Type3");

// Додавання дітей до батьківських вірусів
virus1.Family.Add(new Virus("Child1", 0.5, 1, "Type1"));
virus1.Family.Add(new Virus("Child2", 0.7, 1, "Type1"));

virus2.Family.Add(new Virus("Child3", 0.6, 2, "Type2"));

virus3.Family.Add(new Virus("Child4", 0.9, 3, "Type3"));
virus3.Family.Add(new Virus("Child5", 1.1, 3, "Type3"));

// Клонування вірусів
Virus clonedVirus1 = (Virus)virus1.Clone();
Virus clonedVirus2 = (Virus)virus2.Clone();
Virus clonedVirus3 = (Virus)virus3.Clone();

// Виведення інформації про клоновані віруси та їх дітей
Console.WriteLine("Cloned Virus 1:");
PrintVirusInfo(clonedVirus1);
Console.WriteLine("\nCloned Virus 2:");
PrintVirusInfo(clonedVirus2);
Console.WriteLine("\nCloned Virus 3:");
PrintVirusInfo(clonedVirus3);


static void PrintVirusInfo(Virus virus)
{
    Console.WriteLine($"Name: {virus.Name}, Weight: {virus.Weight}, Age: {virus.Age}, Type: {virus.Type}");
    Console.WriteLine("Family:");
    foreach (var child in virus.Family)
    {
        Console.WriteLine($" - Name: {((Virus)child).Name}, Weight: {((Virus)child).Weight}, Age: {((Virus)child).Age}, Type: {((Virus)child).Type}");
    }
}
//=================================PROTOTYPE TEST=================================

//=================================BUILDER TEST=================================
var builder = new HeroBuilder();
var builderTwo = new EnemyBuilder();

var director = new Director(builder);

Person person = director.GetFullPerson();

Console.WriteLine(person.Inventory);

director.SetBuilder(builderTwo);

Person personTwo = director.GetFullPerson();

Console.WriteLine(personTwo.Inventory);

//=================================BUILDER TEST=================================