// Задача 4*. Самостоятельная работа/ Задача со звёздочкой.
// Программа находит произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний эелемент, второй и предпоследний и т.д.
// Результат записываем в новом массиве.

Console.WriteLine (" "); 
Console.WriteLine ("*** Давайте создадим массив из произведений последовательности крайних чисел ***"); 
Console.WriteLine (" ");

// Функция создания и публикации массива из случайных чисел
int [] CreateShowRandomArray0 (int size, int max, int min){
    int [] array0 = new int [size];
    Console.Write("# Массив [ ");
    for (int i = 0; i<size; i++){
        array0[i] = new Random().Next(min,max);
        Console.Write (array0[i] +" ");
    }
    Console.WriteLine ("]");
    return array0;
}
// Функция создания нового массива из произведений крайних последовательных чисел
int [] CreateNewArray (int[] array, int newsize, int size){
    int [] newarray = new int [newsize];
    Console.WriteLine (" ");
    Console.Write("# Массив произведений [ ");
    for (int j = 0; j<newsize; j++){
        newarray[j] = array[j]*array[size-1-j];
        Console.Write (newarray[j] +" ");
    }
    Console.WriteLine ("]");
    return newarray;
}

// Ввод данных // Ограничения количества цифр
Console.Write ("# Введите количество чисел: "); 
int size = Convert.ToInt32(Console.ReadLine());
int newsize = 0;
if (size %2 == 0) newsize = size/2;
else newsize = size/2+1;
Console.Write ("# Введите максимальное число: "); 
int max = Convert.ToInt32(Console.ReadLine());
Console.Write ("# Введите минимальное число: "); 
int min = Convert.ToInt32(Console.ReadLine());
int[] array0 = CreateShowRandomArray0(size, max, min);
Console.WriteLine (""); 
Console.WriteLine ("Новый размер массива " + newsize); 
int[] newarray = CreateNewArray(array0, newsize, size);
Console.WriteLine (" ");



// Урок 5. Домашняя работа. 
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.WriteLine (" "); 
Console.WriteLine ("*** Давайте найдём количество чётных чисел в массиве ***"); 
Console.WriteLine (" ");
// Функция создания и публикации массива из случайных чисел с подсчетом положительных
int [] CreateShowRandomArray (int size1){
    int j=0;
    int [] array = new int [size1];
    Console.Write("# Массив [ ");
    for (int i = 0; i<size1; i++){
        array[i] = new Random().Next(99,1000);
        Console.Write (array[i] +" ");
        if (array[i]%2==0) j++; 
    }
    Console.WriteLine ("]");
    Console.WriteLine ("# Количество четных элементов массива: " +j);
    return array;
}

// Ввод данных
Console.Write ("# Введите количество элементов массива: "); 
int size1 = Convert.ToInt32(Console.ReadLine());
CreateShowRandomArray (size1);
 
// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine (" "); 
Console.WriteLine ("*** Давайте найдём сумму нечётных элементов ***"); 
Console.WriteLine (" ");
// Функция создания и публикации массива из случайных чисел с подсчетом суммы нечётных эелементов 
int [] CreateShowRandomArray2 (int size2, int max2, int min2){
    int sumNeChet = 0;
    int [] array = new int [size2];
    Console.Write("# Массив [ ");
    for (int i = 0; i<size2; i++){
        array[i] = new Random().Next(min2,max2);
        Console.Write (array[i] +" ");
        if (i%2!=0) sumNeChet = sumNeChet  + array[i]; 
    }
    Console.WriteLine ("]");
    Console.Write ("# Сумма нечётных элементов массива: " + sumNeChet);
    Console.WriteLine (" "); 
    return array;
}

// Ввод данных // Ограничения количества цифр
Console.Write ("# Введите количество чисел: "); 
int size2 = Convert.ToInt32(Console.ReadLine());
Console.Write ("# Введите максимальное число: "); 
int max2 = Convert.ToInt32(Console.ReadLine());
Console.Write ("# Введите минимальное число: "); 
int min2 = Convert.ToInt32(Console.ReadLine());
int[] array = CreateShowRandomArray2(size2, max2, min2);

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.WriteLine (" "); 
Console.WriteLine ("*** Давайте найдём разницу между максимальным и минимальным числом массива ***"); 
Console.WriteLine (" ");
// Функция создания и публикации массива из случайных чисел с подсчетом раздници 
int [] CreateShowRandomArray3 (int size3, int max3, int min3){
    int numMax = min3;
    int numMin = max3;
    int [] array3 = new int [size3];
    Console.Write("# Массив [ ");
    for (int i = 0; i<size3; i++){
        array3[i] = new Random().Next(min3,max3);
        Console.Write (array3[i] +" ");
        if (array3[i]>numMax) numMax = array3[i];
        if (array3[i]<numMin) numMin = array3[i]; 
    }
    Console.WriteLine ("]");
    Console.WriteLine ("# Максимальное число: " + numMax);
    Console.WriteLine ("# Минимальное число: " + numMin);
    int res = numMax-numMin;
    Console.WriteLine ("# Разница равна: " + res);
    Console.WriteLine (" ");
    return array3;
}

// Ввод данных // Ограничения количества цифр
Console.Write ("# Введите количество чисел: "); 
int size3 = Convert.ToInt32(Console.ReadLine());
if (size3 <= 0) Console.Write ("# Неверные условия ввода");
else {
Console.Write ("# Введите максимальное число: "); 
int max3 = Convert.ToInt32(Console.ReadLine());
Console.Write ("# Введите минимальное число: "); 
int min3 = Convert.ToInt32(Console.ReadLine());
int[] array3 = CreateShowRandomArray3(size3, max3, min3);
}
