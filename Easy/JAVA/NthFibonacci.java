/**
 * NthFibonacci
 */
public class NthFibonacci {

    public static Integer GetNthFib(Integer n) {
        if (n <= 1)
            return 0;
        else if (n == 2)
            return 1;
        else
            return GetNthFib(n - 1) + GetNthFib(n - 2);
    }

    public static void main(String[] args) {
        System.out.println(GetNthFib(2));
    }
}