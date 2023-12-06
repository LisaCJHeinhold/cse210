class Result
{
    public static void LhCalculatePersonality(List<Question> lhQuestions)
    {
        int lhIntrovertedCount = 0;
        int lhExtrovertedCount = 0;

        foreach (var lhQuestion in lhQuestions)
        {
            if (lhQuestion is YesNoMaybe)
            {
                if (((YesNoMaybe)lhQuestion).LhGetUserChoice() == "Introverted")
                {
                    lhIntrovertedCount++;
                    lhIntrovertedCount++;
                }
                else if (((YesNoMaybe)lhQuestion).LhGetUserChoice() == "Extroverted")
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
                if (((TrueFalse)lhQuestion).LhGetUserChoice())
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
                string lhUserChoice = ((MultipleChoice)lhQuestion).LhGetUserChoice();
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
                int lhUserChoice = ((Range)lhQuestion).LhGetUserChoice();
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
                List<string> lhUserChoice = ((MultipleResponse)lhQuestion).LhGetUserChoice();
                // Add logic based on userChoice
                foreach (var lhChoice in lhUserChoice)
                {
                    string[] lhIndividualChoices = lhChoice.Split(' ');
                    foreach (var lhIndividualChoice in lhIndividualChoices)
                    {
                        if (lhIndividualChoice == "1" || lhIndividualChoice == "3")
                        {
                            lhExtrovertedCount++;
                        }
                        else if (lhIndividualChoice == "2" || lhIndividualChoice == "4")
                        {
                            lhIntrovertedCount++;
                        }
                    }
                }
            }
        }
        // Calculate and display the result
        int lhTotalPoints = (lhIntrovertedCount + lhExtrovertedCount);
        int lhPointWeight = 100 / lhTotalPoints;
        lhIntrovertedCount = lhIntrovertedCount * lhPointWeight;
        lhExtrovertedCount = lhExtrovertedCount * lhPointWeight;

        Console.WriteLine($"Introverted: {lhIntrovertedCount}%");
        Console.WriteLine($"Extroverted: {lhExtrovertedCount}%");

    }
}
