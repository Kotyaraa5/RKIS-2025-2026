internal class Program
{
	private static void Main(string[] args)
	{
		Console.WriteLine("Работу выполнили: Амелина Яна и Кабанова Арина");
		Profile userProfile = CreateUserProfile();
		TodoList todos = new TodoList();
		bool isOpen = true;
		Console.ReadKey();
		while (isOpen)
		{
			Console.Clear();
			string userCommand = "";
			Console.WriteLine("Введите команду:\nдля помощи напиши команду help");
			userCommand = Console.ReadLine();
			try
			{
				ICommand command = CommandParser.Parse(userCommand, todos, userProfile);
				if (command != null)
				{
					command.Execute();
				}
				if (userCommand == "exit")
				{
					isOpen = false;
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Ошибка: {ex.Message}");
			}
			Console.ReadKey();
		}
	}
	private static Profile CreateUserProfile()
	{
		string name, surname;
		int yearOfBirth;
		Console.WriteLine("Напишите ваше имя и фамилию:");
		string fullName;
		while (string.IsNullOrEmpty(fullName = Console.ReadLine()))
		{
			Console.WriteLine("Вы ничего не ввели");
		}
		string[] splitFullName = fullName.Split(' ', 2);
		name = splitFullName[0];
		surname = splitFullName.Length > 1 ? splitFullName[1] : "";
		Console.WriteLine("Напишите свой год рождения:");
		yearOfBirth = int.Parse(Console.ReadLine());
		Profile profile = new Profile(name, surname, yearOfBirth);
		Console.WriteLine("Добавлен пользователь: " + profile.GetInfo(2025));
		return profile;
	}
}