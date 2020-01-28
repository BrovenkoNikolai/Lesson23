using System;

namespace AnonymousType_ValueTuple_Tuple_Urok23
{
    class Program
    {
        static void Main(string[] args)
        {
            #region АНОНИМНЫЕ ТИПЫ
            var product = new           // Анонимный тип можно читать и применять, но изменять уже нельзя. Так сказать применяется как для хранения данных.
            {
                Name = "Milk",
                Energy = 10
            };

            Console.WriteLine(product);
            Console.WriteLine(product.Name);
            Console.WriteLine(product.Energy);

            var eat = new Eat()
            {
                Name = "Meat"
            };

            var producd2 = new
            {
                eat.Name,
                Energy = 200
            };

            Console.WriteLine(producd2);

            Console.ReadLine();
            #endregion

            #region КОРТЕЖИ
            // Тип кортежа Tuple
            Tuple<int, string> tuple = new Tuple<int, string>(5, "Привет"); // Можно добавлять до 8 перечислений, и используется только для чтения.
            Console.WriteLine(tuple.Item1);

            // Тип кортежа ValueTuple
            var tuple2 = (5, "Привет"); // Для такой записи приходится подключаться в ручную: (Проект/Управление пакетами NuGet/Обзор/в поиске: System.ValueTuple и затем установить в проект)
            Console.WriteLine(tuple2);

            // Различия между Tuple и ValueTuple

            var tuple3 = (Name: "Tomato", Energy: 20); // В ValueTuple можно задавать конкретные имена.
            tuple3.Energy = 60; // И ValueTuple можно изменять значение полей. Но задавать методы не можем как и для Tuple.

            Console.WriteLine(tuple3);
            Console.WriteLine(tuple3.Energy);

            Console.ReadLine();
            #endregion

            #region ПРИМЕР ПРИМЕНЕНИЯ
            var result = GetData();
            Console.WriteLine(result.Name); // Сгенерированный Guid
            Console.ReadLine();

        }

        public static (int Number, string Name, bool Flag) GetData()
        {
            var number = 7821; // Метод получения данных
            var name = Guid.NewGuid().ToString(); // Метод получения данных
            bool b = number > 500; // Проверка условия

            return (number, name, b);
        }
        #endregion
    }
}
