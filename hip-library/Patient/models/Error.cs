namespace hip_library.Patient.models
{
    public class Error
    {
        public ErrorCode Code { get; } 
        public string Message { get; }

        public Error(ErrorCode code, string message)
        {
            Code = code;
            Message = message;
        }
    }
}