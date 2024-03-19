using System.Text.RegularExpressions;

namespace ConsoleCalculator.Readers;

public static class ConsoleReader {
    private static readonly Regex RegExpr = new(@"([+-]?\d+(\,\d+)?)\s?([\*\/+-])\s?([+-]?\d+(\,\d+)?)");
    public static GroupCollection GetExpression() {
        var expr = Console.ReadLine();

        while (!CheckExpr(expr)) {
            Console.WriteLine("Введено не верное выражение повторите попытку");
            
            expr = Console.ReadLine();
        }
        
        return RegExpr.Match(expr!).Groups;
    }

    private static bool CheckExpr(string? expr) =>
        expr is { } && RegExpr.IsMatch(expr);
}