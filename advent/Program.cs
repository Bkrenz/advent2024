namespace advent;

using advent.io;
using advent.locations;

class Program
{
    static void Main(string[] args)
    {
        string locationsFilePath = "../input/day1.txt";

        if (!File.Exists(locationsFilePath))
            throw new FileNotFoundException($"Locations file {locationsFilePath} not found.");
        LocationFile locationFile = new LocationFile(locationsFilePath);

        var locationLists = locationFile.GetLocationLists();
        var list1 = new LocationList(locationLists.Item1);
        var list2 = new LocationList(locationLists.Item2);

        Console.WriteLine($"Distance = {list1.GetDistanceScore(list2)}");
        Console.WriteLine($"Similarity = {list2.GetSimilarityScore(list1)}");
    }
}
