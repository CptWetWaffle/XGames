using UnityEngine;

public class VerticalBarrier : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (GameManager.State.HorizonalState != this.name)
        {
            GameManager.State.HasChangedVertical = true;

            GameManager.State.VerticalState = this.name;
            Debug.Log(this.name);
        }
    }
}
