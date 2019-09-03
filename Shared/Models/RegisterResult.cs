namespace OnlineExamer.Shared.Models
{
    using System.Collections.Generic;

    public class RegisterResult
    {
        public bool Successful { get; set; }
        public IEnumerable<string> Errors { get; set; }
    }
}
