using CurrencyAPI.Model;

namespace CurrencyAPI.Service
{
    public class GetCurrency
    {
        private static GetCurrency instance;
        public List<CalcCurrencyModel> CurrencyList { get; set; } = new();
        private GetCurrency()
        {
        }
        public IEnumerable<CalcCurrencyModel> GetCurrencyValue()
        {
            return CurrencyList.ToList();
        }

        public void InitializeObjects()
        {
            string[] text = System.IO.File.ReadAllLines(@"C:\Users\gorde\Desktop\Projetos C#\treinamento pericles\ConversaoDeMoedas\moedas.txt");
            CurrencyList = new List<CalcCurrencyModel>();

            foreach (string line in text)
            {
                string[] vect = line.Split(' ');

                CurrencyList.Add(new CalcCurrencyModel
                {
                    Id = int.Parse(vect[0]),
                    Name = vect[1],
                    Rate = double.Parse(vect[2])
                });

            }

        }

        public static GetCurrency Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new GetCurrency();
                    instance.InitializeObjects();
                }
                return instance;
            }
        }
    }
}

