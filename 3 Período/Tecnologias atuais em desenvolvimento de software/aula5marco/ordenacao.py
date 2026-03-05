amigos = ['Huguinho','Zezinho','Luizinho','Margarida'] # LIST
amigos.sort() #Método ordenador 
print(amigos)

# Nesse código o sort ordena a lista por letra do alfabeto em ordem crescente


# -----------------------------------------------------

amigos = ['Huguinho','Zezinho','Luizinho','Margarida']
amigos.sort(reverse=True) # Método ordenador
print(amigos)

# Nesse código o sort ordena a lista por letra do alfabeto em ordem decrescente

# -----------------------------------------------------

amigos = ['Huguinho','Zezinho','Luizinho','Margarida']
amigos.sort(key=str.lower) # Método ordenador
print(amigos)

#Nesse código a ordenação torna o case sensitive = false