// Метот CreateArrayRndInd создает случайный массив цифр, 
// которые указал пользователь,
// размер массива, максимальное и минимальное значения чисел массива.

int[] CreateArrayRndInd (int size, int min, int max)
{
	int[] arr = new int[size];
	Random rnd = new Random();
	
	for(int i = 0; i < arr.Length; i++)
	{
		arr[i] = rnd.Next(min,max + 1);
	}

	return arr;
}

// Метот PrintArray выводит на экран созданый случайный массив

void PrintArray(int[] array)
{
	for (int i = 0; i < array.Length; i++)
	{
		if(i == 0) Console.Write("[");
		if(i < array.Length - 1) Console.Write(array[i] + ",");
		else Console.Write(array[i] + "]");
	}
}

// Метод ShowSumPos показывает колличество положительных чисел в массиве


void ShowSumPos (int[] array)
{
	int sum = 0;

	for (int i = 0; i < array.Length; i++)
	{
		if(array[i] % 2 == 0){
			sum++;
		}
	}
	Console.WriteLine($"В данном массиве количество четных чисел = {sum} ");
}

// Вызов методов.
int[] array = CreateArrayRndInd(20,100,999); // Задаем массив из 20 элементов,числа рандомные трехзначные
PrintArray(array); 
Console.WriteLine(); 
ShowSumPos(array); 



