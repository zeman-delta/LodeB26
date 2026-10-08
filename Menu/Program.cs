namespace Menu;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        bool bezi = true;
        
        while (bezi)
        {
            MenuVolba volba = menu.Vyber();

            switch (volba)
            {
                case MenuVolba.SpustitHru:
                    Hra hra = new Hra();
                    hra.Spust();
                    break;

                case MenuVolba.Konec:
                    bezi = false;
                    break;
            }
        }
    }
}
