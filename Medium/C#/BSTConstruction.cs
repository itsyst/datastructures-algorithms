using System;

public class BSTConstruction
{
    public class BST
    {
        public int value;
        public BST left;
        public BST right;

        public BST(int value)
        {
            this.value = value;
        }

        public BST Insert(int value)
        {
            if (value < this.value)
            {
                if (left == null)
                {
                    left = new BST(value);
                }
                else
                {
                    left.Insert(value);
                }
            }
            else
            {
                if (right == null)
                {
                    right = new BST(value);
                }
                else
                {
                    right.Insert(value);
                }
            }
            return this;
        }

        public bool Contains(int value)
        {
            if (value < this.value)
            {
                if (left == null)
                {
                    return false;
                }
                else
                {
                    return left.Contains(value);
                }
            }
            else if (value > this.value)
            {
                if (right == null)
                {
                    return false;
                }
                else
                {
                    return right.Contains(value);
                }
            }
            else
            {
                return true;
            }
        }

        public BST Remove(int value, BST parentNode = null)
        {
            if (value < this.value)
            {
                if (left != null)
                {
                    left.Remove(value, this);
                }
            }
            else if (value > this.value)
            {
                if (right != null)
                {
                    right.Remove(value, this);
                }
            }
            else
            {
                if (left != null && right != null)
                {
                    this.value = right.GetMinValue();
                    right.Remove(this.value, this);
                }
                else if (parentNode == null)
                {
                    if (left != null)
                    {
                        this.value = left.value;
                        right = left.right;
                        left = left.left;
                    }
                    else if (right != null)
                    {
                        this.value = right.value;
                        left = right.left;
                        right = right.right;
                    }
                }
                else if (parentNode.left == this)
                {
                    parentNode.left = left != null ? left : right;
                }
                else if (parentNode.right == this)
                {
                    parentNode.right = left != null ? left : right;
                }
            }
            return this;
        }

        public int GetMinValue()
        {
            if (left == null)
            {
                return value;
            }
            else
            {
                return left.GetMinValue();
            }
        }
    }
}
