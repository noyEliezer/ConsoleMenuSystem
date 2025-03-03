namespace Ex04.Menus.Events
{
    public class MainMenuItem : SubMenuItem
    {
        public MainMenuItem(string i_Title) : base(i_Title)
        {
        }

        protected override string GetExitText()
        {
            return "exit";
        }

        protected override string GetExitChoice()
        {
            return "Exit";
        }
    }
}
