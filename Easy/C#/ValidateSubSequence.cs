using System.Collections.Generic;
using System.Linq;

public class ValidateSubSequence
{

  // O(n) | O(1)
  public static bool IsValidSubsequence1(List<int> array, List<int> sequence)
  {
    int arrayIndex = 0;
    int sequenceIndex = 0;
    while (arrayIndex < array.Count() && sequenceIndex < array.Count())
    {
      if (array[arrayIndex] == sequence[sequenceIndex])
        sequenceIndex++;

      arrayIndex++;
    }

    return sequenceIndex == sequence.Count();
  }

  // O(n) | O(1)
  public static bool IsValidSubsequence2(List<int> array, List<int> sequence)
  {
    int sequenceIndex = 0;
    foreach (int number in array)
    {
      if (sequenceIndex == sequence.Count())
        break;
      if (sequence[sequenceIndex] == number)
        sequenceIndex++;
    }

    return sequenceIndex == sequence.Count();
  }

}