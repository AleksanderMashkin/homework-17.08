/* 1 задача
{
    Console.WriteLine("Введите пятизначное число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    string FiveSign = Convert.ToString(number);
    if (FiveSign[0] == FiveSign[4] || FiveSign[1] == FiveSign[3]) 
    {
        Console.Write("Данное число является палиндромом.");
    }
    else
    {
        Console.Write("Данное число не является палиндромом.");
    }
}   */





// 2 Задача
/*
Console.WriteLine("Введите координату x для точки A ");
int x1 = Convert.ToInt32(Console.ReadLine());;

Console.WriteLine("Введите координату y для точки A");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату z для точки A");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату x для точки B ");
int x2 = Convert.ToInt32(Console.ReadLine());;

Console.WriteLine("Введите координату y для точки B");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату z для точки B");
int z2 = Convert.ToInt32(Console.ReadLine());

Double Segment = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2-z1, 2));

Double Distance = Math.Round(Segment, 2);

Console.WriteLine("Расстояние между точками в 3D: " + Distance); */


    
        Console.WriteLine("Введите число");
        int N = Convert.ToInt32(Console.ReadLine());
        double number = 0;
        for (int i = 1; i <= N; i++)
        {
          number = Math.Pow(i, 3);
          Console.WriteLine(number + "; ");     
        }