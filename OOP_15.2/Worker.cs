using System.Security.Cryptography;

namespace OOP_15._2;

public struct Worker
{
    private string _name;
    private string _post;
    private int _year;

    public string Name
    {
        get => _name;
        set { _name = value; }
    }

    public string Post
    {
        get => _post;
        set { _post = value; }
    }

    public int Year
    {
        get => _year;
        set { _year = value; }
    }

    public Worker(string fullName, string post, int year)
    {
        _name = fullName;
        _post = post;
        _year = year;
    }

}