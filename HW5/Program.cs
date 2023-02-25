//34

Random rnd = new Random();
int[] arr = new int[5];
int count = 0;

//наполнение массива
for (int i = 0; i < 5; i++){
    arr[i] = rnd.Next(100, 1000);
    Console.Write(arr[i] + "    "); 
}

for (int i = 1; i < arr.Length; i++){
    if (arr[i] % 2 == 0){
        count++;
    }
}

Console.Write($"Четных чисел: {count}");

//36

int[] num = new int[5];
int sum = 0;

//наполнение массива
for (int i = 0; i < 5; i++){
    num[i] = rnd.Next(101);
    Console.Write(num[i] + "    "); 
}

for (int i = 0; i < num.Length; i+=2){
    sum += num[i];
}

Console.Write($"Сумма: {sum}");

//38

int[] numbers = new int[5];
int max = 0;

//наполнение массива
for (int i = 0; i < 5; i++){
    numbers[i] = rnd.Next(101);
    Console.Write(numbers[i] + "    "); 
}

for (int i = 0; i < numbers.Length; i++){
    if(numbers[i] > max){
        max = numbers[i];
    }
}

int min = numbers[0];

for (int i = 0; i < numbers.Length; i++){
    if(numbers[i] < min){
        min = numbers[i];
    }
}
Console.Write($"Разница: {max-min}");