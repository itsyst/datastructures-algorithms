from typing import Counter


class Node:
    def __init__(self, value):
        self.value = value
        self.next = None
    
    def add_many(self, values):
        current = self
        while current.next is not None:
            current = current.next
        
        for value in values:
            current.next = Node(value)
            current = current.next
        
        return self

    def get_nodes(self):
        nodes = []
        current = self
        while current is not None:
            nodes.append(current.value)
            current = current.next
        
        return nodes

def remove_duplicates_from_linkedlist(node):
    current = node
    while current is not None and  current.next is not None:
        nextUniqueNode =  current.next
        while nextUniqueNode is not None and nextUniqueNode.value == current.value:
            nextUniqueNode = nextUniqueNode.next
            
        current.next = nextUniqueNode
        current = nextUniqueNode
                                           
    return node


input = Node(1)
values = [1, 1, 2, 3, 8, 8, 8, 9, 12]
input.add_many(values)

before = input.get_nodes()
print(before)

remove_duplicates_from_linkedlist(input)

after = input.get_nodes()
print(after)


