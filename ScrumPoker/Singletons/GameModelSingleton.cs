using ScrumPoker.Models;

public class GameModelSingleton
{
    private static GameModelSingleton _instance;
    public GameModel Game { get; set; }

    private GameModelSingleton()
    {
        Game = new GameModel();
    }

    public static GameModelSingleton Instance => _instance ?? new GameModelSingleton();
}