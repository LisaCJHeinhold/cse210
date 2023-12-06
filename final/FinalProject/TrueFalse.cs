class TrueFalse : Question
{
    bool _lhUserChoice;

    public TrueFalse(string lhQuestionType, List<string> lhQuestionText, string lhInstructions, List<string> lhAnswerOptions)
        : base(lhQuestionType, lhQuestionText, lhInstructions, lhAnswerOptions)
    {
        _lhUserChoice = false;
    }

    public override void LhGetUserResponse()
    {
        // DisplayQuestion();

        // Get user response
        Console.Write("Enter your choice (1 or 2): ");
        int lhChoice;
        //create a loop that keeps asking for input until the user enters a valid number
        while (!int.TryParse(Console.ReadLine(), out lhChoice) || lhChoice < 1 || lhChoice > 2)
        {
            Console.Write("Invalid input. Please enter 1 for True or 2 for False: ");
        }
        //if the user enters 1, the user choice is true. Otherwise, it is false.
        _lhUserChoice = lhChoice == 1;
        Console.WriteLine(_lhUserChoice);
    }

    public bool LhGetUserChoice()
    {
        return _lhUserChoice;
    }
}
