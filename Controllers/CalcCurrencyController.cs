using CurrencyAPI.Model;
using CurrencyAPI.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CurrencyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalcCurrencyController : ControllerBase
    {
        CalcCurrencyService calcCurrencyService = new CalcCurrencyService();
        GetCurrency getCurrency = new GetCurrency();

        [HttpGet("GetCurrencyValues"]
        public IEnumerable<CalcCurrencyModel> GetListOfCurrency()
        {
            return getCurrency.GetCurrencyValue();
        }

        [HttpPost("CalcCurrency")]
        public double CalcCurrency(string MoedaEntrada, string MoedaSaida, double valor1)
        {
            return calcCurrencyService.CalcCurrency(MoedaEntrada, MoedaSaida, valor1);
        }
    }
}
