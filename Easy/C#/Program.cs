// See https://aka.ms/new-console-template for more informationusing System;
namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Two Number Sum
            /* int[] array = new int[] { 3, 5, -4, 8, 11, 1, -1, 6 };
               int targetSum = 10;
               int[] result = TwoNumbersSum.TwoNumberSum3(array, targetSum);
               Console.WriteLine("[{0}]", string.Join(", ", result));*/

            // Validate Sub Sequence
            /* List<int> array = new List<int> { 5, 1, 22, 25, 6, -1, 8, 10 };
                List<int> sequence = new List<int> { 1, 6, -1, 10 };
               Boolean result = ValidateSubSequence.IsValidSubsequence2(array, sequence);
               Console.WriteLine(result);*/

            // Sorted Squared Array
            /* int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
               int[] result = SortedSquaredArrays.SortedSquaredArray3(array);
               Console.WriteLine("[{0}]", string.Join(", ", result));*/

            // Tournament Winner
            /*List<List<string>> competitions = new List<List<string>> {
                new List<string>{"HTML", "Java" },
                new List<string>{"Java", "Python" },
                new List<string>{"Python", "HTML" },
                new List<string>{"C#", "Python" },
                new List<string>{"Java", "C#" },
                new List<string>{"C#", "HTML" },
                new List<string>{"SQL", "C#" },
                new List<string>{"HTML", "SQL"},
                new List<string>{"SQL", "Python" },
                new List<string>{"SQL", "Java" }
            };

            List<int> results = new List<int> { 0, 1, 1, 1, 0, 1, 0, 1, 1, 0 };
            string result = TournamentWinner.TournamentWinner1(competitions, results);
            Console.WriteLine("{0}", string.Join(", ", result));*/

            // Non - Constructible change
            /*int[] coins = new int[] { 1, 2, 5 };
            int result = NonConstructibleChange.NonConstructibleChanges(coins);
            Console.WriteLine("{0}", string.Join(", ", result));*/

            // Find Closest Value In BST        
            /*var tree = new BSTree();
            var values = new int[] { 10, 5, 2, 1, 5, 15, 13, 14, 22 };
            foreach (var value in values)
            {
                tree.insert(value);
            }

            var result = tree.FindClosestValueInBST(tree.root, 21);
            Console.WriteLine("Closest Value: " + result);*/

            // Branchs sum of binary tree
            // var tree = new BTree();
            // tree.root = new Node(1);
            // tree.root.left = new Node(2);
            // tree.root.left.left = new Node(4);
            // tree.root.left.right = new Node(5);
            // tree.root.left.right.left = new Node(10);
            // tree.root.left.left.left = new Node(8);
            // tree.root.left.left.right = new Node(9);
            // tree.root.right = new Node(3);
            // tree.root.right.left = new Node(6);
            // tree.root.right.right = new Node(7);

            // var sums = tree.BranchSums(tree.root);
            // Console.WriteLine("{0}", string.Join(", ", sums));

            // Nodes Depth Sum
            /*var tree = new NodesDepthSum();
            tree.root = new NodesDepthSum.Node(1);
            tree.root.left = new NodesDepthSum.Node(2);
            tree.root.left.left = new NodesDepthSum.Node(4);
            tree.root.left.left.left = new NodesDepthSum.Node(8);
            tree.root.left.left.right = new NodesDepthSum.Node(9);
            tree.root.left.right = new NodesDepthSum.Node(5);
            tree.root.right = new NodesDepthSum.Node(3);
            tree.root.right.left = new NodesDepthSum.Node(6);
            tree.root.right.right = new NodesDepthSum.Node(7);

            ///var result = tree.nodeDepthSum(tree.root);
            var result = tree.nodeDepthSumIterator(tree.root);
            Console.WriteLine(result);*/

            // Depth First Search
            // var graph = new Graph.Node("A");
            // graph.AddChild("B").AddChild("C").AddChild("D");
            // graph.children[0].AddChild("E").AddChild("F");
            // graph.children[0].children[1].AddChild("I").AddChild("J");
            // graph.children[2].AddChild("G").AddChild("H");
            // graph.children[2].children[0].AddChild("K");

            // var result = graph.DepthFirstSearch(graph);
            // Console.WriteLine("{0}", string.Join(", ", result)); 

            //Minimum waiting Time
            // int[] queries = new int[] {17, 4, 3 };
            // var time = WaitingTime.MinimumWaitingTime2(queries);
            // Console.WriteLine(time);

            // Class Photos
            // var redRow = new List<int> { 19, 19, 21, 1, 1, 1, 1, 1 };
            // var blueRow = new List<int> { 20, 5, 4, 4, 4, 4, 4, 4 };
            // var result = RangeStudents.RowRange(redRow, blueRow);
            // Console.WriteLine("{0}", string.Join(", ", result));

            // Tandem Bicycle.
            // var redTeam = new int[] {3, 4, 4, 1, 1, 8, 9 };
            // var blueTeam = new int[] {9, 8, 2, 2, 3, 5, 6 };
            // var fastest = false;
            // var result = TotalSpeedBicycle.TandemBicycle(redTeam, blueTeam, fastest);
            // Console.WriteLine("{0}", string.Join(", ", result));

            // Remove Duplicates From LinkedList
            // var node = new LinkedList.Node(1);
            // node.next = new LinkedList.Node(3);
            // node.next.next = new LinkedList.Node(4);
            // node.next.next.next = new LinkedList.Node(4);
            // node.next.next.next.next = new LinkedList.Node(4);
            // node.next.next.next.next.next = new LinkedList.Node(5);
            // node.next.next.next.next.next.next = new LinkedList.Node(6);
            // node.next.next.next.next.next.next.next = new LinkedList.Node(6);

            // var ldList = new LinkedList();
            // var nodes = ldList.getNodes(node);
            // Console.WriteLine("{0}", string.Join(", ", nodes));
            // var removed = ldList.GetUniqueNodesFromLinkedList(node);
            //  Console.WriteLine("{0}", string.Join(", ", removed));

            // LinkedList linkedList = new LinkedList();
            // LinkedList.Node input = new LinkedList.Node(1);
            // List<int> values = new List<int> { 12,12 };
            // LinkedList.Node nodes = linkedList.addMany(input, values);

            // linkedList.RemoveDuplicatesFromLinkedList(input);

            // var removed = linkedList.getNodes(input);
            // Console.Write("{0} ", string.Join(", ", removed));

            // Nth Fibonacci
            // var value = Fibonacci.GetNthFib(0);
            // Console.WriteLine(value);

            // Product Sum
            // List<object> numbers = new List<object>{ 
            //     5,2,new List<object>{7,-1}, 3,new List<object>{6, new List<object>{-13,8},4}
            // };
            // int result = ProductSum.ProductSummation(numbers);
            // Console.WriteLine(result);

            // Binary Search Tree
            // int[] array = new int[] { 0, 1, 21, 33, 45, 45, 61, 71, 72, 73 };
            // var tree = new BinarySearchTree();
            // foreach (var item in array)
            // {
            //     tree.insert(item);
            // }
            // //var result = tree.indexOf(33);
            // //var result = tree.BinarySearch(array,83);
            // var result = tree.BinarySearchRec(array, 33);
            // Console.WriteLine(result);

            // Find Three Largest Numbers
            // int[] numbers = new int[] { 141, 1, 17, -7, -17, -27, 18, 541, 8, 7, 7 };
            // int[] result = ThreeLargestNumbers.FindThreeLargetNumbers(numbers);
            // System.Console.WriteLine("{0}", string.Join(", ", result));

            //Bubble Sort
            // int[] numbers = new int[] { 141, 0, 12, -1, -10, -27, 18, 233, 8, 7, 7 };
            // int[] result = BubbleSort.Sort(numbers);
            // System.Console.WriteLine("{0}", string.Join(", ", result));

            //Insertion  Sort
            // int[] numbers = new int[] { 141, 0, 12, -1, -10, -27, 18, 233, 8, 7, 7 };
            // int[] result = InsertionSort.Sort(numbers);
            // System.Console.WriteLine("{0}", string.Join(", ", result));

            //Selection  Sort
            // int[] numbers = new int[] { 141, 0, 12, -1, -10, -27, 18, 233, 8, 7, 7 };
            // int[] result = SelectionSort.Sort(numbers);
            // System.Console.WriteLine("{0}", string.Join(", ", result));

            // Palindrome string check
            // String str = "123321";
            // Boolean result = PalindromeCheck.IsPalindrome5(str);
            // System.Console.WriteLine(result);

            // Caesar Cipher Encryption
            string str = "xyz";
            string result = CaesarCipherEncryption.Encrypt(str,1);
            Console.WriteLine(result);
        }
    }
}


