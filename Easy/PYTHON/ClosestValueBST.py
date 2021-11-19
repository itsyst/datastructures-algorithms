# Initialize the class input of BST
class BST:
    def __init__(self, value):
        self.value = value
        self.left = None
        self.right = None


def get_closest_value_in_DST(tree, target):
    return get_closest_value_in_DSTHelper(tree, target, tree.value)


def get_closest_value_in_DSTHelper(tree, target, closest):
    if tree is None:
        return closest
    if abs(target - closest) > abs(target - tree.value):
        closest = tree.value
    if target > tree.value:
        return get_closest_value_in_DSTHelper(tree.right, target, closest)
    if target < tree.value:
        return get_closest_value_in_DSTHelper(tree.left, target, closest)
    
    return closest

root = BST(10)
root.left = BST(5)
root.left.left = BST(2)
root.left.left.left = BST(1)
root.left.right = BST(5)
root.right = BST(15)
root.right.left = BST(13)
root.right.left.right = BST(14)
root.right.right = BST(22)

result = get_closest_value_in_DST(root, 20)
print(result)
