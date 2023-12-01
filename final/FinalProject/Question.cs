using System;
using System.Collections.Generic;

abstract class Question
{
    protected string _lhQuestionType;
    protected List<string> _lhQuestionText;
    protected string _lhInstructions;
    protected List<string> _lhAnswerOptions;

    public Question(string lhQuestionType, List<string> lhQuestionText, string lhInstructions, List<string> lhAnswerOptions)
    {
        _lhQuestionType = lhQuestionType;
        _lhQuestionText = lhQuestionText;
        _lhInstructions = lhInstructions;
        _lhAnswerOptions = lhAnswerOptions;
    }

    public abstract void GetUserResponse();

    public void DisplayQuestion()
    {
        // Display question text
        Console.WriteLine(_lhQuestionText[0]);
        Console.WriteLine(_lhInstructions);

        // Display answer options
        for (int i = 0; i < _lhAnswerOptions.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_lhAnswerOptions[i]}");
        }
    }
}
