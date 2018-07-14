using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static State State;
    public Transform Head;
    public Transform Barriers;
    void Start()
    {
        if (State == null)
        {
            State = new State();
        }

        Barriers.position += Head.position;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
