namespace Cinema.API.Extensions;

public class ApiResponseExtension<T>
{
    public List<string>? Messages { get; set; }
    public T? Data { get; set; }

    public ApiResponseExtension() => Messages = [];

    public static ApiResponseExtension<T> CreateResponse(T? data) => new()
    {
        Data = data
    };

    public static ApiResponseExtension<T> CreateResponse(List<string> messages) => new()
    {
        Messages = messages
    };

    public static ApiResponseExtension<T> CreateResponse(Exception ex) => new()
    {
        Messages = [ex.Message]
    };
}