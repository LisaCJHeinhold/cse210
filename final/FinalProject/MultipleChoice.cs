// This is the class for the multiple choice Questions.

class MultipleChoice : Question
{
    string _lhUserChoice;

    public MultipleChoice(string lhQuestionType, List<string> lhQuestionText, string lhInstructions, List<string> lhAnswerOptions) : base(lhQuestionType, lhQuestionText, lhInstructions, lhAnswerOptions)
    {
        _lhUserChoice = "";
    }
}