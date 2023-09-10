namespace Application.Core
{
    public class AppException
    {
        public AppException(int StatusCode, string Message, string Detail = null)
        {
            this.StatusCode = StatusCode;
            this.Message = Message;
            this.Detail = Detail;
        }

        public int StatusCode { get; set; }
        public string Message { get; set; }
        public string Detail { get; set; }
    }
}