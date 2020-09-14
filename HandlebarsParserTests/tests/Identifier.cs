using Xunit;
using HandlebarsParser;

namespace MyFirstUnitTests
{
    public class Tests
    {
        [Fact]
        public void PassingTest()
        {
            var expression = "{{identifier}}";
            var parsed = HandlebarsExpression.Parse(expression);

            Assert.Equal(typeof(HandlebarsIdentifier), parsed.GetType());
            Assert.Equal("identifier", ((HandlebarsIdentifier)parsed).Name);

            expression = "{{  identifier }}";
            parsed = HandlebarsExpression.Parse(expression);

            Assert.Equal(typeof(HandlebarsIdentifier), parsed.GetType());
            Assert.Equal("identifier", ((HandlebarsIdentifier)parsed).Name);

            expression = "{{ ident1f13_r}}";
            parsed = HandlebarsExpression.Parse(expression);

            Assert.Equal(typeof(HandlebarsIdentifier), parsed.GetType());
            Assert.Equal("ident1f13_r", ((HandlebarsIdentifier)parsed).Name);
        }

        int Add(int x, int y)
        {
            return x + y;
        }
    }
}