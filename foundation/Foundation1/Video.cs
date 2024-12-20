using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
        //List<Comment>  _comments = new List<Comment>();

    }

    //_____________Title__________
    public string GetTitle()
    {
        return _title;
    }

    public void SetTitle(string title)
    {
        _title = title;
    }

    //_____________Author___________

    public string GetAuthor()
    {
        return _author;
    }

    public void SetAuthor(string author)
    {
        _author = author;
    }
    //____________Length____________
    public int GetLength()
    {
        return _length;
    }

    public void SetLength(int length)
    {
        _length = length;
    }

    //

    public List<Comment> GetListOfComments()
    {
        return _comments;
    }



    public int NumberOfComments()
    {
        return _comments.Count;
    }


}