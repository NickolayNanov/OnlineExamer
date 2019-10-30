namespace OnlineExamer.Data
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    using OnlineExamer.Domain;

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public ApplicationDbContext()
        {

        }       

        public DbSet<Exam> Exams { get; set; }

        public DbSet<Answer> Answers { get; set; }

        public DbSet<Question> Questions { get; set; }

        public DbSet<SchoolSubject> SchoolSubjects { get; set; }

        public DbSet<UserExam> UserExams { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            this.SetPrimaryKeys(builder);
            this.QuestionModelSettings(builder);
            this.AnswerModelSettings(builder);
            this.SchoolSubjectModelSettings(builder);
            this.ExamModelSettings(builder);
            this.UserExamModelSettings(builder);

            base.OnModelCreating(builder);
        }

        private void UserExamModelSettings(ModelBuilder builder)
        {
            builder.Entity<UserExam>()
                            .HasKey(pk => new { pk.ExamId, pk.UserId });
        }

        private void ExamModelSettings(ModelBuilder builder)
        {

            builder.Entity<Exam>()
                .Property(exam => exam.StartedAt)
                .IsRequired();

            builder.Entity<Exam>()
                .Property(exam => exam.FinishedAt)
                .IsRequired();

            builder.Entity<Exam>()
                .Property(exam => exam.FinishedAt)
                .IsRequired(false);

            builder.Entity<Exam>()
                .Property(exam => exam.StartedAt)
                .IsRequired(false);
        }

        private void AnswerModelSettings(ModelBuilder builder)
        {
            builder.Entity<Answer>()
                            .Property(answer => answer.Content)
                            .IsUnicode()
                            .IsRequired();

            builder.Entity<Answer>()
                .HasOne(answer => answer.Question)
                .WithMany(question => question.Answers)
                .HasForeignKey(fk => fk.QuestionId);
        }

        private void SchoolSubjectModelSettings(ModelBuilder builder)
        {
            builder.Entity<SchoolSubject>()
                            .Property(schoolSubject => schoolSubject.Name)
                            .IsRequired()
                            .IsUnicode();
        }

        private void QuestionModelSettings(ModelBuilder builder)
        {
            builder.Entity<Question>()
                            .Property(question => question.Content)
                            .IsUnicode()
                            .IsRequired();

            builder.Entity<Question>()
                .HasMany(question => question.Answers)
                .WithOne(answer => answer.Question)
                .HasForeignKey(fk => fk.QuestionId);

            builder.Entity<Question>()
                .HasOne(question => question.Exam)
                .WithMany(exam => exam.Questions)
                .HasForeignKey(fk => fk.ExamId);
        }

        private void SetPrimaryKeys(ModelBuilder builder)
        {
            builder.Entity<Question>()
                            .HasKey(pk => pk.Id);

            builder.Entity<SchoolSubject>()
                .HasKey(pk => pk.Id);

            builder.Entity<Answer>()
                .HasKey(pk => pk.Id);

            builder.Entity<Exam>()
                .HasKey(pk => pk.Id);
        }
    }
}
