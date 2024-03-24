import timeit
class BSTNode:
    def __init__(self, data=None):
        # Constructor to the BSTNode class
        self.left = None
        self.right = None
        self.data = data

    def insert(self, data):
        # function for inserting data to the BSTNode class
        if not self.data:
            self.data = data
            return
        if self.data == data:
            return
        if data < self.data:
            if self.left:
                self.left.insert(data)
                return
            self.left = BSTNode(data)
            return
        if self.right:
            self.right.insert(data)
            return
        self.right = BSTNode(data)

    def traverse(self,data):
        # for printing the contents of the BSTNode class as a list
        if self.left is not None:
            self.left.traverse(data)
        if self.right is not None:
            self.right.traverse(data)
        if self.data is not None:
            data.append(self.data)
        return data
    
    def exists(self, data):
        if data == self.data:
            return True
        if data < self.data:
            if self.left == None:
                return False
            return self.left.exists(data)
        if self.right == None:
            return False
        return self.right.exists(data)

set1 = {'a','p','p','l','e'}
set2 = {'c','h','e','r','r','y'}
unionset = set1.union(set2)
BST = BSTNode()
### Problem:
### Convert the unionset into a binary tree
### Store the binary tree into a list called mylist
### Sort the list



### End of Problem
print(BST.traverse([]))
print(unionset)
print(mylist) # ['a', 'c', 'e', 'h', 'l', 'p', 'r', 'y']
print(BST.exists('h'))
print('h' in unionset)
print('h' in mylist)
print(BST.exists('t'))
print('t' in unionset)
print('t' in mylist)
time1 = timeit.timeit("BST.exists('h')", number=10, globals=globals()) / 10 * 1000
time2 = timeit.timeit("'h' in unionset", number=10, globals=globals()) / 10 * 1000
time3 = timeit.timeit("'h' in mylist", number=10, globals=globals()) / 10 * 1000
time1a = timeit.timeit("BST.exists('t')", number=10, globals=globals()) / 10 * 1000
time2a = timeit.timeit("'t' in unionset", number=10, globals=globals()) / 10 * 1000
time3a = timeit.timeit("'t' in mylist", number=10, globals=globals()) / 10 * 1000
print("Time comparison between searching in BST vs set vs list")
print("{:>15.5f}{:>15.5f}{:>15.5f}".format(time1, time2, time3))
print("{:>15.5f}{:>15.5f}{:>15.5f}".format(time1a, time2a, time3a))