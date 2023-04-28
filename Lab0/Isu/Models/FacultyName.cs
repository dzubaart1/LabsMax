namespace Isu.Models
{
    public class FacultyName
    {
        public FacultyName(char name)
        {
            if (!char.IsLetter(name))
            {
                throw new ArgumentException("Неверное имя факультета");
            }

            ShortName = name;
        }

        public char ShortName { get; private set; }
    }
}
