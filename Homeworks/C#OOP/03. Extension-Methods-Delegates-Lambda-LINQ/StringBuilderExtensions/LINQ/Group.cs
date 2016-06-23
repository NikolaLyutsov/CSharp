namespace ExtensionMethodsDelegatesLambdaLINQ.LINQ
{
    public class Group
    {
        public Group(int groupeNumber, string groupName)
        {
            this.GroupNumber = groupeNumber;
            this.DepartmentName = groupName;
        }
        public int GroupNumber { get; set; }

        public string DepartmentName { get; set; }
    }
}
