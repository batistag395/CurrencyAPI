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
        CalcCurrencyService calcCurrencyService = new();
        AddNewCurrencyService addNewCurremcy = new();
        UpdateCurrencyService updateCurrencyService = new();
        DeleteCurrencyService deleteCurrencyService = new();

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
        [HttpPost("AddNewCurrency")]
        public void AddCurrency(string Nome, double Rate)
        {
           addNewCurremcy.AddVNewCurrency(Nome, Rate);
        }
        [HttpPost("UpdateCurrency")]
        public void UpdateCurrency(string Nane, string NewName, double Value)
        {
            updateCurrencyService.UpdateCurrency(Nane, NewName, Value);
        }
        [HttpPost("DeleteCurrency")]
        public void DeleteCurrency(string Name)
        {
            deleteCurrencyService.DeleteCurrency(Name);
        }
    }
}
