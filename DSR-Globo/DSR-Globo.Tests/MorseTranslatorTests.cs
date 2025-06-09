using DSR_Globo.Services;

namespace DSR_Globo.Tests
{
    public class MorseTranslatorTests
    {
        private readonly MorseTranslatorService _translator = new();

        [Theory]        
        [InlineData(".... . -.-- / .--- ..- -.. .", "HEY JUDE")]
        [InlineData("--. .-.. --- -... --- / . / ...- -.-. / - ..- -.. --- / .- / ...- .", "GLOBO E VC TUDO A VE")]
        public void Translate_ValidMorse_ReturnsCorrectText(string morse, string expected)
        {
            var result = _translator.Translate(morse);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Translate_UnknownSymbol_ReturnsQuestionMark()
        {
            var result = _translator.Translate("..--");
            Assert.Contains("?", result);
        }
    }
}