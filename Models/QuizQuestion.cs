namespace BSIT_32E1_Elective_2_Assignment_1.Models
{
    public class QuizQuestion
    {
        public int Id { get; set; }
        public string Question { get; set; } = "";
        public string[] Choices { get; set; } = new string[4];
        public string CorrectAnswer { get; set; } = "";
    }
}