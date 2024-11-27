public class Processor : Hardware
{
    private int kärnor;
    private double klockhastighet;
    public Processor(string namn, decimal pris, int kärnor, double klockhastighet)
        : base(namn, pris)
    {
        this.kärnor = kärnor;
        this.klockhastighet = klockhastighet;
    }
    public int HämtaKärnor()
    {
        return kärnor;
    }
    public double HämtaKlockhastighet()
    {
        return klockhastighet;
    }
}