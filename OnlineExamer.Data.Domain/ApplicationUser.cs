namespace OnlineExamer.Domain
{
    using System;
    using System.Collections.Generic;

    using Microsoft.AspNetCore.Identity;

    public class ApplicationUser : IdentityUser<string>
    {
        public ApplicationUser()
        {

        }

        public ApplicationUser(string email, string fullName)
        {
            this.Id = Guid.NewGuid().ToString();

            this.Email = email;
            this.UserName = fullName;
            this.FullName = fullName;
            this.UserExams = new HashSet<UserExam>();
        }

        public string FullName { get; set; }

        public bool IsSittingExam { get; set; }

        public int AverageGrade { get; set; }

        public virtual ICollection<UserExam> UserExams { get; set; }
    }
}
