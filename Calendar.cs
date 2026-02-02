using System.Security.Cryptography.X509Certificates;

namespace knightmoves;
public class Calendar
{
    public string[] Seasons = {"Summer", "Fall", "Winter", "Spring"};

    public string FindCurrentSeason(){
        return Seasons[1];
       
    }
}
