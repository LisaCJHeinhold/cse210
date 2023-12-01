class Range : Question
{
    int _lhUserChoice;

    public Range(string lhQuestionType, List<string> lhQuestionText, string lhInstructions, List<string> lhAnswerOptions)
        : base(lhQuestionType, lhQuestionText, lhInstructions, lhAnswerOptions)
    {
        _lhUserChoice = 0;
    }

    public override void GetUserResponse()
    {
        // DisplayQuestion();

        // Get user response
        Console.Write("Enter your choice (1-4): ");
        int lhChoice;
        //create a loop that keeps asking for input until the user enters a valid number
        while (!int.TryParse(Console.ReadLine(), out lhChoice) || lhChoice < 1 || lhChoice > 4)
        {
            Console.Write("Invalid input. Please enter a number between 1 and 4: ");
        }

        _lhUserChoice = lhChoice;
    }

    public int GetUserChoice()
    {
        return _lhUserChoice;
    }
}
