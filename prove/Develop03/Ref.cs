// using System;

// class Refrence{

//     private string _book;
//     private int _chapter;
//     private int _verse;
//     private int _endVerse;
//     public Refrence(){
//         // default refrence
//     }
// // this constructor accepts just the specific verse without the end verse
//     public Refrence(string bk, int ch, int vr){
//         _book = bk;
//         _chapter = ch;
//         _verse = vr;
//     }

//     // this constructor will accept both the starting and ending verses
//     public Refrence(string bk, int ch, int vr, int endVr){
//         _book = bk;
//         _chapter = ch;
//         _verse = vr;
//         _endVerse = endVr;
//     }

//     public string refVerseToString(){
//          string text = $"{_book} {_chapter}:{_verse}";
//         return text;
//     }
//     public string refTostring(){
//         string text = $"{_book} {_chapter}:{_verse} -{_endVerse}";
//         return text;
//     }
// }