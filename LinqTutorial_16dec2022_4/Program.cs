namespace LinqTutorial_16dec2022_4;
//method syntax vs query syntax
internal class Program
{
    static void Main(string[] args)
    {
        var numbers = new[] { 4, 2, 7, 10, 12, 5, 4, 2 };
        var smallOrderedNumbersMethodSyntax =
            numbers
            .Where(number => number < 10)
            .OrderBy(number => number)
            .Distinct();

        Console.WriteLine(string.Join(", ", smallOrderedNumbersMethodSyntax));


        var smallOrderedNumbersQuerySyntax =
            (from number in numbers
            where number < 10
            orderby number
            select number).Distinct();
        /*It's possible to mix around query syntax and method syntax*/

        Console.WriteLine(string.Join(", ", smallOrderedNumbersQuerySyntax));
    }
}