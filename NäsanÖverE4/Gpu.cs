public class Grafikkort : Hardware
{
    private int minne;
    private string chipset;

    // Konstruktor
    public Grafikkort(string namn, decimal pris, int minne, string chipset)
        : base(namn, pris)
    {
        this.minne = minne;
        this.chipset = chipset;
    }
    public int HämtaMinne()
    {
        return minne;
    }

    public string HämtaChipset()
    {
        return chipset;
    }
}
