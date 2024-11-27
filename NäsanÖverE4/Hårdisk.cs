public class Hårddisk : Hardware
{
    private int kapacitet;
    private int rpm;
    public Hårddisk(string namn, decimal pris, int kapacitet, int rpm)
        : base(namn, pris)
    {
        this.kapacitet = kapacitet;
        this.rpm = rpm;
    }
    public int HämtaKapacitet()
    {
        return kapacitet;
    }
    public int HämtaRPM()
    {
        return rpm;
    }
}