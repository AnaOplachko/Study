namespace NewFamilyTree;

public class SocialUnit
{
    private Person firstAdult;
    private Person? secondAdult = null;

    public List<SocialUnit> Children { get; set; }

    public SocialUnit(Person man, Person woman)
    {
        this.firstAdult = man;
        this.secondAdult = woman;
        Children = null;
    }
    
    public SocialUnit(Person adult)
    {
        this.firstAdult = adult;
        Children = null;
    }
}