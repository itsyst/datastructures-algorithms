package JAVA;

import java.util.*;

class TwoNumberSum {
  // O(n^2)
  public static int[] twoNumberSum1(int[] array, int targetSum) {
    for (int i = 0; i < array.length; i++) {
      for (int j = 0; j < array.length; j++)
        if (i != j)
          if (array[i] + array[j] == targetSum)
            return new int[] { array[j], array[i] };
    }
    return new int[0];
  }

  // O(n^2) | O(1) space
  public static int[] twoNumberSum2(int[] array, int targetSum) {
    for (int i = 0; i < array.length - 1; i++) {
      int first = array[i];
      for (int j = i + 1; j < array.length; j++) {
        int second = array[j];
        if (first + second == targetSum) {
          return new int[] { first, second };
        }
      }
    }
    return new int[0];
  }

  // O(n) | O(n) space
  public static int[] twoNumberSum3(int[] array, int targetSum) {
    Set<Integer> numbers = new HashSet<>();
    for (int number : array) {
      int complement = targetSum - number;
      if (numbers.contains(complement))
        return new int[] { number, complement };
      numbers.add(number);
    }
    return new int[0];
  }

  // O(n log(n)) | O(1) space
  public static int[] twoNumberSum4(int[] array, int targetSum) {
    Arrays.sort(array);
    int left = 0;
    int right = array.length - 1;
    while (left < right) {
      int currentSum = array[left] + array[right];
      if (currentSum < targetSum)
        left++;
      else if (currentSum > targetSum)
        right--;
      else if (currentSum == targetSum)
        return new int[] { array[right], array[left] };
    }
    return new int[0];
  }

  // O(n)
  public static int[] twoNumberSum5(int[] array, int targetSum) {
    Map<Integer, Integer> map = new HashMap<>();
    for (int i = 0; i < array.length; i++) {
      int complement = targetSum - array[i];
      if (map.containsKey(complement)) {
        return new int[] { array[i], complement };
      }
      map.put(array[i], complement);
    }
    return new int[0];
  }

  public static void main(String[] args) {
    int[] array = new int[] { 3, 5, -4, 8, 11, 1, -1, 6 };
    int targetSum = 10;
    int[] result = twoNumberSum4(array, targetSum);
    System.out.println(Arrays.toString(result));
  }
}
