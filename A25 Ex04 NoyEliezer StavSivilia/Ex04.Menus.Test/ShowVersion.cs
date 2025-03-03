using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class ShowVersion : IActivateMenuItem
    {
        public void Activate()
        {
            MenuMethods.ShowVersion();
        }
    }
}
