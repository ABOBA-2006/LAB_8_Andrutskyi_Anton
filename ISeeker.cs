namespace Lab8;

public interface ISeeker<T>
{ 
    List<T> Seek(string keyWord);
}