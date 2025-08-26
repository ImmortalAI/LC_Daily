namespace Problems
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    public sealed class ProblemAttribute(string date) : Attribute
    {
        public string Date { get; } = date;
    }
}
