using UnityEngine;

public class TestScript : MonoBehaviour
{
    void Update()
    {
        if (GameManager.State.HorizonalState == "Left")
        {
            transform.position = new Vector3(-200.0f, 400.0f, 0.0f);
        }
        else if (GameManager.State.HorizonalState == "Center")
        {
            transform.position = new Vector3(0.0f, 400.0f, 0.0f);
        }
        else if (GameManager.State.HorizonalState == "Right")
        {
            transform.position = new Vector3(200.0f, 400.0f, 0.0f);
        }
    }
}
