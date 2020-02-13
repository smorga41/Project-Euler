
#6n+-1 method
import math
import time

starttime=time.time()
primes=[2,3]
i=1
n=0
total=5
maxim=2000000
while n<maxim:
    factors=0
    n=(6*i)-1
    x=0
    for prime in primes:
        if (n%prime==0):
            factors=factors+1
            break
        if prime>math.sqrt(n):
            break
    if (factors==0 and n<maxim):
        primes.append(n)
        total=total+n
        
#next number
    factors=0
    n=(6*i)+1
    for prime in primes:
        if (n%prime==0):
            factors=factors+1
            break
        if prime>math.sqrt(n):
            break
    if (factors==0 and n<maxim):
        primes.append(n)
        total=total+n
        
  
    i=i+1
endtime=time.time()
totaltime=endtime-starttime
print ("the code took ",totaltime," to run")
print("total: ",total)

            
        
            
    
