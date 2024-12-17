namespace ulearn;

public class Cycles
{
    public static bool ShouldFire2(bool enemyInFront, string enemyName, int robotHealth)
    {
        return enemyInFront && (enemyName != "boss" || robotHealth >= 50);
    }
}