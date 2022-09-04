// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int [] CreateRandomArray (int size){
    int[] array=new int [size];
    for (int i=0; i<array.Length;i++){
        array[i]=new Random().Next(100,1000);
    }
    return array;
}

void CountOfEvenNumbers (int[]array){
    int countOfEven=0;
    for (int i=0; i<array.Length;i++){
        int even=array[i]%2;
        if(even==0){
            countOfEven++;
        }                
        }
    Console.WriteLine($"Amount of even numbers is: {countOfEven}");
        
        }

void ShowArray (int [] array){
    for (int i=0; i<array.Length;i++){
        Console.Write(array[i]+" ");
    }
}

Console.WriteLine("Input size: ");
int size=Convert.ToInt32(Console.ReadLine());
int [] array=CreateRandomArray(size);
ShowArray(array);
CountOfEvenNumbers(array);
*/


//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
/*
int [] CreateRandomArray (int size,int min,int max){
    int[] array=new int [size];
    for (int i=0; i<array.Length;i++){
        array[i]=new Random().Next(min,max+1);
    }
    return array;
}

void SumOfOddNumbers (int[]array){
    int countOfOdd=0;
    for (int i=0; i<array.Length;i++){
        int odd=i%2;
        if(odd!=0){
            countOfOdd+=array[i];
        }                
        }
    Console.WriteLine($"Sum of odd index of numbers is: {countOfOdd}");
        
        }

void ShowArray (int [] array){
    for (int i=0; i<array.Length;i++){
        Console.Write(array[i]+" ");
    }
}

Console.WriteLine("Input size: ");
int size=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min: ");
int min=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max: ");
int max=Convert.ToInt32(Console.ReadLine());
int [] array=CreateRandomArray(size,min,max);
ShowArray(array);
SumOfOddNumbers(array);
*/

//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
/*
void DifMaxMin (int[]arr){
    int min=arr[0];
    int max=arr[0];
    int dif=0;
    for (int i=0; i<arr.Length;i++){
        if (arr[i]>max){
            max=arr[i];
        }
        else if (arr[i]<min){
            min=arr[i];
        }
 
}
    dif = max-min;
    Console.WriteLine($"Difference between {max} and {min} is {dif}");

}

void ShowArray (int [] array){
    for (int i=0; i<array.Length;i++){
        Console.Write(array[i]+" ");
    }
}

Console.WriteLine("Input size: ");
int size=Convert.ToInt32(Console.ReadLine());
int [] array=new int[size];

for (int i=0; i<array.Length;i++){
    Console.WriteLine("Input number: ");
    array[i]=Convert.ToInt32(Console.ReadLine());
}

ShowArray(array);
DifMaxMin(array);
*/