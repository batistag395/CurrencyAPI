using CurrencyAPI.Model;

namespace CurrencyAPI.Service
{
    public class UpdateCurrencyService
    {
        public void UpdateCurrency(string Nane, string NewName, double Value)
        {
            CalcCurrencyModel currency = GetCurrency.Instance.CurrencyList.FirstOrDefault(x => x.Name == (Nane));
            currency.Name = NewName;
            currency.Rate = Value;
        }
    }
}
