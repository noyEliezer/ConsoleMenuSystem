using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class ShowCurrentTime : IActivateMenuItem
    {
        public void Activate()
        {
            MenuMethods.ShowCurrentTime();
        }
    }
}
