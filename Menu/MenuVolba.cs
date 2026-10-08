namespace Menu;

public enum MenuVolba
{
    SpustitHru,
    Konec
}

public static class MenuVolbaRozsireni
{
    // enum sám metody mít nemůže – je to jen pojmenovaný int.
    // Extension blok (C# 14 / .NET 10) mu je umí přidat zvenku,
    // takže popisek žije u volby.
    extension(MenuVolba volba)
    {
        public string Popisek => volba switch
        {
            MenuVolba.SpustitHru => "Spustit hru",
            MenuVolba.Konec      => "Konec",
            _ => volba.ToString()   // nutné: přetypovat jde i neplatné číslo
        };
    }
}
