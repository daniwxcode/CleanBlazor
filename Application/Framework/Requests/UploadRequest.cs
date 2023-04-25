namespace Application.Framework.Requests
{
    public class UploadRequest
    {
        public string FileName { get; set; }
        public string Extension { get; set; }
        public byte[] Data { get; set; }
    }
}