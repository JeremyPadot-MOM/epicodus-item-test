using System;
using System.Collections.Generic;
using ToDoList.Models;

namespace ToDoList
{
	public class Program
	{
		public static List<Item> newList = new List<Item> {};
		public static void Main()
		{
			Console.WriteLine("≧◔◡◔≦ Welcome to your To Do List! Purrrr");
			Menu();
		}

		public static void Menu()
		{
			Console.WriteLine("What would you like to do today?\n[1] View Your To Do List\n[2] Add items to your To Do List");
			string menuResponse = Console.ReadLine();
			switch(menuResponse)
			{
				case "1":
					ViewList();
					break;
				case "2":
					AddItems();
					break;
				default:
					Menu();
					break;
			}
		}
		
		public static void ViewList()
		{
			for (int i = 0; i < newList.Count; i++)
			{
				Console.WriteLine((i+1) + ". " + newList[i].Description);
			}
			Menu();
		}

		public static void AddItems()
		{
			Console.WriteLine("≧◔◡◔≦ Meow! Please enter a description for the item you'd like to add.");
			string description = Console.ReadLine();
			Item newItem = new Item(description);
			newList.Add(newItem);
		Menu();
		}
	}
}