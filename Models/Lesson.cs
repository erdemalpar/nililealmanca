using System.Collections.Generic;

namespace GermanLearningApp.Mvc.Models
{
    public class Lesson
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public List<string>? KeyPhrases { get; set; }
        public string? FunFact { get; set; }
        public List<QuizQuestion>? Quiz { get; set; }
    }

    public class QuizQuestion
    {
        public int Id { get; set; }
        public string? Question { get; set; }
        public List<string>? Options { get; set; }
        public string? Answer { get; set; }
    }
}
