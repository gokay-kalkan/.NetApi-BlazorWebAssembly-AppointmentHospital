namespace AppointmentHospital.Shared.ApiResponse
{
    public class ServiceResponse<T>
    {
        public T Data { get; set; }
        public string Message { get; set; } = string.Empty;

        public bool Success { get; set; } = false;

        //public ServiceResponse(bool success, string message, T data)
        //{
        //    Success = success;
        //    Message = message;
        //    Data = data;
        //}

    }
}
