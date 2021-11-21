class BTree:
    def __init__(self, value):
        self.value = value
        self.left = None
        self.right = None


def get_nodes_depth_sum(root):
    if root is None:
        return

    return get_nodes_depth_sum_helper(root, 0)


def get_nodes_depth_sum_helper(root, height):
    if root is None:
        return 0

    return height + get_nodes_depth_sum_helper(root.left, height + 1) + get_nodes_depth_sum_helper(root.right, height + 1)


root = BTree(10)
root.left = BTree(5)
root.left.left = BTree(2)
root.left.left.left = BTree(1)
root.left.right = BTree(5)
root.right = BTree(15)
root.right.left = BTree(13)
root.right.left.right = BTree(14)
root.right.right = BTree(22)

result = get_nodes_depth_sum(root)
print(result)
