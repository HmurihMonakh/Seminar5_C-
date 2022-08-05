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

Console.WriteLine("Enter the massive size ");

int size = Convert.ToInt32(Console.ReadLine());

int[] massive =new int[size];
int sumN = 0;
int sumP = 0;

for(int i = 0; i < massive.Length; i++)
    {
        massive[i] = new Random().Next(-9,10);

    }

PrintArray(massive);
for(int i = 0; i < massive.Length; i++) massive[i] *= -1;



System.Console.WriteLine();
Console.WriteLine();



