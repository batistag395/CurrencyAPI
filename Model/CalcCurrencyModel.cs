namespace CurrencyAPI.Model
{
    public class CalcCurrencyModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Rate { get; set; }

        public CalcCurrencyModel(int id, string name, double rate)
        {
            Id = id;
            Name = name;
            Rate = rate;
        }

        public CalcCurrencyModel()
        {
        }
    }
}
