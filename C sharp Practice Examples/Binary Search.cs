using System;

class Program {
    static void Main(string[] args) {
        // Initialize an array of integers
        int[] arr = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
        
        // Initialize the element we want to search
        int x = 9;
        
        // Call the BinarySearch function 
        int result = BinarySearch(arr, x);
        if (result == -1) {
            Console.WriteLine("Element not present in the array");
        }
        else {
            Console.WriteLine("Element found at index " + result);
        }
    }
    // BinarySearch function 
    static int BinarySearch(int[] arr, int x) {
        // Initialize the left and right indices to the first and last indices of the array
        int left = 0;
        int right = arr.Length - 1;
        
        
        while (left <= right) {
            // Calculate the middle index 
            int mid = left + (right - left) / 2;
            if (arr[mid] == x) {
                return mid;
            }
            if (arr[mid] < x) {
                left = mid + 1;
            }
            else {
                right = mid - 1;
            }
        }
        // If we exhaust the search and do not find the element, return -1
        return -1;
    }
}