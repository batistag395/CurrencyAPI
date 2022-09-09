namespace CurrencyAPI.Model
{
    public class CalcCurrencyModel
    {
        public string Name { get; set; }
        public double Rate { get; set; }
        public CalcCurrencyModel(string name, double rate)
        {
            Name = name;
            Rate = rate;
        }
        public override string ToString()
        {
            return Name + " " + Rate;
        }
    }
}
