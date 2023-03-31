using ScrumPoker.Models;

public class PlayerModelSingleton
{
    private static PlayerModelSingleton _instance;
    public PlayerModel Player { get; set; }

    private PlayerModelSingleton()
    {
        Player = new PlayerModel("DefaultName", 0, false);
    }

    public static PlayerModelSingleton Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new PlayerModelSingleton();
            }
            return _instance;
        }
    }

}