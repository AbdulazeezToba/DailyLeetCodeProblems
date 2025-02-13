using System;
using System.Collections.Generic;

public class RandomizedSet {
    private Dictionary<int, int> dict;
    private List<int> list;
    private Random random;

    public RandomizedSet() {
        dict = new Dictionary<int, int>(); // Maps value to its index in list
        list = new List<int>(); // Stores values for quick access
        random = new Random(); // Random number generator
    }
    
    public bool Insert(int val) {
        if (dict.ContainsKey(val)) return false; // If value exists, return false
        
        dict[val] = list.Count; // Store index of new value
        list.Add(val); // Add value to list
        return true;
    }
    
    public bool Remove(int val) {
        if (!dict.ContainsKey(val)) return false; // If value doesn't exist, return false
        
        int lastElement = list[^1]; // Get last element
        int idx = dict[val]; // Get index of element to remove
        
        // Swap the element to be removed with the last element
        list[idx] = lastElement;
        dict[lastElement] = idx;
        
        // Remove last element (previously swapped)
        list.RemoveAt(list.Count - 1);
        dict.Remove(val);
        
        return true;
    }
    
    public int GetRandom() {
        int randomIndex = random.Next(list.Count);
        return list[randomIndex];
    }
}
