namespace ConsoleCalculator.Calculators;

public static class Calculator {
    public static string CalcExpression(string valueFirst, string valueSecond, string sign) =>
        sign switch {
            "*" => $"{ConvertValue(valueFirst) * ConvertValue(valueSecond)}",
            ":" or "/" => Divide(ConvertValue(valueFirst), ConvertValue(valueSecond)),
            "^" => $"{Math.Pow(ConvertValue(valueFirst), ConvertValue(valueSecond))}",
            "%" => $"{ConvertValue(valueFirst) % ConvertValue(valueSecond)}",
            "+" => $"{ConvertValue(valueFirst) + ConvertValue(valueSecond)}",
            "-" => $"{ConvertValue(valueFirst) - ConvertValue(valueSecond)}",
            "sqrt" => Sqrt(ConvertValue(valueFirst)),
            _ => "Произошла ошибка при вычислении выражения"
        };

    private static double ConvertValue(string value)
        => Convert.ToDouble(value);

    private static string Divide(double numberFirst, double numberSecond) 
        => numberSecond == 0 
            ? "Нельзя делить на ноль" 
            : $"{numberFirst / numberSecond}";

    private static string Sqrt(double value) 
        => value < 0 
            ? "Невозможно вычислить корень из отрицательного чилса" 
            : $"{Math.Sqrt(value)}";
}