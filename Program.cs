using uke1.Classes;

public class Program
{
    public static void Main(string[] args)
    {
        Repository<int> repoInt = new();
        Repository<string> repoString = new();
        Repository<double> repoDouble = new();

        repoDouble.Add(7.5);
        repoInt.Add(7);

        var doubleTimesInt = repoDouble.GetByIndex(0) * repoInt.GetByIndex(0);
        Console.WriteLine($"repDouble * repInt = {doubleTimesInt}");
        Console.WriteLine(repoDouble.GetByIndex(0));


    }
}