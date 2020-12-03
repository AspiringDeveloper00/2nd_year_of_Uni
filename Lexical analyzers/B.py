import random

rules={
    "A": ["(B)"],
    "B": ["CD"],
    "C": ["v","A"],
    "D": ["-B", "+B",""]    
    };

nonT=["A","B","C","D"]
sentence="A"
print(sentence)
print ("\n") 

def sentence_nonT(sentence):
    sentenceletters=[]
    a=sentence.find("A")
    b=sentence.find("B")
    c=sentence.find("C")
    d=sentence.find("D")
    if a!=-1:
        sentenceletters.append("A")
    if b!=-1:
        sentenceletters.append("B")
    if c!=-1:
        sentenceletters.append("C")
    if d!=-1:
        sentenceletters.append("D")
    return sentenceletters

def replacer(s, newstring, index, nofail=False):
    # raise an error if index is outside of the string
    if not nofail and index not in range(len(s)):
        raise ValueError("index outside given string")

    # if not erroring, but the index is still not in the correct range..
    if index < 0:  # add it to the beginning
        return newstring + s
    if index > len(s):  # add it to the end
        return s + newstring

    # insert the new string between "slices" of the original
    return s[:index] + newstring + s[index + 1:]


array=sentence_nonT(sentence)
while True:
    if len(array)==0:
        break;
    else:
        print(array)
        #Choosing randomly a letter that exists in the sentence to replace it using the rules
        letter=random.choice(array)
        print(letter)
        #Getting the position of the first (from left to right) instance of the letter we chose above
        x=sentence.find(letter)
        print(x)
        #Choosing randomly the appropriate rule about the particular letter
        y=random.choice(rules[letter])
        print(y)
        #We know the letter we want to replace, its location and the rule, so we replace it
        sentence=replacer(sentence,y,x)
        #Print the new sentence with the replaced letter
        print(sentence)
        print ("\n")
        #Create a list containing the letters that exist in the sentence and they are non terminal 
        array=sentence_nonT(sentence)
