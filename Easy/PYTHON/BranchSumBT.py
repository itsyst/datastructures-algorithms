# Initialize the class input of BST
class BST:
    def __init__(self, value):
        self.value = value
        self.left = None
        self.right = None


def get_branch_sum(tree):
    sum = []
    get_branch_sum_helper(tree, 0, sum)
    return sum;


def get_branch_sum_helper(tree, runningSum, sum):
    if tree is None:
        return

    endSum = runningSum + tree.value
    if tree.left is None and tree.right is None:
        sum.append(endSum)
        return
       
    get_branch_sum_helper(tree.left, endSum, sum)
    get_branch_sum_helper(tree.right, endSum, sum)


root = BST(10)
root.left = BST(5)
root.left.left = BST(2)
root.left.left.left = BST(1)
root.left.right = BST(5)
root.right = BST(15)
root.right.left = BST(13)
root.right.left.right = BST(14)
root.right.right = BST(22)

result = get_branch_sum(root)
print(result)
