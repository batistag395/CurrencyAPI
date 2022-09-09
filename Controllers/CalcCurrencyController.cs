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

        [HttpGet("GetCurrencyValues")]
        public IResult GetCurrencyList()
        {
            return Results.Ok(GetCurrency.Instance.GetCurrencyValue()) ;
        }
        [HttpPost("CalculateCurrency")]
        public IResult CalcCurrency(string MoedaEntrada, string MoedaSaida, double valor1)
        {
            return Results.Ok(calcCurrencyService.CalcCurrency(MoedaEntrada, MoedaSaida, valor1));
        }
    }
}
