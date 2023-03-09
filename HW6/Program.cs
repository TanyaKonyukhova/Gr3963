//41

//ввод кол-ва повторений  
Console.WriteLine("Сколько чисел Вы хотите ввести? ");
int quantity = Convert.ToInt32(Console.ReadLine());
int count = 0;

//цикл на ввод и проверку
for(int i = 0; i < quantity; i++){

    Console.WriteLine("Введите число ");
    int number = Convert.ToInt32(Console.ReadLine());

    if (number > 0){
        count++;
    }
}

//результат
Console.WriteLine("Всего " + count + " положительных чисел");

//43

//ввод переменных
Console.WriteLine("Введите значение b1 ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение k1 ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение b2 ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение k2 ");
int k2 = Convert.ToInt32(Console.ReadLine());

double x = -(b1 - b2) / (k1 - k2);
double y = k1 * x + b1;

Console.Write($"Точка пересечения: [{x},{y}]");
