using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;

    public Video(string title, string author, int length, List<Comment> comments)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = comments;
        //List<Comment>  _comments = new List<Comment>();

    }

    
    public string GetTitle()
    {
        return _title;
    }
    public string GetAuthor()
    {
        return _author;
    }
    public int GetLength()
    {
        return _length;
    }



    public void SetTitle(string title)
    {
        _title = title;
    }
    public void SetAuthor(string author)
    {
        _author = author;
    }
    public void SetLength(int length)
    {
        _length = length;
    }

    public int NumberOfComments()
    {
        return 0;
    }


}