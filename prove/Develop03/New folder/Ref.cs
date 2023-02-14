using System;

class Refrence{

    private string _book;
    private string _chapter;
    private string _verse;
    private string _endVerse;
    public Refrence(){
        // default refrence
    }
// this constructor accepts just the specific verse without the end verse
    public Refrence(string bk, string ch, string vr){
        _book = bk;
        _chapter = ch;
        _verse = vr;
    }

    // this constructor will accept both the starting and ending verses
    public Refrence(string bk, string ch, string vr, string endVr){
        _book = bk;
        _chapter = ch;
        _verse = vr;
        _endVerse = endVr;
    }


    public string getRefrence(){
        if(_endVerse.ToString() != ""){
                    string text = $"{_book} {_chapter}:{_verse} -{_endVerse}";
        return text;
        } else{
             string text = $"{_book} {_chapter}:{_verse}";
        return text;
        }
    }
    // public string refVerseToString(){
        
    // }
    // public string refTostring(){

    // }
}