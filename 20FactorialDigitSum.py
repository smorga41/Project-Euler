factorial=100
n=factorial
total=1
#calculating the factorial
while n>0:
    total=total*n
    n=n-1
print(total)
#calculating the sum of digits
strtotal=str(total) #converts to string
totalchar=[x for x in strtotal] #splits string into array of characters
print(totalchar)
sum=0
i=len(totalchar)
while i>0: #iterates through length of array
    sum=sum+int(totalchar[i-1])#converts characters in the string to integers and adds them to the sum
    i=i-1
print(sum)

