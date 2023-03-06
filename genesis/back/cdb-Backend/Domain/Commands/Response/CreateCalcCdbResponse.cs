using cdb_Backend.Domain.Commands.Requests;

namespace cdb_Backend.Domain.Commands.Response
{
    public class CreateCalcCdbResponse
    {
        public double valorMonetario { get; set; }
        public int prazo { get; set; }
        public double ValorFinal { get; set; }
        public double ValorInicial { get; set; }
        public double ValorCdb { get; set; }
        public double TB { get; set; }
        public double ValorBruto { get; set; }
        public double ValorLiquido { get; set; }
        public double CDI { get; set; }
        public double Imposto { get; set; }

        public string informativoPrazo { get; set; }
        public CreateCalcCdbResponse()
        {
            this.CDI = 0.009;
            this.TB=1.08;
        }

       

        public CreateCalcCdbResponse CalculoCdb(CreateCalcCdbRequest cdb)
        {
            if (cdb.prazo > 1)
            {
                try
                {
                    switch (cdb.prazo)
                    {
                        case <= 6:
                            this.Imposto = 0.2205;
                            break;
                        case > 6 and < 13:
                            this.Imposto = 0.2;
                            break;
                        case > 13 and < 25:
                            this.Imposto = 0.175;
                            break;
                        case > 25:
                            this.Imposto = 0.15;
                            break;
                    }

                    ValorFinal = cdb.ValorInicial * (cdb.prazo + (this.CDI * this.TB));
                    ValorLiquido = (ValorFinal - (this.Imposto * ValorFinal));

                    ValorFinal = Math.Round(ValorFinal, 2);
                    ValorLiquido = Math.Round(ValorLiquido, 2);
                }
                catch (CdbExceptions)
                {
                    Console.WriteLine("Ocorreu uma exceção personalizada: contactar suporte");
                }


                return new CreateCalcCdbResponse()
                {
                    valorMonetario = cdb.valorMonetario,
                    prazo = cdb.prazo,
                    ValorFinal = ValorFinal,
                    ValorInicial = cdb.ValorInicial,
                    ValorCdb = cdb.ValorCdb,
                    TB = cdb.TB,
                    ValorLiquido = ValorLiquido,
                    Imposto = Imposto,
                    ValorBruto = ValorFinal,
                    informativoPrazo = "conversão de percentual valor imposto " + Imposto

                };

            }
            else
            {
                return new CreateCalcCdbResponse()
                {
                    valorMonetario = 0,
                    prazo =0,
                    ValorFinal =0,
                    ValorInicial =0,
                    ValorCdb = 0,
                    TB = 0,
                    ValorLiquido = 0,
                    Imposto = 0,
                    ValorBruto = 0,
                    informativoPrazo = "Nécessário no mínimo 2 meses"

                };
            }

        }

        public CreateCalcCdbResponse InitiValues()
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
                Imposto=0
            };
        }
    }

}
