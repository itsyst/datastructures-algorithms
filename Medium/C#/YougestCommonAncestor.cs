using System;

public class YoungestCommonAncestor
{
    public static AncestralTree GetYoungestCommonAncestor(AncestralTree topAncestor, AncestralTree descendantOne, AncestralTree descendantTwo)
    {
        int depthOne = GetDescendantDepth(descendantOne, topAncestor);
        int depthTwo = GetDescendantDepth(descendantTwo, topAncestor);

        while (depthOne > depthTwo)
        {
            descendantOne = descendantOne.ancestor;
            depthOne--;
        }

        while (depthTwo > depthOne)
        {
            descendantTwo = descendantTwo.ancestor;
            depthTwo--;
        }

        while (descendantOne != descendantTwo)
        {
            descendantOne = descendantOne.ancestor;
            descendantTwo = descendantTwo.ancestor;
        }

        return descendantOne;
    }

    private static int GetDescendantDepth(AncestralTree descendant, AncestralTree topAncestor)
    {
        int depth = 0;

        while (descendant != topAncestor)
        {
            descendant = descendant.ancestor;
            depth++;
        }

        return depth;
    }

    public class AncestralTree
    {
        public char name;
        public AncestralTree ancestor;

        public AncestralTree(char name)
        {
            this.name = name;
            this.ancestor = null;
        }

        // This method is for testing only.
        public void AddAsAncestor(AncestralTree[] descendants)
        {
            foreach (AncestralTree descendant in descendants)
            {
                descendant.ancestor = this;
            }
        }
    }
}
