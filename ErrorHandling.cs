using System;

public static class ErrorHandling
{
    public static void HandleErrorByThrowingException()
    {
        try
        {
            throw new NotImplementedException("You need to implement this function.");
        }
        catch (NotImplementedException)
        {

            throw new Exception("Exception Handled by throwing new exception");
        }
       
    }

    public static int? HandleErrorByReturningNullableType(string input)
    {
        throw new NotImplementedException("You need to implement this function.");
    }

    public static bool HandleErrorWithOutParam(string input, out int result)
    {
        throw new NotImplementedException("You need to implement this function.");
    }

    public static void DisposableResourcesAreDisposedWhenExceptionIsThrown(IDisposable disposableObject)
    {
        throw new NotImplementedException("You need to implement this function.");
    }
}
