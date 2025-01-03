using System.Text.RegularExpressions;

namespace advent.io;

class LocationFile {

    private string filePath;

    public LocationFile(string path) {
        this.filePath = path;
    }

    public (List<int>, List<int>) GetLocationLists() {
        List<int> locationsList1 = new ();
        List<int> locationsList2 = new ();

        var lines = File.ReadLines(this.filePath);
        foreach(var line in lines) {
            MatchCollection matches = Regex.Matches(line, @"\d+");
            string[] result = matches.Cast<Match>()
                                    .Take(2)
                                    .Select(match => match.Value)
                                    .ToArray();
            locationsList1.Add(Int32.Parse(result[0]));
            locationsList2.Add(Int32.Parse(result[1]));
        }

        return (locationsList1, locationsList2);
    }

}