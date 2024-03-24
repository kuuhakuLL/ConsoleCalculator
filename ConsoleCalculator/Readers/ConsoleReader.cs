using System.Text.RegularExpressions;

namespace ConsoleCalculator.Readers;

public record ExprResult(bool HasNeedExit, GroupCollection? group);

public static class ConsoleReader {
    private const string Pattern = @"(sqrt)?\s?([+-]?\d+(\,\d+)?)\s?([\*\/+-:^%])?\s?([+-]?\d+(\,\d+)?)?";
    
    private static readonly Regex RegExpr = new(Pattern);
    
    public static ExprResult GetExpression() {
        var expr = Console.ReadLine();

        if (expr.Equals("выход")) {
            return new ExprResult(HasNeedExit: true, group: null);
        }
        
        while (!CheckExpr(expr)) {
            Console.WriteLine("Введено не верное выражение повторите попытку");
            
            expr = Console.ReadLine();
        }
        
        return new ExprResult(HasNeedExit: false, group: RegExpr.Match(expr!).Groups);
    }

    private static bool CheckExpr(string? expr) =>
        expr is { } && RegExpr.IsMatch(expr);
}