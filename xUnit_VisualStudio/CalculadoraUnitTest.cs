using Xunit;

namespace xUnit_VisualStudio
{
    public class CalculadoraUnitTest
    {
        //Para rodar os testes em linha de comando  utiluze: dotnet test
        Calculadora c = new Calculadora();

        [Fact]
        public void TesteFunciona()
        {
            Assert.Equal(4, c.Somar(2, 2));
        }

        [Fact]
        public void TesteNaoFunciona()
        {
            Assert.Equal(5, c.Somar(2, 2));
        }

        [Theory]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(6)]
        public void NumeroEhPar(int value)
        {
            Assert.True(c.NumeroEhPar(value));
        }
    }
}