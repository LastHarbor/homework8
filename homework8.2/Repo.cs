namespace homework8._2;

public class Repo
{
    private HashSet<int> newSet = new HashSet<int>();

    public Repo()
    {
        this.newSet = new HashSet<int>();
    }

    public void AddNumber()
    {
        Console.WriteLine("Введите число  - ");
        int number = int.Parse(Console.ReadLine());
        if (newSet.Contains(number)) Console.WriteLine("Число уже существует");
        else
        {
            newSet.Add(number);
            Console.WriteLine("Число успешно добавлено");
        }
    }

    public void GetNumbers()
    {
        foreach (var number in newSet)
        {
            Console.WriteLine(number);
        }
    }
}