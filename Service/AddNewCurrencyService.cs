using CurrencyAPI.Model;

namespace CurrencyAPI.Service
{
    public class AddNewCurrencyService
    {
        CalcCurrencyModel calcCurrency;
        public void AddVNewCurrency(string Name, double Rate)
        {
            calcCurrency = new(Name, Rate);
            GetCurrency.Instance.CurrencyList.Add(calcCurrency); 
        }
    }
}
