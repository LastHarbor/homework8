using System.Xml.Linq;
using homework8._3;

var flag = true;
Repo r = new Repo();
while (flag)
{
    Console.WriteLine("1 - Добавить воркера\n2 - очистить экран");
    var switcher = Convert.ToInt32(Console.ReadLine());
    switch (switcher)
    {
        case 1:
           r.AddWorker();
            break;
        case 2:
            Console.Clear();
            break;
        default:
            break;
    }
}