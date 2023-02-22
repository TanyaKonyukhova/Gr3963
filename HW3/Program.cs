//19

Console.Write("Введите пятизначное число ");
string num = Console.ReadLine();
char[] arr = num.ToCharArray();

if (arr[0] == arr[4] & arr[1] == arr[3]){
    Console.WriteLine("это число палиндром");
}else{
    Console.WriteLine("это число не палиндром");
}

//21

//чтение данных
int ReadDate(string message){
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()??"0");
}

//вывод
void PrintDate(string message, double val){
    Console.WriteLine(message + val);
}

//формула
double Function(int x1, int y1, int z1, int x2, int y2, int z2){
    return Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1));
}

//запрос данных
int x1 = ReadDate("Введите координаты x точки А: ");
int y1 = ReadDate("Введите координаты y точки А: ");
int z1 = ReadDate("Введите координаты z точки А: ");
int x2 = ReadDate("Введите координаты x точки B: ");
int y2 = ReadDate("Введите координаты y точки B: ");
int z2 = ReadDate("Введите координаты z точки B: ");

double result = Function(x1, y1, z1, x2, y2, z2);

PrintDate("Результат:", result);


//23

//функция для возведения в куб
int Cube(int meaning){
    meaning = meaning * meaning * meaning;
    return meaning;
}

Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= number; i++){
    Console.Write(Cube(i) + "   ");
}