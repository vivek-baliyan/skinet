namespace API.Errors
{
    public class ApiResponse(int statusCode, string message = null)
    {
        public int StatusCode { get; set; } = statusCode;
        public string Message { get; set; } = message;

        private string GetDefaultMessageForStatusCode(int statusCode)
        {
            return statusCode switch
            {
                400 => "A bad request, you have made",
                401 => "Authorized, you are not",
                404 => "Resource found, it was not",
                500 => "Error are the path to the dark side. Error lead to anger. Anger leads to hate. Hate leads to career change",
                _ => null
            };
        }
    }
}