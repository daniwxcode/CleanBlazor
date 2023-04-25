namespace Application.Framework.Requests.Sms
{
    public class SmsRequest
    {
        public string to { get; set; }
        public string text { get; set; }
        public string origin { get; set; }
        public string from { get; set; }
        public string dlr_url { get; set; }
        public string validity { get; set; }
        public string deferred { get; set; }
    }
}