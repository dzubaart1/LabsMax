namespace Isu.Models
{
    public class FacultyName
    {
        public FacultyName(char name)
        {
            ShortName = name;
        }

        public char ShortName { get; private set; }
    }
}
