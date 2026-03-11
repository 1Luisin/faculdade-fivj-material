# existem duas categorias de busca em métodos de pesquisa: busca cega (ou não informada) e busca informada (ou heurística).

#Pesquisa sequencial em vetor não ordenado

def busca(v, chave):
    i = 0

    while i < len(v) and chave != v[i]:
        i = i + 1

    if i < len(v) and chave == v[i]:
        return i
    else:   
        return -1