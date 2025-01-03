using System.Collections;
using System.Dynamic;

namespace advent.locations;

class LocationList {

    private List<int> locations;

    public LocationList(List<int> locs) {
        this.locations = locs;
        this.locations.Sort();
    }

    public int GetLocationAtIndex(int index) {
        return this.locations[index];
    }

    public int GetDistanceScore(LocationList list2) {
        int distance = 0;

        for (int i=0; i < this.locations.Count; i++) {
            distance += Math.Abs(this.GetLocationAtIndex(i) - list2.GetLocationAtIndex(i));
        }

        return distance;
    }

    public int GetSimilarityScore(LocationList list2) {
        int score = 0;

        Dictionary<int, int> locs = new ();
        foreach (var i in this.locations) {
            if (locs.ContainsKey(i)) {
                locs[i] += 1;
            }
            else {
                locs.Add(i, 1);
            }
        }

        int val;
        for (int i = 0; i < this.locations.Count; i++) {
            val = list2.GetLocationAtIndex(i);
            if (locs.ContainsKey(val)) {
                score += val * locs[val];
            }
        }

        return score;
    }



}