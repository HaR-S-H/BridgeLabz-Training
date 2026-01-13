public interface IBookManager
{
    void AddBook(string title, string author);
    void SortBooksAlphabetically();
    void SearchByAuthor(string author);
    string[] ExportToArray();

}