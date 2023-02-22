//10
Console.Write("Введите трехзначное число ");
int num = Convert.ToInt32(Console.ReadLine());

//проверка

if (num > 999 || num < 99){
    Console.Write("Некорректный ввод \n");
}else{
    Console.Write($"{num / 10 % 10} \n");
}

//13

Console.Write("Введите число ");
string number = Console.ReadLine();
char[] arr = number.ToCharArray();

//проверка

if (arr.Length > 2){
    Console.Write($"{arr[2]} \n");
}else{
    Console.Write("Третьей цифры нет \n");
}

//15

//ввод переменых
Console.Write("Введите номер дня недели ");
int day = Convert.ToInt32(Console.ReadLine());

var DayWeek = new Dictionary<int, string>()
{
    [1] = "Нет",
    [2] = "Нет",
    [3] = "Нет",
    [4] = "Нет",
    [5] = "Нет",
    [6] = "Да",
    [7] = "Да"
};

//проверка

if (day > 7 || day < 1){
    Console.Write("Некорректный ввод");
}else{
    Console.Write(DayWeek[day]);
}

