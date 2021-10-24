package JAVA;

import java.util.*;

class ValidateSubSequence {

  public static boolean isValidSubsequence1(List<Integer> array, List<Integer> sequence) {
    int arrayIndex = 0;
    int sequenceIndex = 0;

    while (arrayIndex < array.size() && sequenceIndex < sequence.size()) {
      if (array.get(arrayIndex).equals(sequence.get(sequenceIndex)))
        sequenceIndex++;

      arrayIndex++;
    }

    return sequenceIndex == sequence.size();
  }

  public static boolean isValidSubsequence2(List<Integer> array, List<Integer> sequence) {
    int sequenceIndex = 0;
    for (Integer number : array) {
      if (sequenceIndex == sequence.size())
        break;
      if (sequence.get(sequenceIndex).equals(number))
        sequenceIndex++;
    }
    return sequenceIndex == sequence.size();
  }

  public static void main(String[] args) {
    // List<Integer> array = new ArrayList<>();
    // array.add(5);
    // array.add(1);
    // array.add(22);
    // array.add(25);
    // array.add(6);
    // array.add(-1);
    // array.add(8);
    // array.add(10);
    List<Integer> array = List.of(5,1,22,25,6,-1,8,10);

    // List<Integer> sequence = new ArrayList<>();
    // sequence.add(1);
    // sequence.add(6);
    // sequence.add(-1);
    // sequence.add(10);
    List<Integer> sequence = List.of(1, 6, -1, 10);

    boolean result = isValidSubsequence1(array, sequence);
    System.out.println(result);
  }
}
