using System;
using System.Text;

namespace Ex04.Menus.Events
{
    public class SubMenuItem : MenuItem
    {
        public SubMenuItem(string i_Title) : base(i_Title)
        {
        }

        public override void ShowMenu()
        {
            int userChoice;
            bool isExit = false;

            Console.Clear();
            while (!isExit)
            {
                displayMenu();
                userChoice = getValidUserInput(r_SubItems.Count);
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

        protected virtual void displayMenu()
        {
            StringBuilder menu = new StringBuilder();
            string title = $"** {Title} **";

            menu.AppendLine(title);
            menu.AppendLine(new string('-', title.Length));
            for (int i = 1; i <= r_SubItems.Count; i++)
            {
                menu.AppendLine($"{i}. {r_SubItems[i - 1].Title}");
            }

            string exitChoice = GetExitChoice();
            string exitText = GetExitText();

            menu.AppendLine($"0. {exitChoice}");
            menu.AppendLine($"Please enter your choice (1-{r_SubItems.Count} or 0 to {exitText}):");
            Console.Write(menu.ToString());
            Console.Write(">> ");
        }

        protected virtual string GetExitText()
        {
            return "go back";
        }

        protected virtual string GetExitChoice()
        {
            return "Back";
        }

        private void handleMenuItemSelection(MenuItem i_SelectedItem)
        {
            Console.Clear();
            i_SelectedItem.ShowMenu();
        }

        protected override void OnMenuItemSelected()
        {

        }
    }
}
