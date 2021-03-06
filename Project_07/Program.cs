// Массивы данных. Одномерные и многомерные
using System; 

namespace project { 
    class Program { 
        static void Main() { 
//Все элементы массива должны быть одного типа данных
    //ОДНОМЕРНЫЕ МАССИВЫ:

        //Пример 1
        Console.WriteLine("Пример 1");

        byte[] nums = new byte[5]; //'byte' - тип данных, '[]' - показываем что создаем массив, 'nums' - название массива, 'new' - обязательно прописываем, указываем тип данных в массиве, '[5]' - резервируем память под количество элементов массива равное 5 
        nums[0] = 250; //присваиваем первому элементу массива (индекс 0) значение 250
        nums[1] = 50;  //присваиваем второму элементу массива (индекс 1) значение 50
        nums[2] = 20;
        nums[3] = 100;
        nums[4] = 25;
        for(byte i = 0; i < nums.Length; i++) {
            Console.WriteLine("Выводим элементs массива  :  " + nums[i]); //выводим в консоль элементs массива 
        } 
        
        //Пример 2
        Console.WriteLine("Пример 2");

        string[] words = new string [] {"Маша", "Ваня", "Петя"};//в фигурных скобках '{}' сразу указали элементы массива
        for(byte i = 0; i < words.Length; i++) {
            Console.WriteLine("Выводим элементs массива  :  " + words[i]); //выводим в консоль элементs массива 
        }

        //Пример 3
        Console.WriteLine("Пример 3");

        short[] numbers = new short[10];
        short summa = 0;
        //класса Random - случайные числа
        Random random = new Random(); //создаем объект 'random' на основе класса Random (случайные числа) и выделяем память под класс Rendom
        for(byte i = 0; i < numbers.Length; i++) {            
            //функция Next - указывает на диапозон чисел от минимума к максимому
            numbers[i] = Convert.ToInt16(random.Next(-5, 15));//определяем элементы массива и конвертируем указанный диапозон чисел в тип данных short
            Console.WriteLine("Выводим элементы массива  :  " + numbers[i]);
            summa += numbers[i];
        } 
        Console.WriteLine("Сумма всех элементов массива {0}:  ", summa); //вынесли вывод после цикла - иначе после каждого элемента считается сумма


    //МНОГОМЕРНЫЕ МАССИВЫ:
        //Пример 4  - НУЖНО ДОРАБОТАТЬ ЭТОТ ПРИМЕР - РЕШЕНИЕ В СЛЕДУЮЩЕМ УРОКЕ
        Console.WriteLine("Пример 4");
        //запятая ',' в первых скобках указываает на двумерный массив
        /*
        char[,] symbols = new char[4]; //размерность первого массива '2', а во вложенном массиве будет '3' элемента
        symbols[0, 0] = 'H'; //обращаемся к первому элементу массива и через запятую обращаемся к элементу, который находится внутри массива
        Console.WriteLine();
        */
        int[,] num = { //сразу вводим элементы массива
            {4, 6, 7}, //ставиться запятая после вложенного элемента массива
            {5, 7, 9},
            {3, 3, 2},
        };
        //меняем элемент во вложенном массиве
        num[1, 2] = 56;  //обращаемся к элементу '9', который хотим поменять на 56: '1'- вложенный массив под индексом один, '2' - элемент под индексом два вложенного массива 
        for(byte i = 0; i < num.Length; i++) {
            for(byte j = 0; j < num.Length; j++) {
            Console.WriteLine("Выводим элементs массива  :  " + num[i, j]); //выводим в консоль элементs массива 
           } 
            Console.WriteLine(); 
        } 

        }
    }
}
