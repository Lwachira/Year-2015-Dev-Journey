numTry = int(raw_input("Please enter the number of tries you would like: "))
stringList = []
for i in  xrange(0,numTry):
    name = raw_input("Please enter your name: ")
    if name <> "John":
       stringList.append(name)

print stringList
