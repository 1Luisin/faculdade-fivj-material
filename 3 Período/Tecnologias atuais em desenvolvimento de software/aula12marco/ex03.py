amigos = ["Huguinho","Zezinho","Luizinho","Margarida","Donald","Patinhas"]

novos_amigos = amigos[:]

novos_amigos.pop()

print(amigos)

for amigo in amigos[0:3]:
    print (amigo)

    # o : fatia as listas o número a esquerda do ":" define o começo da fatia e o número a direita define o fim
    #quando é : vazio, percorre a lista inteira

