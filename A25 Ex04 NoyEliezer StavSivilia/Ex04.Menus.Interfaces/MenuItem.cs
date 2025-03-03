using System.Collections.Generic;
using System.Text;
using System;

namespace Ex04.Menus.Interfaces
{
    public class MenuItem : IActivateMenuItem
    {
        private readonly string r_Title;
        private readonly bool r_IsMainMenu;
        private readonly List<MenuItem> r_SubItems;
        private IActivateMenuItem m_ActivateItem;

        public string Title
        {
            get
            {
                return r_Title;
            }
        }

        public bool IsMainMenu
        {
            get
            {
                return r_IsMainMenu;
            }
        }

        public List<MenuItem> SubItems
        {
            get
            {
                return r_SubItems;
            }
        }

        public IActivateMenuItem ActivateItem
        {
            get
            {
                return m_ActivateItem;
            }
            set
            {
                m_ActivateItem = value;
            }
        }

        public MenuItem(string i_Title, bool i_IsMainMenu = false)
        {
            r_Title = i_Title;
            r_IsMainMenu = i_IsMainMenu;
            r_SubItems = new List<MenuItem>();
        }

        public MenuItem(string i_Title, IActivateMenuItem i_ActivateItem)
        {
            r_Title = i_Title;
            r_SubItems = new List<MenuItem>();
            m_ActivateItem = i_ActivateItem;
        }

        public void AddMenuItem(MenuItem i_MenuItem)
        {
            if (i_MenuItem != null)
            {
                r_SubItems.Add(i_MenuItem);
            }
        }

        public void Display()
        {
            int userChoice;
            bool isExit = false;

            Console.Clear();
            while (!isExit)
            {
                displayMenu();
                userChoice = getValidUserInput();
                if (userChoice == 0)
                {
                    isExit = true;
                    Console.Clear();
                }
                else
                {
                    handleMenuItemSelection(SubItems[userChoice - 1]);
                }
            }
        }

        private void displayMenu()
        {
            StringBuilder menu = new StringBuilder();
            string title = $"** {Title} **";

            menu.AppendLine(title);
            menu.AppendLine(new string('-', title.Length));
            for (int i = 1; i <= SubItems.Count; i++)
            {
                menu.AppendLine($"{i}. {SubItems[i - 1].Title}");
            }

            string exitChoice = IsMainMenu ? "Exit" : "Back";
            string exitText = IsMainMenu ? "exit" : "go back";

            menu.AppendLine($"0. {exitChoice}");
            menu.AppendLine($"Please enter your choice (1-{SubItems.Count} or 0 to {exitText}):");
            Console.Write(menu.ToString());
            Console.Write(">> ");
        }

        private int getValidUserInput()
        {
            int userInput;
            string userInputString;

            userInputString = Console.ReadLine();
            while (!int.TryParse(userInputString, out userInput) ||
                    userInput < 0 || userInput > r_SubItems.Count)
            {
                Console.Write($"Invalid input. Please try again: {Environment.NewLine}>> ");
                userInputString = Console.ReadLine();
            }

            return userInput;
        }

        private void handleMenuItemSelection(MenuItem i_SelectedItem)
        {
            Console.Clear();
            if (i_SelectedItem.SubItems.Count == 0)
            {
                try
                {
                    i_SelectedItem.Activate();
                    Console.WriteLine($"{Environment.NewLine}Press Enter to continue...");
                    Console.ReadLine();
                    Console.Clear();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error executing menu item: {ex.Message}");
                }
            }
            else
            {
                i_SelectedItem.Display();
            }
        }

        public void Activate()
        {
            if (m_ActivateItem != null)
            {
                m_ActivateItem.Activate();
            }
        }
    }
}