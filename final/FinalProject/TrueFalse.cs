// this is the class for true or false questions

class TrueFalse : Question
{
    string _lhUserChoice;
    public TrueFalse(string _lhUserChoice, string lhQuestionType, List<string> lhQuestionText, string lhInstructions, List<string> lhAnswerOptions) : base(lhQuestionType, lhQuestionText, lhInstructions, lhAnswerOptions)
    {
        _lhUserChoice = "";
    }
}