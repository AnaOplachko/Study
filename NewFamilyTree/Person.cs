namespace NewFamilyTree;

public struct Person
{
    private int _age = 0;
    private string _name = null;
    private int index = 0;//залупа получается

    public int Age
    {
        get;
        private set; // make iut of range exception
    }

    public string Name
    {
        get;
        private set;
    }

    public int Index
    {
        get;
        private set;
    }
    
    public Person(string name, int age, int index)
    {
        Age = age;
        Name = name;
        Index = index;
    }
}