using ScrumPoker.Models;

namespace ScrumPoker.Singletons;

public class GameModelSingleton
{
    private static GameModelSingleton _instance;
    public GameModel Game { get; set; }

    private GameModelSingleton()
    {
        Game = new GameModel();
    }

    public static GameModelSingleton Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new GameModelSingleton();
            }

            return _instance;
        }        
    }
}