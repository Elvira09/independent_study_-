//Цикл for, while и do while. Операторы циклов
using System; 

namespace project { 
    class Program { 
        static void Main() { 
        
    //Цикл for (для)- используются числовые типы данных, а переменные принято обозначать одной буквой
        //Пример 1
        Console.WriteLine("Пример 1");

        for (byte i = 0; i <= 10; i++ ) { //присваиваем переменной значение 0, выполняем условие i меньше или равно 10, далее переменную увеличиваем на единицу
            Console.WriteLine("Элемент: {0}", i); //на консоль выводятся все элементы подряд пока условие не выполнится
            //можно прописать несколько строчек кода
        }  

        //Пример 2
        Console.WriteLine("Пример 2");

        for(short c = 0; c < 8; c++) {
            if(c > 5) //если переменная бошльше 5
                break; //операция выхода из цикл
            Console.WriteLine("Элемент: {0}", c);
        }

        //Пример 3
        Console.WriteLine("Пример 3");

        for(short d = 0; d < 10; d++) {
            if(d % 2 == 0) //если переменная деленная на два (четное число) равно 0
                continue; //операция пропускает/игнорирует значение , соответствующее условию выше
            Console.WriteLine("Элемент: {0}", d);
        }

    //Цикл while(пока) - если условие не верное, то цикл выполняться не будет
        //Пример 4
        Console.WriteLine("Пример 4");

        int a = 0; //вводим переменную
        while(a < 10) { //в скобках указывается только одно условие
        Console.WriteLine("Элемент: {0}", a);
            a++; //указываем какое действие нужно сделать с переменной
        }
        
        //Пример 5
        Console.WriteLine("Пример 5");

        bool isHasCar = true; //ввели переменную
        while(isHasCar) { //задали умсловие isHasCar - истина
            Console.WriteLine("Введите синоним слова окончание");
            string end = Console.ReadLine(); //ввели новую переменную с данными от пользователя
            if(end == "end") { //задали дополнительное условие для выполнения
                isHasCar = false; //при выполнение у3словия переменная isHasCar принимает значение false
            }
        }
        Console.WriteLine("Вы ввели нужное слово");

//Цикл  do while (делай пока) - цикл 100% выполнпится один раз, а потом уже проверит условие: если условие не верное больше выполняться не будет, а если верное - будет выполняться еще
        //Пример 6
        Console.WriteLine("Пример 6");

        byte b = 100; //задали переменную равную 100
        do { //делай
           Console.WriteLine("Элемент: {0}", b); //выводи в консоль переменную
        } while (b < 10); //пока выполняется условие

        }
    }
}