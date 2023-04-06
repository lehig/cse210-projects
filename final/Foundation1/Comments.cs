public class Comments{
    private string _name = "";
    private string _comment = "";
    private Dictionary<string, string> _commentDictionary = new Dictionary<string, string>();
    

    public Comments(string name, string comment){
        _name = name;
        _comment = comment;
        _commentDictionary.Add(name, comment);
    }

    public void SetName(string name){
        _name = name;
    }
    public string GetName(){
        return $"Name: {_name}";
    }
    public void SetComment(string comment){
        _comment = comment;
    }
    public string GetComment(){
        return $"{_comment}";
    }
}