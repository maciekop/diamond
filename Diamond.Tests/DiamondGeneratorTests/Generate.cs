using Diamond.Lib;

namespace Diamond.Tests.DiamondGeneratorTests
{
    public class Generate
    {
        [Fact]
        public void Given_InvalidArgument_Should_ThrowException()
        {
            var diamondGenerator = new DiamondGenerator();
            var exception = Record.Exception(() => diamondGenerator.Generate('#'));

            Assert.IsType<ArgumentException>(exception);
            Assert.Equal("Provided argument is not a capital letter from the alphabet", exception.Message);
        }

        [Theory]
        [InlineData('A', new string[] { "A" })]
        [InlineData('B', new string[] { "_A_", "B_B", "_A_" })]
        [InlineData('C', new string[] { "__A__", "_B_B_", "C___C", "_B_B_", "__A__" })]
        public void Given_CapitalLetter_Should_GenerateDiamond(char input, string[] expectedOutput)
        {
            var diamondGenerator = new DiamondGenerator();
            string[] diamond = diamondGenerator.Generate(input);

            Assert.Equal(expectedOutput, diamond);
        }
    }
}
