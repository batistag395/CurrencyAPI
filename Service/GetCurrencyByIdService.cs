using CurrencyAPI.Model;

namespace CurrencyAPI.Service
{
    public class GetCurrencyByIdService
    {
        CalcCurrencyModel calcCurrencyModel;
        public List<CalcCurrencyModel> currencyListId = new();
        public IEnumerable<CalcCurrencyModel> GetCureencyById(object id)
        {
            CalcCurrencyModel currency = GetCurrency.Instance.CurrencyList.FirstOrDefault(x => x.Id.Equals(id));
            calcCurrencyModel = new CalcCurrencyModel(currency.Id, currency.Name, currency.Rate);
            currencyListId.Add(currency);
            return currencyListId.ToList(); 
        }
    }
}
