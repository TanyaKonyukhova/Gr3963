//47

Random rnd = new Random();

//функция для вывода массива
void ArrayOutput(double[,] arr, int column, int rown){
    for (int i = 0; i < column; i++){
        for (int j = 0; j < rown; j++){
            Console.Write(arr[i, j] + "   ");
        }
        Console.WriteLine("   ");
    }
}

//функция для заполнения массива
void ArrayCompletion(double[,] arr, int column, int rown){
    for (int i = 0; i < column; i++){
        for (int j = 0; j < rown; j++){
            arr[i, j] = rnd.Next(-100, 100);
        }
    }   
}


//ввод данных
Console.WriteLine("Введите кол-во строк");
int m = int.Parse(Console.ReadLine()??"0");
Console.WriteLine("Введите кол-во столбцов");
int n = int.Parse(Console.ReadLine()??"0");

double[,] arr = new double[m, n];

//заполнение массива
for (int i = 0; i < m; i++){
    for (int j = 0; j < n; j++){
        arr[i, j] = rnd.NextDouble()*40-20;
    }
}

//вывод массива
ArrayOutput(arr, m, n);


//50

//ввод данных
Console.WriteLine("Введите кол-во строк");
int m = int.Parse(Console.ReadLine()??"0");
Console.WriteLine("Введите кол-во столбцов");
int n = int.Parse(Console.ReadLine()??"0");

double[,] arr = new double[m, n];

//заполнение массива
ArrayCompletion(arr, m , n);

//вывод массива
ArrayOutput(arr, m, n);

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine()??"0");
int count = 0;

for (int i = 0; i < m; i++){
    for (int j = 0; j < n; j++){
        
    if (num == arr[i,j]){
        Console.WriteLine($"число на позиции: {i+1}, {j+1}");       
        count ++;
        }
    }
}
if (count == 0){
Console.WriteLine($"такого числа в массиве нет");

}

//52

int c = 3;
int r = 3;
double[,] arr = new double[c, r];

//заполнение массива
ArrayCompletion(arr, c , r);

//вывод массива
ArrayOutput(arr, c, r);

double[] AvgNumbers = new double[arr.GetLength(1)];

for (int i = 0; i < arr.GetLength(1); i++)
{
    double result = 0.0;
    for (int j = 0; j < arr.GetLength(0); j++)
    {
        result += arr[j, i];
    }
    AvgNumbers[i] = result / arr.GetLength(0);
}

//вывод массива
for (int i = 0; i < AvgNumbers.Length; i++){
        Console.Write(AvgNumbers[i] + " ");
    }