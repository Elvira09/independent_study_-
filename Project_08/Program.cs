﻿//Цикл «foreach» для работы с массивами. Библиотека Generics
using System; 
using System.Collections.Generic; //подключили библиотеку Generic для динамических массивов

namespace project { 
    class Program { 
        static void Main() { 
            //Пример 1 - одномерный массив
            Console.WriteLine("Пример 1");

            short[] nums = {5, 6, 7, 8, 5, 3, 4};//создали одномерный массив
            foreach(short el in nums) { //в скобках указали переменную 'el' (которая будет содержать каждую переменную массива) типа данных 'short' в (in) массиве с названием 'nums'
            Console.WriteLine("Выводим элементы массива  :  " + el); //выводим в консоль элементs массива 
            }

            //Пример 2 - двумерный массив
            Console.WriteLine("Пример 2");

            short[,] nums1 = {   //создали двумерный массив
                {4, 5, 7},
                {43, 52, 17},
                {24, 53, 37},
                };
            foreach(short el1 in nums1) { 
            Console.WriteLine("Выводим элементы массива  :  " + el1); //выводим в консоль элементs массива 
            }

            //Пример 3 - динамический массив
            Console.WriteLine("Пример 3");

            //подключаем класс 'List"' для реализации динамической библиотеки, между галочек указывается тип даных
            List<int> numbers = new List<int> () {4, 6, 7}; //создали ДИНАМИЧЕСКИЙ массив и выделяем под него память, в нашем случае после указания класса необходимо поставить круглые скобки. В фигурных скобках указали элементы массива
            foreach(int el2 in numbers) { 
            Console.WriteLine("Выводим элементы массива  :  " + el2); //выводим в консоль элементs массива 
            }
            
            Console.WriteLine("Добавили элементы в массив ");
            //метод 'Add' позволяет добавить элемент в массив
            numbers.Add(40);
            numbers.Add(100);
            numbers.Add(5);
            foreach(int el3 in numbers) { 
            Console.WriteLine("После изменений выводим элементы массива  :  " + el3); 
            }
            
            Console.WriteLine("Удалили элемент в массиве ");
            //метод 'Remove' позволяет удалить элемент из массив
            numbers.Remove(100);
            foreach(int el4 in numbers) { 
            Console.WriteLine("После изменений выводим элементы массива  :  " + el4); 
            }

            Console.WriteLine("Отсортировали и развернули элементы в массиве ");
            //метод 'Sort' позволяет отсортировать элемент в массиве
            //метод 'Revers' позволяет перевернуть в обратную сторону элементы массива
            numbers.Sort();
            numbers.Reverse();
            foreach(int el5 in numbers) { 
            Console.WriteLine("После изменений выводим элементы массива  :  " + el5);  
            }
            //метод 'Clear' позволяет очистить массив от элементов
            //метод 'CopyTo' позволяет выполниить клонирование массива
            //метод 'Exists' позволяет проверить существует ли определенный элемент по его значению  и результат 'true' или 'false'
            //метод 'Find' позволяет найти определенный элемент и возвращает его индекс
        }
    }
}

