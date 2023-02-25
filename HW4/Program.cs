//25

int result = 1;

//метод возведения в степень
int M_Degree(int number, int degree){
        for (int i = 1; i <= degree; i++){
        result = number * result;
    }
    return result;
}

//метод сложения
int M_Addition(int number_1, int number_2){
        int result = number_1 + number_2;
    return result;
}

//метод вычитания
int M_Subtraction(int number_1, int number_2){
    int result = number_1 - number_2;
    return result;
}

//метод умножения
int M_Multiplication(int number_1, int number_2){
    int result = number_1 * number_2;
    return result;
}

//метод деления
double M_Division(int number_1, int number_2){
    int result = number_1 / number_2;
    return result;
}

//метожд ввода числа
int M_Input(){
    Console.Write("Введите число ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

//ввод значений
Console.Write(" 1 - сложение\n 2 - вычетание\n 3 - умножение\n 4 - деление\n 5 - возведение в степень\n");
Console.WriteLine(" Введите номер операции ");
int number_operation = Convert.ToInt32(Console.ReadLine());
int number;


if (number_operation > 0 & number_operation < 6){
    if (number_operation == 1){
        number = M_Input();
        int number_2 = M_Input();
        Console.Write($"Результат: {M_Addition(number, number_2)}");
    }
    if (number_operation == 2){
        number = M_Input();
        int number_2 = M_Input();
        Console.Write($"Результат: {M_Subtraction(number, number_2)}");
    }
    if (number_operation == 3){
        number = M_Input();
        int number_2 = M_Input();
        Console.Write($"Результат: {M_Multiplication(number, number_2)}");
    }
    if (number_operation == 4){
        number = M_Input();
        int number_2 = M_Input();
        Console.Write($"Результат: {M_Division(number, number_2)}");
    }
    if (number_operation == 5){
        number = M_Input();
        int degree = M_Input();
        Console.Write($"Результат: {M_Degree(number, degree)}");
    }
}else{
    Console.Write("Некорректный ввод");
}


//27

//подсчет цифр
int Number_Len(int number){
    int index = 0;
    while (number > 0){
        number /= 10;
        index++;
    }
    return index;
}

// подсчет суммы цифр
void Sum_Numbers(int number, int len){
    int sum = 0;
    for (int i = 1; i <= len; i++){
        sum += number % 10;
        number /= 10;
    }
    Console.WriteLine(sum);
}

Console.Write("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());

int len = Number_Len(num);
Sum_Numbers(num, len);


//29

Console.Write("Введите длину массива ");
int length = Convert.ToInt32(Console.ReadLine());
int[] nums = new int[length];

for (int i = 0; i < length; i++){
    Console.Write("Введите построчно массив ");
    nums[i] = Convert.ToInt32(Console.ReadLine());
}

for (int i = 0; i < length; i++){
    Console.Write(nums[i]+" ");
}


Random rnd = new Random();

Console.Write("Введите три имени через запятую ");
string name = Console.ReadLine()??"0";
string[] names = new string[3];
names = name.Split(", ");

Console.Write($"Случайное имя: {names[rnd.Next(1, 3)]}");