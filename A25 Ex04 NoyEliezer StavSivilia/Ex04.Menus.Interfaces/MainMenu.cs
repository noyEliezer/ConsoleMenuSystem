namespace Ex04.Menus.Interfaces
{
    public class MainMenu : MenuItem
    {
        private const bool k_IsMainMenu = true;

        public MainMenu(string i_Title) : base(i_Title, k_IsMainMenu) { }

        public void Show()
        {
            Display();
        }
    }
}
