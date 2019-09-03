namespace OnlineExamer.Domain
{
    using Microsoft.AspNetCore.Identity;
    using System.Collections.Generic;

    public class ExamerUser : IdentityUser<string>
    {
        public ExamerUser()
        {
            this.UserExams = new HashSet<UserExam>();
        }
        public bool IsSittingExam { get; set; }

        public int AverageGrade { get; set; }

        public ICollection<UserExam> UserExams { get; set; }
    }
}
