# Annettuna on lista, jossa on n kokonaislukua. 
# Tehtäväsi on laskea, montako nousevaa alijonoa listassa on.
# (Algoritmille on aikaraja)

# ENG: Given is a list that has n integers.
# Task is to count, how many "rising" substrings the list has.
# (The algorithm had a time limit)

def find(t):
    result = {}

    for i in range(len(t)):
        result[i] = [t[i]]
        sequences = []

        for j in range(i):
            if t[i] > result[j][-1]:
                sequences.append(result[j] + [t[i]])

        for x in range(len(sequences)):
             if len(sequences[x]) > len(result[i]):
                    result[i] = sequences[x]

    longest = []
    for i in range(len(result)):
        if len(result[i]) > len(longest):
            longest = result[i]

    return longest

        
if __name__ == "__main__":
    print(find([1, 1, 2, 2, 3, 3])) # [1, 2, 3]
    print(find([1, 1, 1, 1])) # [1]
    print(find([5, 4, 3, 2, 1])) # [3]
    print(find([4, 1, 5, 6, 3, 4, 1, 8])) # [1, 3, 4, 8]    

    print(find([6, 1, 1, 9, 10, 4, 7, 5, 9, 6])) # [1, 4, 7, 9]
    print(find([7, 8, 2, 6, 10, 9, 10, 8, 9, 9])) # [7, 8, 9, 10]
    print(find([9, 6, 10, 10, 3, 6, 7, 6, 5, 7])) # [3, 6, 7]
    print(find([1, 1, 4, 4, 2, 5, 4, 8, 10, 6])) # [1, 2, 4, 8, 10]
    print(find([2, 8, 1, 6, 2, 5, 8])) # [1, 2, 5, 8]