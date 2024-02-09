
using Diamond.Lib;

try
{
    if (args.Length != 1 || args[0].Length != 1)
    {
        throw new ArgumentException("Please provide single argument that is a letter from an alphabet");
    }

    char input = args[0].ToUpper()[0];

    var generator = new DiamondGenerator();
    var diamond = generator.Generate(input);

    diamond.ToList().ForEach(line => Console.WriteLine(line));
}
catch (Exception ex)
{
    Console.WriteLine($"There was an error: {ex.Message}");
}