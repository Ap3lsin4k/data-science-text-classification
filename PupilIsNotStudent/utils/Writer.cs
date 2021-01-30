namespace PupilIsNotStudent.utils
{
    public interface IWriter
    {
        void Write(string message);
    }

    public class NullWriter : IWriter
    {
        public void Write(string word)
        {
            
        }
    }
}