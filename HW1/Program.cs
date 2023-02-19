//№1
      
// ввод данных
Console.WriteLine("Введите первое число");
int number_1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number_2 = Convert.ToInt32(Console.ReadLine());
int max;
    
//проверка
if (number_1 > number_2){
    max = number_1;
    Console.WriteLine($"max = {max}");
}else{
    max = number_2;
    Console.WriteLine($"max = {max}");
}

//№2
      
// ввод данных
Console.WriteLine("Введите первое число");
int num_1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num_2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int num_3 = Convert.ToInt32(Console.ReadLine());

//проверка
if (num_1 > num_2){
if (num_1 > num_3){
    max = num_1;
    Console.WriteLine($"max = {max}");
}else{
    max = num_3;
    Console.WriteLine($"max = {max}");
}
}else{
    if (num_2 > num_3){
        max = num_2;
        Console.WriteLine($"max = {max}");
    }else{
        max = num_3;
        Console.WriteLine($"max = {max}");
    }
}   

//№3
      
// ввод данных
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
    
//проверка на четность
if (number % 2 == 0){
    Console.WriteLine("Число четное");
}else{
    Console.WriteLine("Число нечетное");
}

//№4

// ввод данных
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int i =1;


//цикл на вывод четных чисел
while (i < num+1){
    
    if (i % 2 == 0){
        Console.WriteLine(i);
    }
    
    i +=1;

}
