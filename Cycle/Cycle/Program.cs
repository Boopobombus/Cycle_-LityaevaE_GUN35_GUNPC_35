{
    int[] num = new int[8];
    num[0] = 0;
    num[1] = 1;
    Console.WriteLine(num[0]);
    Console.WriteLine(num[1]);
    int k = 0;
    
        for (int i = 2; i < num.Length; i++)
        {
            num[i] = num[i - 1] + num[i - 2];

        }
    
    while ( k < num.Length)
{
        Console.WriteLine(num[k]);
        k++;
    }
}

Console.WriteLine();


for (int i =2; i < 21; i++)
{
    if (i % 2 == 0)
    {
        Console.Write(i+", ");
    }
    else
    {
        continue;
    }
}

Console.WriteLine();

int[,] a = new int[5, 5];
for (int i = 1;  i < 6; i++)
{ for (int j = 1; j < 6; j++)
    {
        if (i<6)
        {
            int x = i * j;
            Console.WriteLine($"{i} * {j} = {x}");
                }
    }
 }

Console.WriteLine();

string password = "qwerty";
do
{
    Console.Write("Enter the password: ");
    password = Console.ReadLine();
}
while (password != "qwerty");
{  Console.WriteLine("OK"); }
