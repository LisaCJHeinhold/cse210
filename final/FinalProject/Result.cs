class Result
{
    public static void CalculatePersonality(List<Question> lhQuestions)
    {
        int lhIntrovertedCount = 0;
        int lhExtrovertedCount = 0;

        foreach (var lhQuestion in lhQuestions)
        {
            if (lhQuestion is YesNoMaybe)
            {
                if (((YesNoMaybe)lhQuestion).GetUserChoice() == "Introverted")
                {
                    lhIntrovertedCount++;
                    lhIntrovertedCount++;
                }
                else if (((YesNoMaybe)lhQuestion).GetUserChoice() == "Extroverted")
                {
                    lhExtrovertedCount++;
                    lhExtrovertedCount++;
                }
                else
                {
                    lhIntrovertedCount++;
                    lhExtrovertedCount++;
                }
            }
            else if (lhQuestion is TrueFalse)
            {
                if (((TrueFalse)lhQuestion).GetUserChoice())
                {
                    lhExtrovertedCount++;
                }
                else
                {
                    lhIntrovertedCount++;
                }
            }
            else if (lhQuestion is MultipleChoice)
            {
                string lhUserChoice = ((MultipleChoice)lhQuestion).GetUserChoice();
                // Add logic based on userChoice
                if (lhUserChoice == "Initiate conversations" || lhUserChoice == "Talk to as many people as possible")
                {
                    lhExtrovertedCount++;
                }
                else
                {
                    lhIntrovertedCount++;
                }
            }
            else if (lhQuestion is Range)
            {
                int lhUserChoice = ((Range)lhQuestion).GetUserChoice();
                // Add logic based on userChoice
                if (lhUserChoice >= 3)
                {
                    lhIntrovertedCount++;
                }
                else
                {
                    lhExtrovertedCount++;
                }
            }
            else if (lhQuestion is MultipleResponse)
            {
                List<string> lhUserChoice = ((MultipleResponse)lhQuestion).GetUserChoice();
                // Add logic based on userChoice
                foreach (var lhChoice in lhUserChoice)
                {
                    string[] individualChoices = lhChoice.Split(' ');
                    foreach (var individualChoice in individualChoices)
                    {
                        if (individualChoice == "1" || individualChoice == "3")
                        {
                            lhExtrovertedCount++;
                        }
                        else if (individualChoice == "2" || individualChoice == "4")
                        {
                            lhIntrovertedCount++;
                        }
                    }
                }
            }
        }

        // Calculate and display the result
        int lhTotalQuestions = lhQuestions.Count;
        double lhIntrovertedPercentage = (double)lhIntrovertedCount / lhTotalQuestions * 100;
        double lhExtrovertedPercentage = (double)lhExtrovertedCount / lhTotalQuestions * 100;

        Console.WriteLine($"Introverted: {lhIntrovertedPercentage}%");
        Console.WriteLine($"Extroverted: {lhExtrovertedPercentage}%");
    }
}
