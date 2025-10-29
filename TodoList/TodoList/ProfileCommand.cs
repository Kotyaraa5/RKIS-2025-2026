﻿public class ProfileCommand : ICommand
{
	public Profile UserProfile {get; set;}
	public int CurrentYear {get; set;} = 2025;
	public void Execute()
	{
		Console.WriteLine("Пользователь: " + UserProfile.GetInfo(CurrentYear));
	}
}
