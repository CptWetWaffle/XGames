using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static State State;
    public static bool StartGame;
    public Transform Head;
    public Transform Barriers;

    public GameManager()
    {
        if (State == null)
        {
            State = new State();
        }

        StartGame = false;

        /* Barriers.position += Head.position;*/
    }
}
