using System;


namespace OOP
{
    //Статический класс -
    /* Если создано Static class то все его данные может содержать только статические данные
     * не возможно использовать синтаксис this
     */
    public static class ModificatorStatic
    {
        /* Для статик поля и свойств выделяется помят не зовисимо от объект*/
        public static int Age = 0;
        public static int Amount { get; set; }
        /* Статик методы определяю общее поведение которие не зовисить*/
        public static int AddAmount(int a) => a + Amount;

        /* Конструктор - не имеет модефикатор, Выпольняется автоматом при созданаие экземпляр класса. Оно не должен иметь входяшие ппараметры*/

        static ModificatorStatic()
        {
            Console.WriteLine("Static constructor");
        }

    }
}
