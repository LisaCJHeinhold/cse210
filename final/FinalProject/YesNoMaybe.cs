class YesNoMaybe : Question
{
    string _lhUserChoice;

    public YesNoMaybe(string lhQuestionType, List<string> lhQuestionText, string lhInstructions, List<string> lhAnswerOptions)
        : base(lhQuestionType, lhQuestionText, lhInstructions, lhAnswerOptions)
    {
        _lhUserChoice = "";
    }

    public override void LhGetUserResponse()
    {
        // DisplayQuestion();

        // Get user response
        Console.Write("Enter your choice (1-3): ");
        int lhChoice;
        //create a loop that keeps asking for input until the user enters a valid number
        while (!int.TryParse(Console.ReadLine(), out lhChoice) || lhChoice < 1 || lhChoice > 3)
        {
            Console.Write("Invalid input. Please enter a number between 1 and 3: ");
        }

        if (lhChoice == 1)
        {
            _lhUserChoice = "Extroverted";
        }
        else if (lhChoice == 2)
        {
            _lhUserChoice = "Introverted";
        }
        else
        {
            _lhUserChoice = "50/50";
        }
    }

    public string LhGetUserChoice()
    {
        return _lhUserChoice;
    }
}
