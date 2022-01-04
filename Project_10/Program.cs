// Работа с файлами и строками

// // РАБОТА СО СТРОКАМИ
//СТРОКИ - это МАССИВЫ
//задали переменную с типом данных string(строка) - равносильно массиву с элементами из символов тип даных char[] sym = {"H", "e", "l", "l", "o"}
string word = "Hello ";  
Console.WriteLine(word); // выводим на консоль введенный текст

word += "world"; //добавляет символы в конец
Console.WriteLine(word); // выводим на консоль дополненный текст

word = String.Concat(word, "!!!"); // дополнение текста с помощью функции String.Concat
Console.WriteLine(word); // выводим на консоль дополненный текст


Console.WriteLine(word[1]); //выводим на консоль символ с индексом 1 = "e"
Console.WriteLine(word.Length); //выводим на консоль количество символов

string people = "Alex,Bob,John"; //задали строку, имена записали слитно через запятую

//переводим строку в массив функцией Split, в скобках указываем тип массива char, в фигурных скобках п какому символу разделяем
string[] names = people.Split(new char[]{','});
foreach(string el in names)
	Console.WriteLine(el);

//объединяем в строку символы с разбиением через пробел функцией Join
people = String.Join(" ", names);
Console.WriteLine(people);

//Функция Trim  позволяет удалить лишние пробелы строки
Console.WriteLine(word.Trim());
//Функция Substring обрезает в начале строки указаное количество символов
Console.WriteLine(word.Substring(0, word.Length - 1)); // последний символ, еслибы например было в скобках указано просто (2), то удалились бы два первых символа


// // РАБОТА С ФАЙЛАМИ

Console.WriteLine("Введите текст: ");
string text = Console.ReadLine();

using(FileStream stream = new FileStream("info.txt", FileMode.OpenOrCreate))
{
	byte[] array = System.Text.Encoding.Default.GetBytes(text);
	stream.Write(array, 0,array.Length);
}

//считывает текст с файла и выводит на консоль
Console.WriteLine("считывает текст с файла и выводит на консоль");

using(FileStream stream1 = File.OpenRead("info.txt"))
{
	byte[] array = new byte[stream1.Length];
	stream1.Read(array, 0, array.Length);

	string textFormFile = System.Text.Encoding.Default.GetString(array);
	Console.WriteLine(textFormFile);
}
