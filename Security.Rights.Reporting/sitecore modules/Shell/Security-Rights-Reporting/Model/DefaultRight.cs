
using Sitecore.Security.Accounts;

namespace Security.Rights.Reporting.Shell.Model
{
    public class DefaultRight
    {
        public string Path { get; set; }
        public string Account { get; set; }
        public AccountType AccountType { get; set; }
        public string Right { get; set; }
        public string PropagationType { get; set; }
        public string Name { get; set; }
        public string Message { get; set; }
        public bool Hit { get; set; }
    }
}