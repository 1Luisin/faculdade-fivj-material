class Rastreador: 
    def __init__(self, vertice, anterior = None, custo_acumulado = 0): #função init é construtora !! 
        self.vertice = vertice
        self.anterior = anterior
        self.custo_acumulado = custo_acumulado

class Heuristica:
    def __init__(self,pesos,conexoes):
        self.pesos = pesos
        self.conexoes = conexoes
        
        def get_ordenados (self,rastro_atual):
            no_pai = rastro_atual.vertice

    