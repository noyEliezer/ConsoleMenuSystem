using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class CountLowercaseLetters : IActivateMenuItem
    {
        public void Activate()
        {
            MenuMethods.CountLowercaseLetters();
        }
    }
}
