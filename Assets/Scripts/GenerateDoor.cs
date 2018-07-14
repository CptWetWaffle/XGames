using UnityEngine;

public class GenerateDoor : MonoBehaviour
{
    public GameObject[] Doors;
    // Use this for initialization
    void Start()
    {

    }
    void OnTriggerEnter(Collider other)
    {


        var randomWall = Random.Range(0, 3);
        GameObject wall = null;
        switch (randomWall)
        {
            case 0:
                wall = Object.Instantiate(Doors[0]);
                break;
            case 1:
                wall = Object.Instantiate(Doors[1]);
                break;
            case 2:
                wall = Object.Instantiate(Doors[2]);
                break;


        }

        var xRange = 100;
        wall.transform.position = new Vector3(gameObject.transform.position.x - xRange, 1.68f, 0);

        Destroy(gameObject);
        Interface.UpdateScore(5);
    }


}
