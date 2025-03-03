namespace Ex04.Menus.Test
{
    public static class MenuTest
    {
        public static void TestMenuWithInterface()
        {
            Interfaces.MainMenu interfaceMainMenu = new Interfaces.MainMenu("Interface Main Menu");
            Interfaces.MenuItem lettersAndVersionMenu = new Interfaces.MenuItem("Letters and Version");
            Interfaces.MenuItem showDateTimeMenu = new Interfaces.MenuItem("Show Current Date/Time");
            Interfaces.MenuItem showVersionItem = new Interfaces.MenuItem("Show Version", new ShowVersion());
            Interfaces.MenuItem countLowerLettersItem = new Interfaces.MenuItem("Count Lowercase Letters", new CountLowercaseLetters());
            Interfaces.MenuItem showTimeItem = new Interfaces.MenuItem("Show Current Time", new ShowCurrentTime());
            Interfaces.MenuItem showDateItem = new Interfaces.MenuItem("Show Current Date", new ShowCurrentDate());

            lettersAndVersionMenu.AddMenuItem(showVersionItem);
            lettersAndVersionMenu.AddMenuItem(countLowerLettersItem);
            showDateTimeMenu.AddMenuItem(showTimeItem);
            showDateTimeMenu.AddMenuItem(showDateItem);
            interfaceMainMenu.AddMenuItem(lettersAndVersionMenu);
            interfaceMainMenu.AddMenuItem(showDateTimeMenu);
            interfaceMainMenu.Show();
        }

        public static void TestMenuWithDelegates()
        {
            Events.MainMenu delegatesMainMenu = new Events.MainMenu("Delegates Main Menu");
            Events.SubMenuItem lettersAndVersionMenu = new Events.SubMenuItem("Letters and Version");
            Events.SubMenuItem showDateTimeMenu = new Events.SubMenuItem("Show Current Date/Time");
            Events.ActionMenuItem showVersionItem = new Events.ActionMenuItem("Show Version", MenuMethods.ShowVersion);
            Events.ActionMenuItem countLowerLettersItem = new Events.ActionMenuItem("Count Lowercase Letters", MenuMethods.CountLowercaseLetters);
            Events.ActionMenuItem showTimeItem = new Events.ActionMenuItem("Show Current Time", MenuMethods.ShowCurrentTime);
            Events.ActionMenuItem showDateItem = new Events.ActionMenuItem("Show Current Date", MenuMethods.ShowCurrentDate);

            lettersAndVersionMenu.AddMenuItem(showVersionItem);
            lettersAndVersionMenu.AddMenuItem(countLowerLettersItem);
            showDateTimeMenu.AddMenuItem(showTimeItem);
            showDateTimeMenu.AddMenuItem(showDateItem);
            delegatesMainMenu.RootItem.AddMenuItem(lettersAndVersionMenu);
            delegatesMainMenu.RootItem.AddMenuItem(showDateTimeMenu);
            delegatesMainMenu.Show();
        }
    }
}

