namespace Application.Configs
{
    public class MailConfiguration
    {
        public string From { get; set; } = string.Empty;
        public string Host { get; set; } = "localhost";
        public int Port { get; set; } = 0;
        public string UserName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string DisplayName { get; set; } = string.Empty;
    }
}