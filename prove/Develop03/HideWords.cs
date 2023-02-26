class HideWords{
    private List<int> _hiddenIndex = new List<int>();
    private List<string> _verseWordsList = new List<string>();
    private List<string> _hiddenWordsList = new List<string>();
    private string _verse;

    public HideWords(string verse){
        SetVerse(verse);
        MakeVerseWordsList();
        MakeHiddenIndex();
        MakeHiddenWordsList();

    }

    private void SetVerse(string verse){
        _verse = verse;
    }

    private void MakeVerseWordsList(){
        _verseWordsList = _verse.Split(" ").ToList();
    }

    private void MakeHiddenIndex(){
        Random random = new Random();
        int counter = 0;
        int verseLength = _verseWordsList.Count;

        while (counter < verseLength){
            int randomNumber = random.Next(0, _verseWordsList.Count);
            if(!_hiddenIndex.Contains(randomNumber)){
                _hiddenIndex.Add(randomNumber);
                counter++;
            }
            
        }
    }

    private void MakeHiddenWordsList(){
        foreach(int i in _hiddenIndex){
            _verseWordsList[i] = new string('_', _verseWordsList[i].Length);
            string verseWordsString = string.Join(" ", _verseWordsList);
            _hiddenWordsList.Add(verseWordsString);
        }

    }

    public List<string> GetHiddenWordsList(){
        return _hiddenWordsList;
    }

}