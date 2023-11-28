// this is the Question class, which is the base class for all questions. 
class Question 
{
    string _lhQuestionType;
    List<string> _lhQuestionText;
    string _lhInstructions;
    List<string> _lhAnswerOptions;

    public Question(string lhQuestionType, List<string> lhQuestionText, string lhInstructions, List<string> lhAnswerOptions)
    {
        _lhQuestionType = lhQuestionType;
        _lhQuestionText = lhQuestionText;
        _lhInstructions = lhInstructions;
        _lhAnswerOptions = lhAnswerOptions;
    }
}