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

int GetSumNegItem(int[] array){

	int sumItems = 0;

	for (int i = 1; i < array.Length; i++)
	{
		if (i % 2 != 0){
			sumItems += array[i];
		}
	}
	return sumItems;
}

// Вызов методов.
int[] array = CreateArrayRndInd(10,0,10); // Задаем массив из 10 элементов,числа рандомные до 10 вкл.
PrintArray(array); 
Console.WriteLine(); 

int sumItems = GetSumNegItem(array);

Console.WriteLine($"Сумма не четных элементов массива = {sumItems}");