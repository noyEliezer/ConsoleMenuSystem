using System;
using System.Collections.Generic;

namespace Ex04.Menus.Events
{
    public abstract class MenuItem
    {
        private readonly string r_Title;
        protected readonly List<MenuItem> r_SubItems;

        public string Title
        {
            get { return r_Title; }
        }

        public List<MenuItem> SubItems
        {
            get { return r_SubItems; }
        }

        protected MenuItem(string i_Title)
        {
            r_Title = i_Title;
            r_SubItems = new List<MenuItem>();
        }

        public void AddMenuItem(MenuItem i_MenuItem)
        {
            r_SubItems.Add(i_MenuItem);
        }

        public abstract void ShowMenu();

        protected int getValidUserInput(int i_MaxValue)
        {
            int userInput;
            string userInputString = Console.ReadLine();

            while (!int.TryParse(userInputString, out userInput) ||
                   userInput < 0 || userInput > i_MaxValue)
            {
                Console.WriteLine("Invalid input. Please try again:");
                userInputString = Console.ReadLine();
            }

            return userInput;
        }
        protected abstract void OnMenuItemSelected();
    }
}