using CurrencyAPI.Model;

namespace CurrencyAPI.Service
{
    public class GetCurrency
    {
        CalcCurrencyModel currencyModel;

        public List<CalcCurrencyModel> CurrencyList { get; set; } = new();

        private static GetCurrency instance;
        private GetCurrency()
        {

        }
        public IEnumerable<CalcCurrencyModel> GetCurrencyValue()
        {
            string[] text = System.IO.File.ReadAllLines(@"C:\Users\gorde\Desktop\Projetos C#\treinamento pericles\ConversaoDeMoedas\moedas.txt");
            foreach (string line in text)
            {
                string[] vect = line.Split(' ');
                currencyModel = new CalcCurrencyModel(int.Parse(vect[0]), vect[1], double.Parse(vect[2]));
                CurrencyList.Add(currencyModel);
            }
            return CurrencyList.ToList();
        }
        public static GetCurrency Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new GetCurrency();
                }
                return instance;
            }
        }
    }
}

