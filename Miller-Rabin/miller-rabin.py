import random
import math

k=0
while k <= 1:
    k = int(input('Give an integer greater than 1! '))

prime=0
while prime == 0:
     n=random.randint(2**(k-1) , 2**k)

     #Step 1:Having n, we now have to find the p and m in the equation n-1=2^p*m

     p=1
     while True:
         if ((n-1)/ 2**(p+1)).is_integer():
             p+=1
         else:
             break
     m = int((n-1) /2**p)

     #Step 2:Pick a number a where 1<a<n-1
     
     #a=random.randint(1 , n-1)
     a=2 #Picking a=2 by default cause is the easiest calculatable and fast to work with.

     #Step 3: Compute b0=a^m(modn), where bi=(bi-1)^2

     #If b0=+1 or b0=-1 then n is (probably) prime
     #If b0 has a different value (other than +1 or -1) then we calculate b1 which is b1=b0^2(modn). For example if b0=30 then we compute b1=30^2(modn).
     #We repeat the process above until b0 equals to +1 or-1 OR bi equals to +1 or -1
     #If the loop goes forever (for small numbers) (bi never gets the value +1 or -1), that means that n is composite.

     #+----+-------+-----------+
     #|    |   b0  | bi,i=1,2..|
     #+----+-------+-----------+
     #| +1 | Prime | Composite |
     #+----+-------+-----------+
     #| -1 | Prime |   Prime   |
     #+----+-------+-----------+


     bi=(a**m)%n
     if (bi==1 or bi==n-1):
         prime=n
         break
     else:
         #while (bi!=1 and bi!=n-1):
         #I use an "endable" for loop and not a while loop to avoid endless loops or very time consuming loops. For example if i pick n=56 then the while loop would take a lot of time to reach bi=+1 or bi=-1. With the for loop i skip it and go to the next n until i find some n easily calculatable.
         for i in range(1,p):
            bi = bi**2 % n
            if (bi==n-1):
                prime=n
                break
            elif (bi==1):
                print("The number "+str(n)+" is composite. Selecting another n randomly.")
                break

print("A possible prime number that was found is "+str(prime))
