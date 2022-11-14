using System.Xml.Linq;

namespace homework8._3;

public class Repo
{XDocument xDoc = new XDocument();
    public Repo()
    {
        xDoc = new XDocument();
    }
    public void AddWorker()
    {
        Console.WriteLine("Введите ФИО - ");
        string fio = Console.ReadLine();
        Console.WriteLine("Введите улицу - ");
        string street = Console.ReadLine();
        Console.WriteLine("Введите номер дома - ");
        string houseNumber = Console.ReadLine();
        Console.WriteLine("Введите номер квартиры - ");
        string flatNumber = Console.ReadLine();
        Console.WriteLine("Введите мобильный телефон - ");
        string mobilePhone = Console.ReadLine();
        Console.WriteLine("Введите домашний телефон - ");
        string flatPhone = Console.ReadLine();

        XElement person = new XElement("Person");
        XAttribute nameAttribute = new XAttribute("name", fio);
        XElement adress = new XElement("Address", new XElement("Street", street), 
            new XElement("HouseNumber", houseNumber),  new XElement("FlatNumber", flatNumber)); 
        
        XElement phones = new XElement("Phones", new XElement("MobilePhone", mobilePhone), new XElement("FlatPhone", flatPhone));
        person.Add(nameAttribute);
        person.Add(adress);
        person.Add(phones);
        xDoc.Add(person);
        xDoc.Save("persone.xml");
        Console.WriteLine("Data saved");
    }
}