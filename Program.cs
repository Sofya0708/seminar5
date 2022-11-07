//Заменить в массиве положительные элементы на отрицательные

/*int[] array = GetArray(12, -9, 9);
Console.WriteLine(String.Join(",", array));

for (int i = 0; i < array.Length; i++)
{
   array[i] = array[i] * -1;
}

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

Console.WriteLine(String.Join(",", array));*/

//Определить, присутствует ли данное число в массиве

/*Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
int count = 0;

int[] array = GetArray(12, -9, 9);
Console.WriteLine(String.Join(",", array));

for (int i = 0; i < array.Length; i++){
    if (a == array[i])
    {
        count++;
    }
    }
if (count == 0)
{
    Console.WriteLine($"Числа {a} нет в массиве!");
}
else
{
    Console.WriteLine($"Число {a} есть в массиве!");
}


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}*/




//Задать одномерный массив из 123х случайных чисел, 
//найти количество элементов массива в отрезке от 10 до 99. 

/*int minV = 10;
int maxV = 99;
int[] array = GetArray(123, 0, 200);

Console.WriteLine(String.Join(",", array));

Console.WriteLine($"Количество элементов в промежутке от {minV} до {maxV} равно {findCV(minV, maxV)}");

int findCV(int minV, int maxV){
    int count = 0;
foreach (int el in array)
{
    if (el >= minV && el <= maxV)
    {
        count++;
    }
}
return count;
}

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}
*/

//Найдите произведение пар чисел в одномерном массиве. Результат в новом массиве.



/*int[] array = GetArray(10, 0, 10);

void resultArray(){ 

}



int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}*/









//ДОМАШНЕЕ ЗАДАНИЕ ------------------------------------------------------------------------------------------------------------------------------------------









//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

/*int[] collection = GetArray(10, 100, 999);
Console.WriteLine(String.Join(",", collection));

int count = 0;

foreach (var item in collection)
{
    if (item % 2 == 0)
    {
        count = count + 1;
    }
}

Console.WriteLine($"Количество чётных чисел в массиве: {count}");

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}*/









//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

/*int[] array = GetArray(4, 0, 30);
Console.WriteLine(String.Join(",", array));
int sum = 0;

foreach (var item in array)
{
    if (item % 2 == 1)
    {
        sum = sum + item;
    }
}

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}
Console.WriteLine($"{sum} - сумма нечётных чисел в массиве");*/












//Задача 38: Задайте массив вещественных чисел
//(просто от минус бесконечности, до плюс бесконечности, с дробными не работаем). Найдите разницу между максимальным и минимальным элементов массива.

//Вот тут застопорилась, долго не получалось, смотрела разбор из 6 семинара, сейчас всё понятно

/*int[] array = GetArray(4, 1, 30);//эта строка нужна для определения метода, которым задаём массив?
Console.WriteLine(String.Join(",", array));
Console.WriteLine($"Разница = {diff(array)}");// правильно, что тут не получится в {} указать min max, так как они объявлены позже?

int diff(int[] array){
    int min = array[0];
    int max = array[0];
    foreach (var i in array){
    if (i < min) min = i;
    if (i > max) max = i;
    }
    return max - min;
}

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}*/