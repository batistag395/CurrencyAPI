using CurrencyAPI.Model;

namespace CurrencyAPI.Service
{
    public class CalcCurrencyService
    {
        public double CalcCurrency(string MoedaEntrada, string MoedaSaida, double valor)
        {
            CalcCurrencyModel query = GetCurrency.Instance.CurrencyList.FirstOrDefault(x => x.Name == (MoedaEntrada));
            CalcCurrencyModel query2 = GetCurrency.Instance.CurrencyList.FirstOrDefault(x => x.Name == (MoedaSaida));
            return query.Rate / query2.Rate * valor;
        }
    }
}
