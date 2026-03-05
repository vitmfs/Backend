import sys
import random
import functools
import platform
import datetime
import math
import json
import re
import os
#import nameOfFile as otherName 
#otherName.something
#from mymodule import person1


#Variables
x = 5
y = "Hello, World!"
y = 'Hello, World!'

x = str(3)    # x will be '3'
y = int(3)    # y will be 3
z = float(3)  # z will be 3.0

print(type(x))
print(type(y))

myVariableName = "John"

MyVariableName = "John"

my_variable_name = "John"

x, y, z = "Orange", "Banana", "Cherry"

x = y = z = "Orange"

fruits = ["apple", "banana", "cherry"]
x, y, z = fruits

x = "Hello World"	#str	
x = 20	          #int	
x = 20.5	        #float	
x = 1j	          #complex	
x = ["apple", "banana", "cherry"]	#list	
x = ("apple", "banana", "cherry")	#tuple	
x = range(6)	    #range	
x = {"name" : "John", "age" : 36}	#dict	
x = {"apple", "banana", "cherry"}	#set	
x = frozenset({"apple", "banana", "cherry"})	#frozenset	
x = True	        #bool	
x = b"Hello"	    #bytes	
x = bytearray(5)	#bytearray	
x = memoryview(bytes(5))	#memoryview	
x = None	        #NoneType