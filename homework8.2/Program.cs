using homework8._2;

var flag = true;
Repo r = new Repo();
while (flag)
{
    Console.WriteLine("1 - добавить число\n2 - посмотреть числа");
    var switcher = Convert.ToInt32(Console.ReadLine());
    switch (switcher)
    {
        case 1:
            r.AddNumber();
            break;
        case 2:
            Console.Clear();
            r.GetNumbers();
            break;
    }
}