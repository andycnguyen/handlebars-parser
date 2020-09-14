using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Sprache;

namespace HandlebarsParser
{
    internal static class HandlebarsGrammar
    {
        private static readonly Parser<HandlebarsIdentifier> HandlebarsIdentifier =
            from open in Parse.String("{{")
            from leadingSpace in Parse.WhiteSpace.Many()
            from first in Parse.Letter.Once().Text()
            from rest in Parse.CharExcept("} ").Many().Text()
            from trailingSpace in Parse.WhiteSpace.Many()
            from close in Parse.String("}}")
            select new HandlebarsIdentifier(first + rest);

        public static readonly Parser<HandlebarsExpression> HandlebarsExpression =
            HandlebarsIdentifier;
    }
}