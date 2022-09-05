  Console.WriteLine("Введите три числа: ");
  int nam_1 = Convert.ToInt32(Console.ReadLine());
  int nam_2 = Convert.ToInt32(Console.ReadLine());
  int nam_3 = Convert.ToInt32(Console.ReadLine());

  int max = nam_1;

  if (nam_2 > max)
  {
     max = nam_2;
  }
  if (nam_3 > max)
  {
    max = nam_3;
  }
  Console.WriteLine("Большее из трёх чисел: " + max);
  