﻿using CurrencyAPI.Model;

namespace CurrencyAPI.Service
{

    public class GetCurrency
    {
        CalcCurrencyModel currencyModel;
        public List<CalcCurrencyModel> CurrencyList { get; set; } = new List<CalcCurrencyModel>();

        public IEnumerable<CalcCurrencyModel> GetCurrencyValue()
        {
            string[] text = System.IO.File.ReadAllLines(@"C:\Users\gorde\Desktop\Projetos C#\treinamento pericles\ConversaoDeMoedas\moedas.txt");
            foreach (string line in text)
            {
                string[] vect = line.Split(' ');
                currencyModel = new CalcCurrencyModel(vect[0], double.Parse(vect[1]));
                CurrencyList.Add(currencyModel);
            }
            return CurrencyList.ToList(); ;
        }
    }
}