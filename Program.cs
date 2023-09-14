class Program
{
	public static int[,] Mass(int x,int y)
	{
		int[,] array = new int[x,y];
		Random random = new Random();
		for (int i = 0; i < array.GetLength(0); i++)
			for (int j = 0; j < array.GetLength(1); j++)
			{

				{
					array[i,j] = random.Next(0, 10);
				}
			}
		return array;
		
	}
	public static int[,] Proizveden(int[,]num1, int[,]num2)
	{
		int[,]result=new int[2,2];
		for (int i = 0; i < num1.GetLength(0); i++)
		{
			for (int j = 0; j < num1.GetLength(1); j++)
			{
				result[i, j] = (num1[i, 0] * num2[0, j] + num1[i, 1] * num2[1,j]);
				
			}
		}
		return result;
	}
	public static void print(int[,]array)
	{
		for (int i=0;i<array.GetLength(0);i++)
		{
			Console.WriteLine("\n");
			for(int j=0;j<array.GetLength(1);j++)
			{
				Console.Write(array[i, j] + "\t");
			}
			
		}
		Console.WriteLine("\n");
	}
	public static void Zadanie_58 ()
	{
		Console.WriteLine("Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.");
				int[,] array1 = Mass(2,2);
				int[,] array2 = Mass(2,2);
				Console.WriteLine("Матрица 1");
				print(array1);
				Console.WriteLine("Матрица 2");
				print(array2);
				Console.WriteLine("Решение");
				print(Proizveden(array1 , array2));
	}
	public static int[,] ArrayDelit(int[,] array, int[,] position)
	{
		int[,] arrayWithoutLines = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
		int k = 0, l = 0;
		for (int i = 0; i < array.GetLength(0); i++)
		{
			for (int j = 0; j < array.GetLength(1); j++)
			{
				if (position[0, 0] != i && position[0, 1] != j)
				{
					arrayWithoutLines[k, l] = array[i, j];
					l++;
				}
			}
			l = 0;
			if (position[0, 0] != i)
			{
				k++;
			}
		}
		return arrayWithoutLines;
	}
	public static int[,] FindPositionSmallElement(int[,] array, int[,] position)
	{
		int temp = array[0, 0];
		for (int i = 0; i < array.GetLength(0); i++)
		{
			for (int j = 0; j < array.GetLength(1); j++)
			{
				if (array[i, j] <= temp)
				{
					position[0, 0] = i;
					position[0, 1] = j;
					temp = array[i, j];
				}
			}
		}
		Console.WriteLine($"\nMинимальный элемент: {temp}");
		return position;
	}

	public static void Zadanie_59()
	{
		Console.WriteLine("Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.");
				int num1 = Convert.ToInt32(Console.ReadLine());
				int num2 = Convert.ToInt32(Console.ReadLine());
				int[,] array = Mass(num1,num2);
				print(array);
		
		int[,] positionSmallElement = new int[1, 2];
		positionSmallElement = FindPositionSmallElement(array, positionSmallElement);
		Console.Write($"Позиция элемента: \n");
		print(positionSmallElement);
		Console.Write("Итоговый массив: ");
		print(ArrayDelit(array,positionSmallElement));
		


	}
	public static void Zadanie_62()
	{
		Console.WriteLine("Напишите программу, которая заполнит спирально массив 4 на 4.");
		int[,] array = new int[4, 4];
		
		int temp = 1;
		int i = 0;
		int j = 0;

		while (temp <= array.GetLength(0) * array.GetLength(1))
		{
			array[i, j] = temp;
			temp++;
			if (i <= j + 1 && i + j < array.GetLength(1) - 1)
				j++;
			else if (i < j && i + j >= array.GetLength(0) - 1)
				i++;
			else if (i >= j && i + j > array.GetLength(1) - 1)
				j--;
			else
				i--;
		}
		
		print(array);

		
	}



	public static void Main ()
	{
		
		int numzad = Convert.ToInt32(Console.ReadLine());
		
		switch (numzad)
			{
			case 58:
				{
					Zadanie_58();
				}
				break;
			case 59:
				{
					Zadanie_59();
				}
				break;
			case 62:
				{
					Zadanie_62();
				}
				break;
		}
	}
}
