alien_0 = {
    'color': 'green',
    'points': 5,
    'alive': True
}



alien_0['alive'] = False
print(alien_0['alive'])  


alien_1 = {
    'color':'green',
    'age': 67,
    'points': 6,
    0: "primeiro",
    0: "segundo",
    ('teste',1): "tupla"
}

print(alien_1)

favorite_languages = {
    'huguinho': 'c',
    'zezinho': 'python',
    'luizinho': 'binario',
    'margarida': 'php'
}

#print(f"Luisinho gosta de programar em {favorite_languages['luizinho']}")

#for key,value in favorite_languages.keys():
 #   print(f"{key.title()} gosta de programar em {value}.\n")


#meus amigos que responderam a pesquisa
print("Meus amigos que responderam a pesquisa:") 
for key in favorite_languages.keys  ():
    print(key.title())
    if key in favorite_languages:   
        linguagem = favorite_languages[key].title


numbers_set = {0,11,2,3,4,5,6,7,8,0,32321} # conjunto

print("As linguagens escolhidas foram:")

for value in favorite_languages.values():
    print(value.title())