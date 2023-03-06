using cdb_Backend.Domain.Commands.Requests;
using cdb_Backend.Domain.Commands.Response;

namespace cdb_Backend.Domain.Handlers
{
    public interface ICreateCalcCdbHandler
    {
        public CreateCalcCdbResponse Handle(CreateCalcCdbRequest request);
        public CreateCalcCdbResponse InitiValues();
    }
}
