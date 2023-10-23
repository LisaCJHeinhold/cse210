class MathAssignment : Assignment
{
    private string _LhTextbookSection;
    private string _LhProblems;

    public MathAssignment (string LhStudentName, string LhTopic, string LhTextbookSection, string LhProblems) : base(LhStudentName, LhTopic)
    {
        _LhTextbookSection = LhTextbookSection;
        _LhProblems = LhProblems;
    }

    public string GetHomeworkList()
    {
        return $"Section: {_LhTextbookSection}, Problems: {_LhProblems}";
    }
}