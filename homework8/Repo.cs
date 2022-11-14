namespace homework8;

class Repository
{ 
   List<int> Numbers;

   public Repository()
   {
      Numbers = new List<int>();
   }

   public void AddNumbers()
   {
      
      Random r = new Random();
      for (int i = 0; i < 100; i++)
      {
         int number = r.Next(0, 101);
         Numbers.Add(number);
      }
   }

   public void GetNumbers()
   {
      Console.WriteLine("Все числа - ");
      foreach (var number in Numbers)
      {
         Console.WriteLine($"{number}");
      }
      Console.WriteLine($"Количество чисел - {Numbers.Count}");
   }

   public void DeleteNumbers()
   {
      foreach (var number in Numbers.ToList())
      {
         if(number>25&&number<50) 
            Numbers.Remove(number);
      }
      GetNumbers();
   }
}