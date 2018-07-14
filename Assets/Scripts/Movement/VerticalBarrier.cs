using UnityEngine;

public class VerticalBarrier : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (GameManager.State.HorizonalState != this.name)
        {
            GameManager.State.VerticalState = this.name;
        }
    }
}
