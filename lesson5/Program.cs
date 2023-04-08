// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// int[] arr = CreateArray(4,99,999);
// PrintArray(arr);
// Console.WriteLine($" {ChetChislo(arr)}");


// int ChetChislo(int[] array){
//     int num = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i]%2==0){
//             num++;
//         }
//     }
//     return num;
// }

// int[] CreateArray(int length,int start, int stop){
//     Random random = new Random();
//     int[] arr = new int[length];
//     for (int i = 0; i < length; i++)
//     {
//         int num2 = random.Next(start,stop);
//         arr[i] = num2;
        
//     }
//     return arr;
// }

// void PrintArray( int [] arr){
//     Console.Write("[");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write(arr[i]);
//         if(i+1<arr.Length){
//             Console.Write(", ");
//         }
//     }
//     Console.Write("]");
// }







// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


// int[] array = CreateArray(4,1,99);
// PrintArray(array);
// Console.WriteLine(SumArrayChet(array));


// int SumArrayChet(int[] arr){
//     int sumchet = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (i%2!=0){
//             sumchet+= arr[i];
//         }
//     }
//     return sumchet;
// }



// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


// double[] array = CreateArrayDouble(5,1,99);
// PrintArraydouble(array);

// Console.WriteLine($" -> {SumArrayMaxMin(array)}");

// double SumArrayMaxMin (double[] array){
//     double max = SearchMax(array);
//     double min = SearchMin(array,max);
//     return (max-min);
// }

// double SearchMax(double[]arr){
//     double num = 0 ;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if(arr[i]>num){
//             num = arr[i];
//         }
//     }
//     return num;
// }

// double SearchMin(double[]arr,double max){
//     double num = max ;
//     for (int i = 0; i < arr.Length; i++)
//     {
        
//         if(arr[i]<num){
//             num = arr[i];
//         }
//     }
//     return num;
// }

// double[] CreateArrayDouble(int length,double start, double stop){
//     Random random = new Random();
//     double[] arr = new double[length];
//     for (int i = 0; i < length; i++)
//     {
//         double num2 = Math.Floor(random.NextDouble() * (stop - start) + start);
//         arr[i] = num2;
        
//     }
//     return arr;
// }

// void PrintArraydouble( double [] arr){
//     Console.Write("[");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write(arr[i]);
//         if(i+1<arr.Length){
//             Console.Write(", ");
//         }
//     }
//     Console.Write("]");
// }