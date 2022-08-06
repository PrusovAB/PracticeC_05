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

int GetDifferMaxMin(int[] array){

	int differMaxMin = 0;
	int max = array[0];
	int min = array[0];

	for (int i = 1; i < array.Length; i++)
	{
		if(array[i] > max)
		{
			max = array[i];
		}
		if(array[i] < min)
		{
			min = array[i];
		}
	}
	differMaxMin = max - min;

	return differMaxMin;

}

// Вызов методов.
int[] array = CreateArrayRndInd(10,0,10); // Задаем массив из 10 элементов,числа рандомные до 10 вкл.
PrintArray(array); 
Console.WriteLine(); 

int differMaxMin = GetDifferMaxMin(array);

Console.WriteLine($" Разницу между максимальным и минимальным элементов массива = {differMaxMin}");