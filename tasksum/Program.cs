//Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
//4; массив [6, 7, 19, 345, 3] -> нет
//-3; массив [6, 7, 19, 345, 3] -> да





Console.WriteLine("Enter the massive size ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Найти число массива? ");
int x = Convert.ToInt32(Console.ReadLine());
bool z = false;
int[] massive =new int[size];
for(int i = 0; i < massive.Length; i++)
    {
        massive[i] = new Random().Next(-100,1000);
        if(massive[i] == x) z = true; //Console.WriteLine("ДА ");
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
if (z) Console.WriteLine("yes");
else Console.WriteLine("no ");

/*другие примеры кода
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите искомое число");
int search=Convert.ToInt32(Console.ReadLine());

int[] massive = new int[size];

for(int i = 0; i < massive.Length; i++)
    {
        massive[i] = new Random().Next(0,5);
        if(massive[i]==search)
        {
        Console.WriteLine("индекс искомого числа в массиве i=" + i +" и равно " + massive[i]);
        }
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
*/



/*другие примеры кода
Console.WriteLine("Введите размерность массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Какое число необходимо найти? ");
int x = Convert.ToInt32(Console.ReadLine());
bool z = false;
int[] massive = new int[size];
for(int i = 0; i < massive.Length; i++)
    {
        massive[i] = new Random().Next(-9,10);
        if (massive[i] == x) z = true;
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
Console.WriteLine();
if (z) Console.WriteLine("ДА");
else Console.WriteLine("НЕТ");
*/








