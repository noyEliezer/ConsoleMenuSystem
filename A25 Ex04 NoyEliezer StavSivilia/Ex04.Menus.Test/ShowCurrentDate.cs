using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class ShowCurrentDate : IActivateMenuItem
    {
        public void Activate()
        {
            MenuMethods.ShowCurrentDate();
        }
    }
}
