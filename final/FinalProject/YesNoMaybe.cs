// this is the class for yes no maybe questions

class YesNoMaybe : Question
{
    string _lhUserChoice;
    public YesNoMaybe(string _lhUserChoice, string lhQuestionType, List<string> lhQuestionText, string lhInstructions, List<string> lhAnswerOptions) : base(lhQuestionType, lhQuestionText, lhInstructions, lhAnswerOptions)
    {
        _lhUserChoice = "";
    }
}