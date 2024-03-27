set1 = {'a','p','p','l','e'}
set2 = {'c','h','e','r','r','y'}
unionset = set1.union(set2)
intersectionset = set1.intersection(set2)
differenceset = set1.difference(set2)
### Guess what the print statement will be. Add it at the end.
print(set1) #{'e', 'l', 'a', 'p'}
print(set2) #{'r', 'c', 'y', 'e', 'h'}
print(unionset) #{'r', 'y', 'l', 'h', 'a', 'p', 'c', 'e'} 
print(intersectionset) #{'e'}
print(differenceset) #{'l', 'a', 'p'}
set1.remove('p')
print(set1) #{'e', 'l', 'a'}
set1.add('y')
print(set1) #{'y', 'l', 'a', 'e'}
print('h' in unionset) #True