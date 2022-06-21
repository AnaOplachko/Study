namespace OOP_08._3;

public class Accauntant
{
    public bool AskForBonus(Post worker, int hours)
    {
        
        if ((int)worker <= hours)
        {
            return true;
        }
        else
        {
            return false;
        }
        
    }
    
}