// Задайте массив из 12 элементов, заполненный случайнми числами из промежутка [-9,9]
// Найдите сумму отрицательных и положительных чисел массива.
/*
int [] CreateRandomArray (){
    int[] array=new int [12];
    int positiveSum=0;
    int negativeSum=0;
    for (int i=0; i<array.Length;i++){
        array[i]=new Random().Next(-9,10);
    }
    for (int i=0; i<array.Length;i++){
        if(array[i]>0){
            positiveSum+=array[i];

        }
     
        else{
            negativeSum+=array[i];
           

        }
        

        }
Console.WriteLine($"Sum of positive numbers is: {positiveSum}");
         Console.WriteLine($"Sum of positive numbers is: {negativeSum}");

    return array;

}



void ShowArray (int [] array){
    for (int i=0; i<array.Length;i++){
        Console.Write(array[i]+" ");
    }
}
/*
Console.WriteLine("Input size: ");
int size=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min: ");
int min=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max: ");
int max=Convert.ToInt32(Console.ReadLine());
*/
/*
ShowArray(CreateRandomArray());
*/

// Задайте массив , заполненный случайными числами 
// Замените отрицательные элементы массива на положителньные и наоборот. 
/*
int [] CreateRandomArray (int size,int min,int max){
    int[] array=new int [size];
    for (int i=0; i<array.Length;i++){
        array[i]=new Random().Next(min,max+1);
    }
      
      return array;              

        }

        void ReplaceNegPosArray (int[]array){
for (int i=0; i<array.Length;i++){
        Console.Write(array[i]+" ");
    }
Console.WriteLine(" ");
             for (int i=0; i<array.Length;i++){
        array[i]=array[i]*(-1);
        Console.Write(array[i]+" ");
        }


        }
/*
        void ShowArray (int [] array){
    for (int i=0; i<array.Length;i++){
        Console.Write(array[i]+" ");
    }
}
*/
/*
Console.WriteLine("Input size: ");
int size=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min: ");
int min=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max: ");
int max=Convert.ToInt32(Console.ReadLine());
   

ReplaceNegPosArray(CreateRandomArray(size,min,max));
*/
//Задать одномерный массив и найти количество элементов в отрезке от 10 до 99
/*
int [] CreateRandomArray (int size,int min,int max){
    int[] array=new int [size];
    for (int i=0; i<array.Length;i++){
        array[i]=new Random().Next(min,max+1);
    }
      
      return array;              

        }

        void CountOfNumbers (int[]array){
            Console.WriteLine("Array: ");
for (int i=0; i<array.Length;i++){
        Console.Write(array[i]+" ");
    }
Console.WriteLine(" ");
            int count =0;
for (int i=0; i<array.Length;i++){
    if (array[i]>=10&&array[i]<=99){
        count++;

    }
       
    }
Console.WriteLine($"Numbers of array's elements from 10 till 99 is: {count} ");
             
        }

Console.WriteLine("Input size: ");
int size=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min: ");
int min=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max: ");
int max=Convert.ToInt32(Console.ReadLine());
CountOfNumbers(CreateRandomArray(size,min,max));
*/

//Задать одномерный массив и найти есть ли какой-то заданный элемент
/*
int [] CreateRandomArray (int size,int min,int max){
    int[] array=new int [size];
    for (int i=0; i<array.Length;i++){
        array[i]=new Random().Next(min,max+1);
    }
      
      return array;              

        }

       void ShowArray (int [] array){
    for (int i=0; i<array.Length;i++){
        Console.Write(array[i]+" ");
    }
}

void ToFindNumber(int [] array, int number ){
    bool flag=false;
    for (int i=0; i<array.Length;i++){
        if (array[i]==number){
            flag=true;

        }
        
    }          
    if (flag==true){
        Console.Write("true");
    }    
    else {
        Console.Write("false");
    }
    
}

   

Console.WriteLine("Input size: ");
int size=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min: ");
int min=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max: ");
int max=Convert.ToInt32(Console.ReadLine());
int [] array= CreateRandomArray(size,min,max);
ShowArray(array);
Console.WriteLine("");
Console.WriteLine("Has array next number? ");
int number=Convert.ToInt32(Console.ReadLine());
ToFindNumber(array,number);
*/     

//Найдите произведение пар чисел. Парой считаем первый и  последний элемент, второй и предпоследний и т.д.
//Результат запишите в новом массиве.

int [] CreateRandomArray (int size, int min, int max){
    int[] array=new int [size];
    
    for (int i=0; i<array.Length;i++){
        array[i]=new Random().Next(min, max+1);
    }
        return array;  
        }

void Multiply (int [] array){
    int count=0;
    int size=array.Length;
    int newSize = size/2;
    int [] multElements=new int [newSize];

     for (int i=0; i<newSize;i++){
        multElements[i]=array[i]*array[size]-count;
        count++;


}
 Console.WriteLine (" ");
for (int i=0; i<multElements.Length;i++){
    Console.Write (multElements[i]+" ");

} }

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
int[] array= CreateRandomArray(size,min,max);
ShowArray(array);
Multiply(array);
