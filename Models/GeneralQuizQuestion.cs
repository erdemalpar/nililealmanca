namespace GermanLearningApp.Mvc.Models
{
    public class GeneralQuizQuestion
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        // Options might be needed if we want multiple choice for general quiz too, 
        // but current data only has question/answer for translation type.
        // We might generate options dynamically or add them.
        // Looking at the data, it seems to be fill-in-the-blank or we need to generate options.
        // For now let's keep it simple.
    }
}
