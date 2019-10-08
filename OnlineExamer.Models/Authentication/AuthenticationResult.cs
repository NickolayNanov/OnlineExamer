namespace OnlineExamer.Models.Authentication
{
    using OnlineExamer.Domain;

    public class AuthenticationResult
    {
        public AuthenticationResult()
        {
            this.Errors = null;
        }

        public bool Succeeded { get; set; }

        public string Errors { get; set; }
    }
}
