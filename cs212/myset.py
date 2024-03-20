set1 = {'a','p','p','l','e'}
set2 = {'c','h','e','r','r','y'}
unionset = set1.union(set2)
intersectionset = set1.intersection(set2)
differenceset = set1.difference(set2)
### Guess what the print statement will be. Add it at the end.
print(set1) #
print(set2) #
print(unionset) #
print(intersectionset) #
print(differenceset) #
set1.remove('p')
print(set1) #
set1.add('y')
print(set1) #
print('h' in unionset) #