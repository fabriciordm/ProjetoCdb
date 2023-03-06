using cdb_Backend.Domain.Commands.Requests;
using cdb_Backend.Domain.Commands.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cdb_Backend.Tests
{
    public class Mock
    {
  
        public CreateCalcCdbResponse GetResponseMock()
        {
            return new CreateCalcCdbResponse()
            {
                valorMonetario = 0,
                prazo = 0,
                ValorFinal = 0,
                ValorInicial = 0,
                ValorCdb = 0,
                TB = 0,
                ValorBruto = 0,
                ValorLiquido = 0,
                CDI = 0,
                Imposto = 0,

            };
        }

        public CreateCalcCdbRequest GetRequestMock()
        {
            return new CreateCalcCdbRequest()
            {
                valorMonetario = 0,
                prazo = 0,
                ValorFinal = 0,
                ValorInicial = 0,
                ValorCdb = 0,
                TB = 0,
                ValorBruto = 0,
                ValorLiquido = 0

            };
        }
    }
}









