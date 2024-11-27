public class Hardware
{
    private string namn;
    private decimal pris;
    public Hardware(string namn, decimal pris)
    {
        this.namn = namn;
        this.pris = pris;
    }
    public string HämtaNamn()
    {
        return namn;
    }
    public decimal HämtaPris()
    {
        return pris;
    }
}
