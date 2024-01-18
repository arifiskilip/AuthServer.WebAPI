namespace SharedLibrary.ResponseDto
{
    public class Response<T> where T: class
    {
        public T Data { get; set; }
        public int StatusCode { get; set; }
        public bool IsSuccess { get; set; }
        public ErrorDto ErrorDto { get; set; }


        public static Response<T> Success(T data, int statusCode)
        {
            return new Response<T> { Data = data, StatusCode = statusCode, IsSuccess=true };
        }

        public static Response<T> Success(int statusCode)
        {
            return new Response<T> { Data = default, StatusCode = statusCode, IsSuccess = true };
        }

        public static Response<T> Fail(string errorMessage, int statusCode, bool isShow)
        {
            return new Response<T> { ErrorDto = new(errorMessage, isShow), StatusCode = statusCode, IsSuccess = false };
        }

        public static Response<T> Fail(int statusCode,ErrorDto errorDto) 
        {
            return new Response<T> { ErrorDto=errorDto, StatusCode = statusCode,IsSuccess = false };
        }
    }
}
