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
        try
        {
            int number = int.Parse(input);
            return number;
        }
        catch (Exception)
        {
            return null;
        }

    }

    public static bool HandleErrorWithOutParam(string input, out int result)
    {
        return int.TryParse(input, out result);
    }

    public static void DisposableResourcesAreDisposedWhenExceptionIsThrown(IDisposable disposableObject)
    {
        throw new NotImplementedException("You need to implement this function.");
    }
}
