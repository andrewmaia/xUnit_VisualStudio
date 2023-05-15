using Xunit;

namespace xUnit_VisualStudio
{
    public class CalculadoraUnitTest
    {
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
    }
}