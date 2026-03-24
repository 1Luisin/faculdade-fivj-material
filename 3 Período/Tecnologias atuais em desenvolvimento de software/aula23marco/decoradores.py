import atexit

@atexit.register    
def say_goodbye():
    print("Boa noite!")
    
print("Olá!")       

def custom_decorator(func):
    def inner_fun(*args, **kwargs):
        print('Você chamou uma função com um decorator:')
        return_val = func(*args, **kwargs)
        print ('Terminou a execução')
        return return_val
    return inner_fun

@custom_decorator
def somar(a,b):
    return a+b

somar(1,2)

def dividir(a,b):
    return a / b

dividir(10,2)

def subtrair(a,b):
    return a - b

subtrair(10,2)

def multiplicar (a,b):
    return a * b

multiplicar (10,2)


