namespace homework8._1;
public class Repo
{
    private Dictionary<string, string> People;
    public Repo()
    {
        People = new Dictionary<string, string>();
    }
    public void CreatePeople()
    {
        bool flag = true;
        while (flag)
        {
            Console.WriteLine("Введите номер телефона - ");
            string phoneNumber = Console.ReadLine();
            Console.WriteLine("Введите имя - ");
            string name = Console.ReadLine();
            People.TryAdd(phoneNumber, name);
            if (string.IsNullOrWhiteSpace(phoneNumber)) flag = false;
        }
    }

    public void GetPeople()
    {
        string values = "";
        Console.WriteLine($"Введите номер телефона - ");
        string phoneNumber = Console.ReadLine();
        if (People.TryGetValue(phoneNumber, out values))
        {
            Console.WriteLine($"У номера телефона - {phoneNumber} владелец {values} ");
        }
        else Console.WriteLine("Владелец с таким номером телефона не найден");
    }
}
