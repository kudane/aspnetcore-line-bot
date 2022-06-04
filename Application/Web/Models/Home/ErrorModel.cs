namespace Application.Web.Models.Home
{
    public class ErrorModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}