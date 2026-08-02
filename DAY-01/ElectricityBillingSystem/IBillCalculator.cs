namespace DAY_01
{
    public interface IBillCalculator
    {
        double CalculateBill(double units, double rate, double fixedCharges);
    }
}