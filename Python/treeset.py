# ENG: A binary search tree data structure, to which I added the following methods:
# __len__, height, min, max, prev and next.

class Node:
    def __init__(self, value):
        self.value = value
        self.left = None
        self.right = None

class TreeSet:
    def __init__(self):
        self.root = None

    def add(self, value):
        if not self.root:
            self.root = Node(value)
            return

        node = self.root
        while True:
            if node.value == value:
                return
            if node.value > value:
                if not node.left:
                    node.left = Node(value)
                    return
                node = node.left
            else:
                if not node.right:
                    node.right = Node(value)
                    return
                node = node.right

    def __contains__(self, value):
        if not self.root:
            return False

        node = self.root
        while node:
            if node.value == value:
                return True
            if node.value > value:
                node = node.left
            else:
                node = node.right

        return False

    def __repr__(self):
        items = []
        self.traverse(self.root, items)
        return str(items)

    def traverse(self, node, items):
        if not node:
            return
        self.traverse(node.left, items)
        items.append(node.value)
        self.traverse(node.right, items)

    def __len__(self):
        items = []
        self.traverse(self.root, items)

        return len(items)

    def height(self, node=None):
        if not node:
            if not self.root:
                return -1
            return self.height(self.root)

        result = 0
        if node.left:
            result = max(result, self.height(node.left) + 1)
        if node.right:
            result = max(result, self.height(node.right) + 1)
        return result

    def min(self):
        if not self.root:
            return None
        
        node = self.root
        while (True):
            if node.left:
                node = node.left
            else:
                return node.value

    def max(self):
        if not self.root:
            return None
        
        node = self.root
        while (True):
            if node.right:
                node = node.right
            else:
                return node.value

    def prev(self, x):
        nodes = []
        node = self.root
        
        while (True):
            nodes.append(node.value)
            if node.value < x:
                if node.right:
                    node = node.right
                else:
                    break
            else:
                if node.left:
                    node = node.left
                else:
                    break
        
        length = len(nodes)
        new_nodes = nodes.copy()

        for i in range(length):
            if nodes[i] >= x:
                new_nodes.remove(nodes[i])
        if len(new_nodes) == 0:
            return None
            
        return max(new_nodes)

    def next(self, x):
        nodes = []
        node = self.root
        
        while (True):
            nodes.append(node.value)
            if node.value > x:
                if node.left:
                    node = node.left
                else:
                    break
            else:
                if node.right:
                    node = node.right
                else:
                    break
        
        length = len(nodes)
        new_nodes = nodes.copy()

        for i in range(length):
            if nodes[i] <= x:
                new_nodes.remove(nodes[i])
        if len(new_nodes) == 0:
            return None

        return min(new_nodes)


if __name__ == "__main__":
    s = TreeSet()
    s.add(10)
    print(s.prev(9)) # None
    print(s.next(6)) # 10
    s.add(10)
    print(s.prev(10)) # None
    print(s.next(3)) # 10
    s.add(6)
    print(s.prev(7)) # 6
    print(s.next(6)) # 10
    s.add(5)
    print(s.prev(7)) # 6
    print(s.next(4)) # 5
    s.add(6)
    print(s.prev(2)) # None
    print(s.next(7)) # 10
    s.add(7)
    print(s.prev(2)) # None
    print(s.next(9)) # 10
    s.add(6)
    print(s.prev(7)) # 6
    print(s.next(7)) # 10
    s.add(5)
    print(s.prev(1))
    print(s.next(6))
    s.add(10)
    print(s.prev(2))
    print(s.next(8))
    s.add(4)
    print(s.prev(3))
    print(s.next(6))