//УСЛОВНЫЕ ОПЕРАТОРЫ if - else (Если условие соблюдается делаем..., иначе делаем...)
using System; 

namespace project { 
    class Program { 
        static void Main() { 
            //Пример 1
            int a = 5; //вводим переменную 'a'и присваиваем ей значение 5
            if(a > 7) { //если 'a' больше 7 /сравниваем значение переменной с числом 
                //можно задать какие-нибудь операции с переменной
                Console.WriteLine("Число {0} больше 7", a);//выводим на консоль результат
            } 
            else { //иначе выполняем следующие действия:
                Console.WriteLine("Число {0} меньше 7", a);
            }
            
            //Пример 2
            string world = "Привет! ";
            if(world == "Привет! ") {
                Console.WriteLine("Слово совпадает с " + world);
            }
            
            //Пример 3
            bool isHappy = true;
            if(isHappy == true) {
                Console.WriteLine("Счастье - это истина");
            }

            //Пример 4
            int a1 = 5; 
            bool isHasCar = true;
                //'&&' -  И, '||' - ИЛИ
            if(a1 == 5 && isHasCar) { //если переменная 'а' равна 5 И isHasCar истина, тогда
            // можно рассмотреть двойное условие, например  if((a1 == 5 || isHasCar) && a > 2)   
                Console.WriteLine("Число {0} равно 5 и у него есть автомобиль", a1);
            } 
            else { 
                Console.WriteLine("Либо число {0} не равно 5, либо у него есть нет автомобиля", a1);
            }

            //Пример 5
            Console.Write("Введите имя пользователя: ");
            string role = Console.ReadLine();
            if (role == "Эльвира") {
                Console.WriteLine("Добро пожаловать! Вам открыт доступ");
            } else {
                Console.WriteLine("Вы не Эльвира и Вам закрыт доступ");
            }

        }
    }
}
