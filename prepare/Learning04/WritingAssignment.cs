using System;

public class WritingAssignment : Assignment
{
    private string _text;

    public WritingAssignment(string studentName, string topic, string text)
        : base(studentName, topic)
    {
        _text = text;
    }

    public string GetWritingInformation()
    {
        return $"Write about the following topic:\n{_text}";
    }
}
