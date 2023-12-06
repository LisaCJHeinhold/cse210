class MultipleResponse : Question
{
    List<string> _lhUserChoice;

    public MultipleResponse(string lhQuestionType, List<string> lhQuestionText, string lhInstructions, List<string> lhAnswerOptions)
        : base(lhQuestionType, lhQuestionText, lhInstructions, lhAnswerOptions)
    {
        _lhUserChoice = new List<string>();
    }

    public override void LhGetUserResponse()
    {
        // DisplayQuestion();

        // Get user response
        Console.Write("Enter the numbers corresponding to your choices (e.g., 1 3): ");
        string[] lhChoices = Console.ReadLine().Split(' ');

        foreach (var lhChoice in lhChoices)
        {
            //create a loop that keeps asking for input until the user enters a valid number
            if (int.TryParse(lhChoice, out int lhIndex) && lhIndex >= 1 && lhIndex <= 4)
            {
                //create response list
                _lhUserChoice.Add(_lhAnswerOptions[lhIndex - 1]);
            }
        }
    }

    public List<string> LhGetUserChoice()
    {
        return _lhUserChoice;
    }
}
