namespace DoctorLife.INFRA.Const
{
    public class MethodMessage
    {
        public string? Message { get; set; }
        public bool IsError { get; set; }

        public MethodMessage(bool isError = false, string? message = null)
        {
            Message = message ;
            IsError = isError;
        }
    }
}
