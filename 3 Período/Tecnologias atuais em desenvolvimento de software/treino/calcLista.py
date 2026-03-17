#Calculadora utilizando menu com lista

opcoesMenu = ["começar", "opções", "sair"]

opcaoescolhida = int(input(f"Digite a opção desejada:\n\n{opcoesMenu[0]}\n{opcoesMenu[1]}\n{opcoesMenu[2]}"))

if opcaoescolhida == 0:
    print("olá mundo")