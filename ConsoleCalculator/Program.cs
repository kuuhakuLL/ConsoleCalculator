using ConsoleCalculator.Calculators;
using ConsoleCalculator.Readers;
while(true) {
    Console.WriteLine("Введите выражение вида: число +-*/ число");
    Console.Write("Число можно вводить как десятичное например 5 ");
    Console.WriteLine("так и с дробной частью например 5,124");
    
    var expression = ConsoleReader.GetExpression();

    var result = Calculator.CalcExpression(expression);

    Console.WriteLine($"Результат выражения {expression[0]}: {result}");
}