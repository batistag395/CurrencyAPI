using CurrencyAPI.Model;

namespace CurrencyAPI.Service
{
    public class DeleteCurrencyService
    {
        public void DeleteCurrency(string Name)
        {
            CalcCurrencyModel currency = GetCurrency.Instance.CurrencyList.FirstOrDefault(x => x.Name == (Name));
            GetCurrency.Instance. CurrencyList.Remove(currency);
        }
    }
}
