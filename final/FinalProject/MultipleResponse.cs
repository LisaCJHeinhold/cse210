// this is the class for questions that have multiple responses

class MultipleResponse : Question
{
    List<string> _lhUserChoice;
    public MultipleResponse(List<string> _lhUserChoice, string lhQuestionType, List<string> lhQuestionText, string lhInstructions, List<string> lhAnswerOptions) : base(lhQuestionType, lhQuestionText, lhInstructions, lhAnswerOptions)
    {
        _lhUserChoice = new List<string>();
    }
}