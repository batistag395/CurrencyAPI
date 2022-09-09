using CurrencyAPI.Model;

namespace CurrencyAPI.Service
{
    public class CalcCurrencyService
    {
        CalcCurrencyModel currencyModel;
        GetCurrency getCurrency = new GetCurrency();

        public double CalcCurrency(string MoedaEntrada, string MoedaSaida, double valor)
        {
            string[] text = System.IO.File.ReadAllLines(@"C:\Users\gorde\Desktop\Projetos C#\treinamento pericles\ConversaoDeMoedas\moedas.txt");
            foreach (string line in text)
            {
                string[] vect = line.Split(' ');
                currencyModel = new CalcCurrencyModel(vect[0], double.Parse(vect[1]));
                getCurrency.CurrencyList.Add(currencyModel);
            }
            CalcCurrencyModel query = getCurrency.CurrencyList.FirstOrDefault(x => x.Name == (MoedaEntrada));
            CalcCurrencyModel query2 = getCurrency.CurrencyList.FirstOrDefault(x => x.Name == (MoedaSaida));

            return query.Rate / query2.Rate * valor;
        }
    }
}
