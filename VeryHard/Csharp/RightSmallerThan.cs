using System;
using System.Collections.Generic;

public class RightSmallerThan {
    public static List<int> RightSmallersThan(List<int> array) {
        int n = array.Count;
        List<int> counts = new List<int>(new int[n]);
        
        for (int i = 0; i < n; i++) {
            int count = 0;
            
            for (int j = i + 1; j < n; j++) {
                if (array[j] < array[i]) {
                    count++;
                }
            }
            
            counts[i] = count;
        }
        
        return counts;
    }
    
    public static void Main(string[] args) {
        // Example usage
        List<int> array = new List<int>() {5, 2, 6, 1};
        List<int> result = RightSmallersThan(array);
        
        Console.WriteLine(string.Join(", ", result)); // Output: 2, 1, 1, 0
    }
}
