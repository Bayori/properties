using System;
using System.Text.RegularExpressions;

namespace usersProject
{
    public class User
    {
        private string login, password, name;

		public string Login
		{
			get 
			{ 
				return login; 
			}

			set 
			{
                if (value.Length < 6 || value.Length > 20) // Длина строки
				{ 
                    return;
                }

                if (Regex.IsMatch(value, "[A-Z ]")) // Если есть заглавные буквы или пробелы
                {
                    return;
                }
				login = value;
			}
		}

		public string Password
		{
			get 
			{ 
				return password;
			}
			set 
			{
                if (value.Length < 6 || value.Length > 20) // Длина строки
                {
                    return;
                }
                if (Regex.IsMatch(value, " ")) // Проверка на пробел.ы
                {
                    return;
                }
                if (!Regex.IsMatch(value, "[A-Z]")) // Проверка на верхний регистр
                {
                    return;
                }
                password = value;
            }
		}

		public string Name
		{
			get { return name; }
			set { name = value; }
		}
	}
	public class Program
	{
        static void Main(string[] args)
		{
			User user = new User();

            user.Login = Console.ReadLine();
            Console.WriteLine("Логин - {0}", user.Login);
            user.Password = Console.ReadLine();
            Console.WriteLine("Пароль - {0}", user.Password);
            user.Name = Console.ReadLine();
            Console.WriteLine("Имя - {0}", user.Name);
        }

    }
}
