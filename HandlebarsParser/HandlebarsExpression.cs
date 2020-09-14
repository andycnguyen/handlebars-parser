using System;
using System.Collections.Generic;
using Sprache;

namespace HandlebarsParser
{
    public abstract class HandlebarsExpression
    {
        public static HandlebarsExpression Parse(string expression) =>
            HandlebarsGrammar.HandlebarsExpression.Parse(expression);
    }

    public class HandlebarsIdentifier : HandlebarsExpression
    {
        public string Name { get; }

        public HandlebarsIdentifier(string name)
        {
            this.Name = name;
        }
    }

    public class HandlebarsIf : HandlebarsExpression
    {
        public HandlebarsExpression Antecedent { get; }

        public HandlebarsIf(HandlebarsExpression antecedent)
        {
            this.Antecedent = antecedent;
        }
    }

    public class HandlebarsHelper : HandlebarsExpression
    {
        public IReadOnlyList<HandlebarsExpression> Arguments { get; }

        public HandlebarsHelper(IReadOnlyList<HandlebarsExpression> argument)
        {
            this.Arguments = Arguments;
        }
    }
}
