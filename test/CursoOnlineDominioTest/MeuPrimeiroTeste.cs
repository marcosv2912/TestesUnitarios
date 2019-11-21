using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace CursoOnline.DominioTest
{
    public class MeuPrimeiroTeste
    {
        private readonly ITestOutputHelper _output;

        public MeuPrimeiroTeste(ITestOutputHelper output)
        {
            _output = output;
            _output.WriteLine("Output funcionando corretamente");
        }

        public ITestOutputHelper Output { get; }

        [Fact(DisplayName = "Testar")]
        public void TerOMesmoValor()
        {
            //AAA
            //Organização
            var variavel1 = 3;
            var variavel2 = 3;

            //Ação
            variavel2 = variavel1;


            //Assert
            Assert.Equal(variavel1, variavel2);
        }
    }
}
