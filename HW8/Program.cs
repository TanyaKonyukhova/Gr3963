//54

int[,] table = new int[3, 4];
ArrayCompletion(table);
ArrayOutput(table);
SortToLower(table);
Console.WriteLine();
ArrayOutput(table);


//Заполнение массива
void ArrayCompletion(int[,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            array[i, j] = new Random().Next(1, 100);
        }
    }
}

//Сортировка элементов по убыванию
void SortToLower(int[,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            if (array[i, j] < array[i, j + 1]){
                int temp = array[i, j + 1];
                array[i, j + 1] = array[i, j];
                array[i, j] = temp;
                
            }
        }
    }
}

//Вывода массива
void ArrayOutput(int[,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

//56

int[,] table = new int[3, 4];
ArrayCompletion(table);
ArrayOutput(table);
Console.WriteLine();
NumberRowMinSumElements(table);


//Функция для вывода номера строки с наименьшей суммой элементов 
void NumberRowMinSumElements(int[,] array){
    int minRow = 0;
    int minSumRow = 0;
    int sumRow = 0;
    for (int i = 0; i < table.GetLength(1); i++){
        minRow += table[0, i];
    }
    for (int i = 0; i < table.GetLength(0); i++){
        for (int j = 0; j < table.GetLength(1); j++) sumRow += table[i, j];
        if (sumRow < minRow){
            minRow = sumRow;
            minSumRow = i;
        }
        sumRow = 0;
    }
    Console.Write($"{minSumRow + 1} строка");
}


//58
Console.WriteLine("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()??"0");
Console.WriteLine("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()??"0");
int[,] array = new int[rows, columns];
int[,] secondArray = new int[rows, columns];
int[,] resultArray = new int[rows, columns];

ArrayCompletion(array);
ArrayOutput(array);

Console.WriteLine();

ArrayCompletion(secondArray);
ArrayOutput(secondArray);

Console.WriteLine();

if (array.GetLength(0) != secondArray.GetLength(1)){
    Console.WriteLine(" Нельзя перемножить ");
    return;
}
for (int i = 0; i < array.GetLength(0); i++){
    for (int j = 0; j < secondArray.GetLength(1); j++){
        resultArray[i, j] = 0;
        for (int k = 0; k < array.GetLength(1); k++){
            resultArray[i, j] += array[i, k] * secondArray[k, j];
        }
    }
}

ArrayOutput(resultArray);


//60

int[,,] array3D = new int[2, 2, 2];
FillArray(array3D);
PrintIndex(array3D);


//Функция для  индексов
void PrintIndex(int[,,] arr){
    for (int i = 0; i < array3D.GetLength(0); i++){
        for (int j = 0; j < array3D.GetLength(1); j++){
            Console.WriteLine();
            for (int k = 0; k < array3D.GetLength(2); k++){
                Console.Write($"{array3D[i, j, k]}({i},{j},{k}) ");
            }
        }
    }
}

//Заполнение 3D массива не повторяющимеся числами
void FillArray(int[,,] arr){
    int count = 10;
    for (int i = 0; i < arr.GetLength(0); i++){
        for (int j = 0; j < arr.GetLength(1); j++){
            for (int k = 0; k < arr.GetLength(2); k++){
                arr[k, i, j] += count;
                count += 3;
            }
        }
    }
}


//62

int len = 4;
int[,] table = new int[len, len];
FillArraySpiral(table, len);
ArrayOutput(table);


//Заполнения массива по спирали
void FillArraySpiral(int[,] array, int n){
    int i = 0, j = 0;
    int value = 1;
    for (int e = 0; e < n * n; e++){
        int k = 0;
        do { array[i, j++] = value++; } while (++k < n - 1);
        for (k = 0; k < n - 1; k++) array[i++, j] = value++;
        for (k = 0; k < n - 1; k++) array[i, j--] = value++;
        for (k = 0; k < n - 1; k++) array[i--, j] = value++;
        ++i; ++j;
        n = n < 2 ? 0 : n - 2;
    }
}