//64

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;
NaturalToLow(number, count);


void NaturalToLow(int n, int count){
    if (count > n){
        return;
    }
    else{
        NaturalToLow(n, count + 1);
        Console.Write(count + " ");
    }
}

//66

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

SumFromMToN(m, n);

//Вызов фуекции суммы
void SumFromMToN(int m, int n){
    Console.Write(SumMN(m - 1, n));
}

//Сумма чисел
int SumMN(int m, int n){
    int res = m;
    if (m == n)
        return 0;
    else{
        m++;
        res = m + SumMN(m, n);
        return res;
    }
}

//68

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write(Akkerman(m, n)); 

//функция Аккермана
int Akkerman(int m, int n){
    if (m == 0){
        return n + 1;
    }
    else if (n == 0 && m > 0){
        return Akkerman(m - 1, 1);
    }
    else{
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}