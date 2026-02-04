namespace knightmoves;
public class Verifier
{
    // Add your code here
    public string OldEnough(int age)
    {
        if(age > 17)
        {
            return "old enough";
        } else
        {
            return "";
        }
    }

    public string UnderAge(int age)
    {
        if(age < 18)
        {
            return "underage";
        } else
        {
            return "";
        }
    }

    public string LegalSpeed(int speed)
    {
        if(speed <= 50)
        {
            return "legal speed";
        }  else
        {
            return "";
        }
    }

    public string IsGoldenYears(int age)
    {
        if(age >= 65)
        {
            return "golden years";
        }  else
        {
            return "";
        }
    }
}
