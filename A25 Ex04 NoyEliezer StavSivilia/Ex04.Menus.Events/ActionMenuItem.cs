using System;

namespace Ex04.Menus.Events
{
    public class ActionMenuItem : MenuItem
    {
        public event Action MenuItemSelected;

        public ActionMenuItem(string i_Title, Action i_Action) : base(i_Title)
        {
            MenuItemSelected += i_Action;
        }

        public override void ShowMenu()
        {
            OnMenuItemSelected();
            Console.WriteLine($"{Environment.NewLine}Press Enter to continue...");
            Console.ReadLine();
            Console.Clear();
        }

        protected override void OnMenuItemSelected()
        {
            MenuItemSelected?.Invoke();
        }
    }
}
