using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteWall : MonoBehaviour {

    // Use this for initialization
    void OnTriggerExit(Collider other)
    {
        Destroy(gameObject);
    }
}
