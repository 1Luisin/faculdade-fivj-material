using System;

namespace Aula03;

public static class ExtensoesStrings
{
    public static string Remover(this string texto, string parteASerRemovida)
    {
        return texto.Replace(parteASerRemovida, "");
    }
}
