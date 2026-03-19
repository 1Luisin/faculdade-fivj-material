using System;

namespace Aula03;

public class MyException : Exception
{
    public MyException(Exception exception) => this.exception = exception;
    public MyException(string message) => this.message = message;
    public override string Message
    {
        get
        {
            if (exception != null)
                if (exception.GetType() == typeof(NotImplementedException))
                    return "O bobo do programador só não esquece a cabeça por estar presa no pescoço!";
                
            if (message == null)
                return "Erro desconhecido";
                
            return message;
        }
    }

    private readonly Exception? exception = null;
    private readonly string? message = null;
}
