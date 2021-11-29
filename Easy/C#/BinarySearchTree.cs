class BinarySearchTree
{
    public class Node
    {
        public int value;
        public Node left;
        public Node right;

        public Node(int value)
        {
            this.value = value;
        }
    }

    public Node root;

    public void insert(int value)
    {
        var node = new Node(value);
        if (root == null)
        {
            root = node;
            return;
        }

        var current = root;
        while (true)
        {
            if (value < current.value)
            {
                if (current.left == null)
                {
                    current.left = node;
                    break;
                }
                current = current.left;
            }
            else
            {
                if (current.right == null)
                {
                    current.right = node;
                    break;
                }
                current = current.right;
            }
        }
    }

    public int indexOf(int target)
    {
        var current = root;
        var index = -1;
        while (current != null)
        {
            index++;
            if (target < current.value)
                current = current.left;
            else if (target > current.value)
                current = current.right;
            else
                return index;
        }

        return -1;
    }

    // O(log(n)) time | O(1) space
    public int BinarySearch(int[] array, int target)
    {
        int left = 0;
        int right = array.Length - 1;
        while (left <= right)
        {
            int middle = (left + right) / 2;

            if (target == array[middle])
                return middle;
            if (target < array[middle])
                right = middle - 1;
            else
                left = middle + 1;
        }
        return -1;
    }

    // O(log(n)) time | O(log(n)) space
    public int BinarySearchRec(int[] array, int target)
    {
        return BinarySearchRecHelper(array, target, 0, array.Length - 1);
    }

    private int BinarySearchRecHelper(int[] array, int target, int left, int right)
    {
        if (left > right)
            return -1;

        var middle = (left + right) / 2;

        if (target == array[middle])
            return middle;

        if (target < array[middle])
            return BinarySearchRecHelper(array, target, left, middle - 1);

        return BinarySearchRecHelper(array, target, middle + 1, right);
    }
}