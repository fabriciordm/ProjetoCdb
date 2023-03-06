using cdb_Backend.Domain.Commands.Requests;
using cdb_Backend.Domain.Commands.Response;

namespace cdb_Backend.Domain.Handlers
{
    public class CreateCalcCdbHandler : ICreateCalcCdbHandler
    {
        public CreateCalcCdbResponse Handle(CreateCalcCdbRequest request) {


            CreateCalcCdbResponse cdb = new CreateCalcCdbResponse();
           
            return cdb.CalculoCdb(request);

           
        }

        public CreateCalcCdbResponse InitiValues()
        {
            CreateCalcCdbResponse cdb = new CreateCalcCdbResponse();
           return cdb.InitiValues();

        }
    }
}
