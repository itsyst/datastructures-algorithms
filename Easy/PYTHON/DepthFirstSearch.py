class Node:
    def __init__(self, name):
        self.name = name
        self.children = []

    def add_child(self, name):
        self.children.append(Node(name))
        return self

    visited = []

    def depth_first_search(self, visited):
        self.visited.append(self.name)
        for child in self.children:
            if child.name not in self.visited:
                child.depth_first_search(child)

        return self.visited


graph = Node('A')
graph.add_child('B').add_child('C').add_child('D')
graph.children[0].add_child('E').add_child('F')
graph.children[2].add_child('G').add_child('H')
graph.children[0].children[1].add_child('I').add_child('J')
graph.children[2].children[0].add_child('K')


result = graph.depth_first_search(graph)
print(result)
