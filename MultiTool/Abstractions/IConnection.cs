namespace MultiTool.Abstractions;

public interface IConnection
{
    void Open();
    void Close();

    int Read(ref ICollection<byte> buff, int offset, int size);
    void Write(ICollection<byte> buff, int offset, int size);

    bool IsOpen { get; }
}
