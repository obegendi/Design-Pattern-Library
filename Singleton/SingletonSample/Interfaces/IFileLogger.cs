namespace SingletonSample.Interfaces
{
    public interface IFileLogger
    {
        void WriteLineToFile(string value);
        void CloseFile();
    }
}