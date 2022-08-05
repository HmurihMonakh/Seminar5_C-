//Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива,
// значения которых лежат в отрезке [10,99]. 
//Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
//[5, 18, 123, 6, 2] -> 1
//[1, 2, 3, 6, 2] -> 0
//[10, 11, 12, 13, 14] -> 5

Console.WriteLine("Ведите массив ");
int size = Convert.ToInt32(Console.ReadLine());
int[] massive =new int[size];
int count = 0;
bool z = false;
for(int i = 0; i < size; i++)
    {
        massive[i] = new Random().Next(0,200);
        if(massive[i] >9 && massive[i]<100 ) z = true; //Console.WriteLine("ДА ");
    }
void PrintArray(int[] col)
    {
        int count = col.Length;
        int position = 0;
        while (position < count)
            {
                Console.Write($"{col[position]} ");
                position++;
            }
    }
PrintArray(massive);

System.Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Количество элементов [10 - 99] - " + count);

/*
Задайте одномерный массив из случайных чисел. Найдите количество отрезков массива, 
значения которых лежат в отрезке [10,99].


static void PrintArray(int[] col)
    {
        int count = col.Length;
        int position = 0;
        while (position < count)
        {
            Console.Write($"{col[position]} ");
            position++;
        }
    }

    static void Main(string[] args)
    {
        Console.Write("Введите размерность массива: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[n];
        int y = 0;
        bool z = false;
        bool zold = false;
        for (int i = 0; i < n; i++)
        {
            array[i] = new Random().Next(0, 124);
            zold=z;
            if (array[i] > 9 && array[i] < 100) z=true;
            else z=false;
            if (zold==false && z==true) y=y+1;
            else zold=true;
        }
        PrintArray(array);
        Console.WriteLine("");
        Console.WriteLine("Кол-во отрезков в массиве - " + y);
    }
}
*/

//Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3
//[6 7 3 6] -> 36 21










