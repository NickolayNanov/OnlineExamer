namespace OnlineExamer.Shared.Models
{
    using System.Collections.Generic;


    public class ApiResponse<T>
    {
        public T Data { get; set; }

        public IEnumerable<string> Errors { get; set; }

        public bool Succeeded { get; set; }
    }
}
