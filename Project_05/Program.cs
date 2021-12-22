//Оператор «Switch-case» ( в отличии от if-else проверяет всего одну пременную на возможные варианты)
using System; 

namespace project { 
    class Program { 
        static void Main() { 
        short user_input = Convert.ToInt16(Console.ReadLine());
        switch (user_input) { //проверяю переменную 
            case 5: //если переменная равна значению 5
                Console.WriteLine("Число 5"); //выполняется следующее условие - в данном случае выводится на консоль сообщение
                break; //завершение условия
            case 15: 
                Console.WriteLine("Число 15"); 
                break; 
            default: //включается, если не сработали кейсы case, аналог else
                Console.WriteLine("Число не подходит под наш вариант"); 
                break; 

        }

        }
    }
}
