namespace Ex04.Menus.Events
{
    public class MainMenu 
    {
        private readonly MainMenuItem r_RootItem;

        public MainMenuItem RootItem
        {
            get
            {
                return r_RootItem;
            }
        }

        public MainMenu(string i_Title)
        {
            r_RootItem = new MainMenuItem(i_Title);
        }

        public void Show()
        {
            r_RootItem.ShowMenu();
        } 
    }
}
