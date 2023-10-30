using project1_SDT;

Console.WriteLine("Практическая работа №1");
Thread.Sleep(1000);

Console.WriteLine();
Console.WriteLine("Транспонирование квадратной матрицы");

Thread.Sleep(1000); 
Console.WriteLine();

Console.Write("Введите размер квадратной матрицы: ");

int sizeMatrix = int.Parse(Console.ReadLine());

Console.WriteLine();

Console.WriteLine("Создание и заполнение матрицы...");

for (int i = 0; i < 2; i++)
{
    Console.WriteLine("...");
    Thread.Sleep(1000);
}

Console.WriteLine();

Console.WriteLine("Исходная матрица: ");

Console.WriteLine();

double[,] matrix = Matrix.CreateMatrix(sizeMatrix);
Matrix.FillMatrix(matrix);

Matrix.ShowMatrix(matrix);

Console.WriteLine();

link1:

Console.WriteLine("Транспонировать матрицу? (да/нет)");
Console.WriteLine();

string userResponse = Console.ReadLine();
userResponse = userResponse.ToLower();

if(userResponse == "да")
{
    Console.WriteLine();
    Console.WriteLine("Транспонирование матрицы...");

    for (int i = 0; i < 2; i++)
    {
        Console.WriteLine("...");

        Thread.Sleep(1000);
    }

    Console.WriteLine("нет");

    Thread.Sleep(10000);

    Console.WriteLine();

    Console.WriteLine("Транспонированная матрица: ");

    matrix = Matrix.TranspanentMatrix(matrix);

    Console.WriteLine();

    Matrix.ShowMatrix(matrix);

    Console.WriteLine();

}
else
{
    Console.WriteLine("НЕПРАВИЛЬНЫЙ ОТВЕТ!!!!");
    Console.WriteLine();
    goto link1;
}
