using homework8._1;


var flag = true;
Repo r = new Repo();
while (flag)
{
    Console.WriteLine("1 - добавить человека\n2 - Выводе человека по номеру телефона");
    var switcher = Convert.ToInt32(Console.ReadLine());
    switch (switcher)
    {
        case 1:
            r.CreatePeople();
            break;
        case 2:
           r.GetPeople();
            break;
    }
}