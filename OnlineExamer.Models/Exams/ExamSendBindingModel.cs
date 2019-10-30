
using System.Collections.Generic;

namespace OnlineExamer.Models.Exams
{
    public class ExamSendBindingModel
    {
        public int YearOfCreation { get; set; }

        public IEnumerable<AnswerViewModel> Answer { get; set; }
    }
}
