using System;

public static class ErrorHandling
{
    public static void HandleErrorByThrowingException()
    {
        throw new Exception("Something is wrong");
    }

    public static int? HandleErrorByReturningNullableType(string input)
    {
        try
        {
            return Convert.ToInt32(input) >= 0 ? Convert.ToInt32(input) : (int?)null;
        }
        catch
        {
            return null;
        }

        //if (int.TryParse(input, out int result))
        //    return result;
        //return null;
    }


    public static bool HandleErrorWithOutParam(string input, out int result)
    {
        result = 0;
        try
        {
            result = int.Parse(input);
            return true;
        }
        catch 
        {
            return false;
        }

        // public static bool HandleErrorWithOutParam(string input, out int result) => int.TryParse(input, out result);
    }
    public static void DisposableResourcesAreDisposedWhenExceptionIsThrown(IDisposable disposableObject)
    {
        try
        {
            throw new Exception();
        }
        finally
        {
            disposableObject.Dispose();
        }
    }
}
// solução do professor : https://gist.github.com/arlm/3ba23045b8259db7757b592b8e50492d
