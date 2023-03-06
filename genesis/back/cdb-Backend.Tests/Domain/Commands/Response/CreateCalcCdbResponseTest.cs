using cdb_Backend.Domain.Commands.Requests;
using cdb_Backend.Domain.Commands.Response;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cdb_Backend.Tests.Domain.Commands.Response
{
    public class CreateCalcCdbResponseTest
    {


        [Test]
        public void Should_Verify_Prazo_withSuccess()
        {
            Mock cdb_test = new Mock();
            var result = cdb_test.GetRequestMock();
                
            if (result.prazo >1)
                Assert.Pass();
        }

        [Test]
        public void Shouldnt_Verify_Prazo_withSuccess()
        {
            Mock cdb_test = new Mock();
            var result = cdb_test.GetRequestMock();

            if (result.prazo < 1)
                Assert.Pass();
        }

        [Test]
        public void Should_Verify_Negative_Values_Fail()
        {
            Mock cdb_test = new Mock();
            var result = cdb_test.GetRequestMock();

            if (result.ValorInicial < 0 || result.ValorBruto < 0   ||  result.prazo < 0)
                Assert.Fail();
        }


        [Test]
        public void Should_Verify_Negative_Values_witSucces()
        {
            Mock cdb_test = new Mock();
            var result = cdb_test.GetRequestMock();

            if (result.ValorInicial > 0 || result.ValorBruto > 0 || result.prazo > 0)
                Assert.Fail();
        }

    }
}
