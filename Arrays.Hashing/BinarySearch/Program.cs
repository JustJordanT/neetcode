int[] sortedArray = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };
int target = 7;

//int index = BinarySearch(sortedArray, target);
//int index = BinarySearchRecursive(sortedArray, target, 0, sortedArray.Length -1);
int index = MyClass.BinarySearch(sortedArray, target);

if (index != -1)
    Console.WriteLine($"Element found at index {index}.");
else
    Console.WriteLine("Element not found.");
return;

// <summary>
// Binary search algorithm
// Returns the index of the target element if found, otherwise returns -1
// Time complexity: O(log n)
// Space complexity: O(1)
// where n is the number of elements in the array
// and log is the logarithm function
// <summary>
static int BinarySearch(int[] array, int target)
{
    int left = 0; // beginning index
    int right = array.Length - 1; // ending index

    while (left <= right)
    {
        int mid = left + (right - left) / 2;  // middle array initializer

        Console.WriteLine($"MID: {array[mid]}");

        if (array[mid] == target)
            return mid; // Element found

        if (array[mid] < target)
            left = mid + 1; // Search right half
        else
            right = mid - 1; // Search left half
    }

    return -1; // Element not found
}




// Recursive binary search algorithm
// Returns the index of the target element if found, otherwise returns -1
static int BinarySearchRecursive(int[] array, int target, int left, int right)
{
    if (left > right)
        return -1; // Element not found
    int mid = left + (right - left) / 2;
    
    if (array[mid] == target)
        return mid; // Element found

    if (array[mid] < target)
        return BinarySearchRecursive(array, target, mid + 1, right); // Search right half

    return BinarySearchRecursive(array, target, left, mid - 1); // Search left half
}