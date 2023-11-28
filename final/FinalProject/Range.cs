// this is the class for range questions (1-4)

class Range : Question
{
    int _lhUserChoice;
    public Range(int _lhUserChoice, string lhQuestionType, List<string> lhQuestionText, string lhInstructions, List<string> lhAnswerOptions) : base(lhQuestionType, lhQuestionText, lhInstructions, lhAnswerOptions)
    {
        _lhUserChoice = 0;
    }
}