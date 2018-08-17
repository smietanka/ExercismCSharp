using System;

public static class ErrorHandling
{
    public static void HandleErrorByThrowingException()
    {
        throw new Exception("Custom message");
    }

    public static int? HandleErrorByReturningNullableType(string input)
    {
        if (int.TryParse(input, out int result)) return result;
        else return null;
    }

    public static bool HandleErrorWithOutParam(string input, out int result)
    {
        if(int.TryParse(input, out result))
        {
            return true;
        }
        return false;
    }

    public static void DisposableResourcesAreDisposedWhenExceptionIsThrown(IDisposable disposableObject)
    {
        try
        {
            throw new Exception("Custom message");
        }
        finally
        {
            disposableObject.Dispose();
        }
    }
}
