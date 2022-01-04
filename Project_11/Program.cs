// // Обработчик исключений. Оператор try-catch

//Пример 1
try 
{
	//диапозон для отслеживания - в нашем случае если пользователь ввел не целое число, например буквы
	int num = Convert.ToInt32(Console.ReadLine());
	Console.WriteLine(num);
}
catch(FormatException) // что именно отслеживаем
{
	Console.WriteLine("Вы ввели не тот формат!");
}

//Пример 2
try
{
	int a, b, res;
	Console.Write("Введите первое число ");
	a = Convert.ToInt32(Console.ReadLine());
	Console.Write("Введите второе число ");
	b = Convert.ToInt32(Console.ReadLine());
	res = a / b;
	Console.WriteLine("Результат " + res);
}
catch(DivideByZeroException) //отслеживаем ноль
{
	Console.WriteLine("Деление на ноль!");
}
catch(FormatException) // отслеживаем символы
{
	Console.WriteLine("Вы ввели не тот формат!");
}
finally //закрытие отслеживания
{
	//можно написать любой код
}
