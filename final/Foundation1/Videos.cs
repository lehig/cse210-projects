public class Videos{
    private List<Comments> _commentList = new List<Comments>();
    private string _title;
    private string _author;
    private int _length;

    public Videos(string title, string author, int length){
        SetTitle(title);
        SetAuthor(author);
        SetLength(length);
    }

    public string GetTitle(){
        return _title;
    }
    public void SetTitle(string title){
        _title = title;
    }
    public string GetAuthor(){
        return _author;
    }
    public void SetAuthor(string author){
        _author = author;
    }
    public int GetLength(){
        return _length;
    }
    public void SetLength(int length){
        _length = length;
    }
    public void AddComment(string name, string comment){
        Comments newComment = new Comments(name, comment);
        _commentList.Add(newComment);
    }

    public List<Comments> RetreiveComments(){
        return _commentList;
    }
}