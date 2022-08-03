telephones = {}
##############
def searchTelephones(name):
    if (name in telephones.keys()):
        return name + "=" + telephones[name]
    else:
        return "Not found"
    #for k, v in telephones.items():
    #    if (name == k):
    #        k
    #        return (name+"="+v)
    #    else:
    #        continue
    #return "Not found" 

##########
times = int(input())
names_numbs = [input().split() for x in range(times)]
telephones = {k: v for k,v in names_numbs}
j=0
while True:
    try:
        inputName = input()
        response = searchTelephones(inputName)
        print (response)
    except EOFError:
        break