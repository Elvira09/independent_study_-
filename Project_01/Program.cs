using System; //Блок подключения библиотеки

namespace project { //Пространство имен с названием папки
    class Program {  //Основной класс программы
        static void Main() { //Главный метод программы (точка входа)
            /*
            Огромный комментарий
            В НЕСКОЛЬКО СТРОК
            */
            Console.WriteLine("Hello 1"); // выводит текст в консоль С НОВОЙ строки
            Console.Write("Hello 2"); // выводит текст в консоль В ОДНУ строку
            Console.Write("Hello 3");
            Console.Write("Hello 4\n\n"); // '\n' - вариант вывода текста с новой строки при использовании Write
            Console.Write("Hello 5");
            Console.WriteLine("Hello 6");
            Console.ReadKey(); // Метод получение данных от пользователя из терминала ЛИШЬ ОДНОГО СИМВОЛА
            Console.ReadLine(); // Метод получение данных от пользователя из терминала МНОГО СИМВОЛОВ
        }
    }
}
