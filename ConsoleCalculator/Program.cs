using ConsoleCalculator.Calculators;
using ConsoleCalculator.Readers;

Console.WriteLine("Введите выражение вида: sqrt число или число +-*/ число");
Console.Write("Число можно вводить как десятичное например 5 ");
Console.WriteLine("так и с дробной частью например 5,124");
Console.WriteLine("Для выхода напишите выход");

while (true) {
    var expressionResult = ConsoleReader.GetExpression();

    if (expressionResult is { HasNeedExit: true }) {
        break;
    }

    if (expressionResult is not { group: var expressionGroup }) {
        continue;
    }

    var sing = string.IsNullOrEmpty(expressionGroup[1].Value) 
        ? expressionGroup[4].Value : expressionGroup[1].Value;
    
    var result = Calculator.CalcExpression(
        expressionGroup[2].Value, expressionGroup[5].Value, sing 
    );
    
    Console.WriteLine($"Результат выражения {expressionGroup[0]}: {result}");
}