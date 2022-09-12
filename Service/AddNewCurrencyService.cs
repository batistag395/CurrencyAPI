using CurrencyAPI.Model;

namespace CurrencyAPI.Service
{
    public class AddNewCurrencyService
    {
        CalcCurrencyModel calcCurrency;
        public void AddVNewCurrency(int id, string Name, double Rate)
        {
            calcCurrency = new(id, Name, Rate);
            GetCurrency.Instance.CurrencyList.Add(calcCurrency);
        }
    }
}
