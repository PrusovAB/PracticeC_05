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
void PrintArray(int[] array)
{
	for (int i = 0; i < array.Length; i++)
	{
		if(i == 0) Console.Write("[");
		if(i < array.Length - 1) Console.Write(array[i] + ",");
		else Console.Write(array[i] + "]");
	}
}


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

int[] array = CreateArrayRndInd(20,100,999);
PrintArray(array);
Console.WriteLine();
ShowSumPos(array);



