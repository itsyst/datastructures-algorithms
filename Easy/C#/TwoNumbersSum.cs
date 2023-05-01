using System.Collections.Generic;

public class TwoNumbersSum
{
  public static int[] TwoNumberSum1(int[] array, int targetSum)
  {
    for (var i = 0; i < array.Length - 1; i++)
    {
      var first = array[i];
      for (var j = i + 1; j < array.Length; j++)
      {
        var second = array[j];
        if (first + second == targetSum)
        {
          return new int[] { first, second };
        }
      }
    }
    return new int[0];
  }

  public static int[] TwoNumberSum2(int[] array, int targetSum)
  {
    HashSet<int> numbers = new HashSet<int>();
    foreach(var number in array){
      int complement = targetSum - number;
      if(numbers.Contains(complement))
        return new int[] { complement, number };
      numbers.Add(number);
    }

    return new int[0];
  }

  public static int[] TwoNumberSum3(int[] array, int targetSum)
  {
    int left = 0;
    int right = array.Length - 1;
    while(left < right){
      int currentSum = array[left] + array[right];
      if(currentSum < targetSum)
        left++;
      else if(currentSum > targetSum)
        right--;
      else
        return new int[] { array[left], array[right] };
    }

    return new int[0];
  }
}