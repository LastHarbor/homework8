using homework8;

Repository r = new Repository();

bool flag = true;
while (flag)
{
    Console.WriteLine("1 - Создать список\n2 - Вывести список\n3 - Удалить элементы между 25 и 50");
    int switcher = int.Parse(Console.ReadLine());
    switch (switcher)
    {
        case 1:
            r.AddNumbers();
            break;
        case 2:
            r.GetNumbers();
            break;
        case 3:
            r.DeleteNumbers();
            break;
        case 4:
            flag = false;
            break;
    }
}
