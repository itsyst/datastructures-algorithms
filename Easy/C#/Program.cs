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
            var tree = new NodesDepthSum();
            tree.root = new NodesDepthSum.Node(1);
            tree.root.left = new NodesDepthSum.Node(2);
            tree.root.left.left = new NodesDepthSum.Node(4);
            tree.root.left.left.left = new NodesDepthSum.Node(8);
            tree.root.left.left.right = new NodesDepthSum.Node(9);
            tree.root.left.right = new NodesDepthSum.Node(5);
            tree.root.right = new NodesDepthSum.Node(3);
            tree.root.right.left = new NodesDepthSum.Node(6);
            tree.root.right.right = new NodesDepthSum.Node(7);

            var result = tree.nodeDepthSum(tree.root);
            Console.WriteLine(result);
        }
    }
}


