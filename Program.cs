using System;
using System.Text.RegularExpressions;

namespace usersProject
{
    public class User // Класс для данных
    {
        private string login, password, name; // Поля

	public string propLogin // Свойства login
	{
            get // Геттер, возвращает значение
            { 
                return login; 
            } 

            set // Сеттер, проверка данных
	    {
                if (value.Length < 6 || value.Length > 20) // Длина строки
		{ 
                    return;
                }

                if (Regex.IsMatch(value, "[A-Z ]")) // Если есть заглавные буквы или пробелы
                {
                    return;
                }

		login = value; // При успешной проверке - присваивание значения
		}
	     }


		public string propPassword // Свойства password
		{
	    get 
            { 
                return password; 
            } // Геттер, возвращает значение

            set // Сеттер, проверка данных
	    {
                if (value.Length < 6 || value.Length > 20) // Длина строки
                {
                    return;
                }
                if (Regex.IsMatch(value, " ")) // Проверка на пробелы
                {
                    return;
                }
                if (!Regex.IsMatch(value, "[A-Z]")) // Проверка на верхний регистр
                {
                    return;
                }
                password = value; // При успешной проверке - присваивание значения
            }
	}

		public string propName // Свойства Name
		{
	            get 
                    { 
                         return name; 
                    }
	            set 
                    { 
                         name = value; 
                    }
		}
    }

	public class Program
	{
        static void Main(string[] args)
	{
            User user = new User();

            user.propLogin = Console.ReadLine(); // Использование сеттера
            Console.WriteLine("Логин - {0}", user.propLogin); // Использование геттера

            user.propPassword = Console.ReadLine();
            Console.WriteLine("Пароль - {0}", user.propPassword);

            user.propName = Console.ReadLine();
            Console.WriteLine("Имя - {0}", user.propName);
        }

    }
}
