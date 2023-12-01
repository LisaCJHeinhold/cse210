class MultipleChoice : Question
{
    string _lhUserChoice;

    public MultipleChoice(string lhQuestionType, List<string> lhQuestionText, string lhInstructions, List<string> lhAnswerOptions)
        : base(lhQuestionType, lhQuestionText, lhInstructions, lhAnswerOptions)
    {
        _lhUserChoice = "";
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
        //convert user choice to the corresponding answer option in the array
        _lhUserChoice = _lhAnswerOptions[lhChoice - 1];
    }

    public string GetUserChoice()
    {
        return _lhUserChoice;
    }
}
