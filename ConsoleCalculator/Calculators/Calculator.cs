using System.Text.RegularExpressions;

namespace ConsoleCalculator.Calculators;

public class Calculator {
    public static double CalcExpression(GroupCollection groups) =>
        groups[3] switch {
            { Value: "+" } => ConvertValue(groups[1]) + ConvertValue(groups[4]),
            { Value: "-" } => ConvertValue(groups[1]) - ConvertValue(groups[4]),
            { Value: "*" } => ConvertValue(groups[1]) * ConvertValue(groups[4]),
            { Value: "/" } => ConvertValue(groups[1]) / ConvertValue(groups[4]),
            _ => throw new ArgumentOutOfRangeException()
        };

    private static double ConvertValue(Group value)
        => Convert.ToDouble(value.Value);
}