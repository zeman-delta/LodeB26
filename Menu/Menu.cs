namespace Menu;

public class Menu
{
    private readonly MenuVolba[] polozky = { MenuVolba.SpustitHru, MenuVolba.Konec };
    private int vybrany = 0;

    public MenuVolba Vyber()
    {
        Console.CursorVisible = false;
        Console.Clear();

        while (true)
        {
            Vykresli();

            ConsoleKey klavesa = Console.ReadKey(intercept: true).Key;

            if (klavesa == ConsoleKey.UpArrow)
            {
                vybrany = (vybrany - 1 + polozky.Length) % polozky.Length;
            }
            else if (klavesa == ConsoleKey.DownArrow)
            {
                vybrany = (vybrany + 1) % polozky.Length;
            }
            else if (klavesa == ConsoleKey.Enter)
            {
                break;
            }
        }

        Console.CursorVisible = true;
        Console.Clear();

        return polozky[vybrany];
    }

    private void Vykresli()
    {
        Console.SetCursorPosition(0, 0);
        Console.WriteLine("Hlavní menu");
        Console.WriteLine("(šipky = pohyb, Enter = potvrzení)");
        Console.WriteLine();

        for (int i = 0; i < polozky.Length; i++)
        {
            if (i == vybrany)
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine($" > {polozky[i].Popisek}   ");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine($"   {polozky[i].Popisek}   ");
            }
        }
    }
}
