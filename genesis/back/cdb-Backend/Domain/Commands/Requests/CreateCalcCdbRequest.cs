namespace cdb_Backend.Domain.Commands.Requests
{
    public class CreateCalcCdbRequest
    {
        public double valorMonetario { get; set; }
        public int prazo { get; set; }
        public double ValorFinal { get; set; }
        public double ValorInicial { get; set; }
        public double ValorCdb { get; set; }
        public double TB { get; set; }
        public double ValorBruto { get; set; }
        public double ValorLiquido { get; set; }
    }
}
