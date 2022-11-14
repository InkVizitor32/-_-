Console.Clear();
// //                    Задача 24: Напишите программу, которая принимает на
// //                     вход число (А) и выдаёт сумму чисел от 1 до А.
// // 7 -> 28
// // 4 -> 10
// // 8 -> 36

// Console.Clear();
// // / Console.WriteLine("Введите целое число");
// // int n = Convert.ToInt32(Console.ReadLine());
// // int sum=0;
// // for (int i =1; i<=n;i++) sum=sum+i;)
// // Console.WriteLine($"Сумма всех чисел от 1 до {n} равна {sum}");

// void SumNumbers(int x)
// {
// int sum=0;
// for (int i =1; i<=x;i++)
// sum=sum+i;
// Console.WriteLine($"Сумма всех чисел от 1 до {x} равна {sum}");
// }

// int SumNumbers2(int x)
// {
// int sum=0;
// for (int i =1; i<=x;i++)
// sum=sum+i;
// return sum;
// }


// Console.WriteLine("Введите целое число");
// int n = Convert.ToInt32(Console.ReadLine());
// //SumNumbers(n);
// Console.WriteLine(SumNumbers2(n));


//                   Задача 26: Напишите программу, которая принимает 
//                   на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5





// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// SumNumbers(num);
// void SumNumbers(int num)
// {
// int razryad=0;
// while (num % 10 >0)
// {
// razryad++;
// num/=10;
// }
// Console.WriteLine(razryad);
// }

// Console.WriteLine("Введите число: ");
// int x=Convert.ToInt32(Console.ReadLine()) ;
// int a = (int)Math.Log10(x)+1;
// Console.WriteLine($"Число символов {a}");


// Задача 28: Напишите программу, которая принимает 
// на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120






// Console.WriteLine("Введите число: ");
// int x = Convert.ToInt32(Console.ReadLine());
// int N = 1;
// SumNumbers(x);
// void SumNumbers(int x)
//  {

// for (int i=2; i<=x; i++)
// N=N*i;
//  }

// Console.WriteLine($"произведение чисел от 1 до {x} = {N}");


// Задача 30:
// Напишите программу, которая выводит массив
// из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]


// int [] array = new int[8];             // определить  массив из 8 элементов
// void FillArray(int[] collection)       // заполнить массив
// {
// int lenght = 8;
// int index = 0;
// while (index<lenght)
// {
// collection[index] = new Random().Next(0,2);    // рандомный массив в которомм присутствуют цифры от 0 до 1 (не включает последнюю цифру)
// index++;
// }
// }
// void PrintArray (int[] array)           // печать массив
// {
//     int count = 8;
//     for  (int i =0; i < count; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//      Console.WriteLine();
// }
// FillArray(array);
// PrintArray(array);

// int p =0;
// int count = 8;
// for (int i=0; i<count; i++)
// {
//    if (array [i] == 1) p= p+1;
// }

// Console.WriteLine(p);

// int[] array = new int[8];

// for (int i=0; i<8; i++)
// {
// array [i] = new Random().Next(0,2);
// Console.Write(array[i]+" ");
// }







//         



// double[] numbers = new double[4];
// Random rnd = new Random();
// Console.WriteLine("Массив:");
// for (int i = 0; i < numbers.Length; i++) {
//     numbers[i] = rnd.NextDouble()  + 22;
//     Console.Write($"   {numbers[i] }");
// }


double[] array = new double[5];
Random a = new Random();   //экземпляр генератора случайных чисел
for (int i = 0; i < array.Length; i++)
{
array[i] =a.Next(-100, 100) + a.NextDouble();
Console.Write($"   {array[i]}");
}
