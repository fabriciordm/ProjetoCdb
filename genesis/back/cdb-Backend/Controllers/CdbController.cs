using cdb_Backend.Domain.Commands.Requests;
using cdb_Backend.Domain.Commands.Response;
using cdb_Backend.Domain.Handlers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.WebEncoders.Testing;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace cdb_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CdbController : ControllerBase
    {

        private readonly ICreateCalcCdbHandler _calcCdbHandler;

        public CdbController(ICreateCalcCdbHandler calcCdbHandler )
        {
            _calcCdbHandler = calcCdbHandler;
        }

       
        [HttpPost]
        public CreateCalcCdbResponse Post([FromBody] CreateCalcCdbRequest command)
        {
           var teste =  _calcCdbHandler.Handle(command);
            return teste;
        }

        [HttpGet]
        public CreateCalcCdbResponse Get()
        {
            var teste = _calcCdbHandler.InitiValues();
            return teste;
        }





    }
}
