class WritingAssignment : Assignment
{
    private string _LhTitle;

    public WritingAssignment(string LhStudentName, string LhTopic, string LhTitle) : base(LhStudentName, LhTopic)
    {
        _LhTitle = LhTitle;
    }

    public string GetWritingInformation()
    {
        string LhStudentName = GetStudentName();
        return $"{_LhTitle} by {LhStudentName}";
    }
}