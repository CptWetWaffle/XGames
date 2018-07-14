using UnityEngine;

namespace Movement
{
    public class HorizontalBarrier : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            if (GameManager.State.HorizonalState != this.name)
            {
                GameManager.State.HorizonalState = this.name;
                Debug.Log(this.name);
            }
        }
    }
}
