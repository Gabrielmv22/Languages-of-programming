#Gabriel Miño
#03-09-2024
#---------------------------------------------------------------------------------
#ejemplo paradigna imperativo

def factorial(n):
    if n == 0:
        return 1
    else:
        return n * factorial(n - 1)
opcion=1
while(opcion!=0):
    n=int(input("ingrese un numero para calcular factorial:"))
    print(factorial(n))
    opcion=int(input("desea hacer otro calculo (1=si,0=no)"))

#---------------------------------------------------------------------------------
#ejemplo paradigna funcional

reduce=(lambda x:1 if x==0 else x*reduce(x-1))
print(reduce(5))
print("Se imprimio el resultado")