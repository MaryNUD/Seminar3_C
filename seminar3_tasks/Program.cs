// процедура
// void f(ref int x) reference makes it work
// {
//     x += 5;
//     Console.WriteLine(x);  if we will delete this line there will be 2 numbers in the end
// }

// int x = 10;
// Console.WriteLine(x);  10
// f(ref x);  15
// Console.WriteLine(x); 15



// функция
// string f(int a, int b) 
// {
//     if (a > b)
//         return ">";
//     return "<";
// }

// string maxi = f(50, 10);  in the end >
// Console.WriteLine(maxi);     we can write it like Console.Writeline(f(50,10)) without additional name
//.............................................................................................................

// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка

// 1
// Console.Write("Insert x: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Insert y: ");
// int y = Convert.ToInt32(Console.ReadLine());

// if (x > 0 && y > 0)
//     Console.WriteLine("I");
// else if (x > 0 && y < 0)
//     Console.WriteLine("IV");
// else if (x < 0 && y > 0)
//     Console.WriteLine("II");
// else if (x < 0 && y < 0)
//     Console.WriteLine("III");


// 2

// string f(int x, int y)
// {
//     if (x > 0 && y > 0)
//         return "I";
//     else if (x > 0 && y < 0)
//         return "IV";
//     else if (x < 0 && y > 0)
//         return "II" ;
//     return "III";         NB!!!!! we have to finish the function either with 'return' or 'else' without 'if'
// }

// Console.Write("Insert x: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Insert y: ");
// int y = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(f(x, y));   called for a function
//...........................................................................................................

// Напишите программу, которая по заданному номеру четверти, показывает 
// диапазон возможных координат точек в этой четверти (x и y).


// string f(int x)
// {
//     if (x == 1)
//         return "x > 0 && y > 0";   && two conditions have to be completed + dont forget double ==
//     else if (x == 2)
//         return "x < 0 && y > 0";
//     else if (x == 3)
//         return "x < 0 && y < 0";
//     return "x > 0 && y < 0";
// }

// Console.Write("Insert the part: ");
// int x = Convert.ToInt32(Console.ReadLine());
// string s = f(x);
// Console.WriteLine(s);


// ----------------------------------------------------------------------------------------------------------------------

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

// Console.Write("Insert x1: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Insert y1: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Insert x2: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Insert y2: ");
// int y2 = Convert.ToInt32(Console.ReadLine());

// double d = Math.Round(Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)), 3);
// Console.WriteLine(d); d - distance


// ------------------------------------------------------------------------------------------------------------------------
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

// Console.Write("Insert number: ");
// int n = Convert.ToInt32(Console.ReadLine());

// for (int i = 1; i <= n; i ++)
//     Console.Write($"{Math.Pow(i, 2)} ");

