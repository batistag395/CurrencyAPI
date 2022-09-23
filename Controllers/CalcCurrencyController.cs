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
        GetCurrencyByIdService getCurrencyByIdService = new();

        [HttpGet("{id}")]
        public IResult GetCurrencyById(int id)
        {
            return Results.Ok(getCurrencyByIdService.GetCureencyById(id));
        }
        [HttpGet("GetListOfCurrency")]
        public IResult GetCurrencyList()
        {
            return Results.Ok(GetCurrency.Instance.GetCurrencyValue()); ; ;
        }
        [HttpPost("CalculateCurrency")]
        public IResult CalcCurrency(string Name, string Name2, double Rate)
        {
            return Results.Ok(calcCurrencyService.CalcCurrency(Name, Name2, Rate));
        }
        [HttpPost("AddNewCurrency")]
        public void AddNewCurrency(int Id, string Name, double Rate)
        {
            addNewCurremcy.AddVNewCurrency(Id, Name, Rate);
        }
        [HttpPut("UpdateACurrency")]
        public void UpdateACurrency(string Name, string NewName, double Value)
        {
            updateCurrencyService.UpdateCurrency(Name, NewName, Value);
        }
        [HttpDelete("DeleteACurrency")]
        public void DeleteACurrency(string Name)
        {
            deleteCurrencyService.DeleteCurrency(Name);
        }
    }
}
