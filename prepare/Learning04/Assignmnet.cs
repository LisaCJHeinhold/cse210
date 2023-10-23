using System.Reflection.Metadata.Ecma335;

class Assignment
{
    private string _LhStudentName;
    private string _LhTopic;

    public Assignment (string LhStudentName, string LhTopic)
    {
        _LhStudentName = LhStudentName;
        _LhTopic = LhTopic;
    }

    public string GetStudentName()
    {
        return _LhStudentName;
    }

    public string GetTopic()
    {
        return _LhTopic;
    }

    public string GetSummary()
    {
        return _LhStudentName + " - " + _LhTopic;
    }
}