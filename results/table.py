f = open(input("Enter name of file: ")+".txt", "w")
string = input("Text: ")
table = string.split("_*_")

for x in table[:30]:
    f.write(x+"\n")
f.close()
