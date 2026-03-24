# em python funções sao definidas com def 

def soma(a=0,b=0,c=0):
    print(f"a:{a},b:{b},c:{c}")
    return a+b+c

soma(1,2,3)

def outrafuncaosoma(numeros):
    total = 0
    for numero in numeros:
        total += numero
        return numero
    
outrafuncaosoma([1,3,4,5])


def tuplas(*args): # args sao parametros, qualquer tipo de parametro
    print(args)
    total = 0
    for num in args:
        print(f"Somando: {num}\n")
        total += num
    return total

soma(1,2,3,4,5,6)

def soma3(a,b,*args,c=0,d=0, **kwargs):
    print(f"A:{a},B:{b},C:{c},D:{d}")
    print(args)
    print(kwargs)


soma3(1,2,3,4,5,6,d=8,c=7,f=8,e=10)


# 5 funções interessantes 

def  lowercase(text):
    return text.lower
