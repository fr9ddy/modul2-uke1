using uke1.Classes;

public class Program
{
    public static void Main(string[] args)
    {
        Repository<int> repositoryInt = new Repository<int>();
        Repository<string> repositoryString = new Repository<string>();
        Repository<double> repositoryDouble = new Repository<double>();

        repositoryDouble.Add(7.5);
        repositoryInt.Add(7);

        var doubleTimesInt = repositoryDouble.GetByIndex(0) * repositoryInt.GetByIndex(0);
        Console.WriteLine($"repDouble * repInt = {doubleTimesInt}");
    }
}