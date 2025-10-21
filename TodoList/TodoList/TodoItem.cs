﻿public class TodoItem
{
	public string Text { get; private set; }
	public bool IsDone { get; private set; }
	public DateTime LastUpdate { get; private set; }
	public TodoItem(string text)
	{
		Text = text;
		IsDone = false;
		LastUpdate = DateTime.Now;
	}
	public void MarkDone()
	{
		IsDone = true;
		LastUpdate = DateTime.Now;
	}
	public void UpdateText(string newText)
	{
		Text = newText;
		LastUpdate = DateTime.Now;
	}
	public string GetShortInfo()
	{
		string shortText = Text.Length <= 30 ? Text : Text.Substring(0, 27) + "...";
		return shortText;
	}
	public string GetFullInfo()
	{
		return $"Текст задачи: \n{Text}\nСтатус: {(IsDone ? "Выполнена" : "Не выполнена")}\nДата последнего изменения: {LastUpdate:dd.MM.yyyy HH:mm:ss}";
	}
}
