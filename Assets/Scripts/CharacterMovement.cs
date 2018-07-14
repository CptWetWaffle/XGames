using UnityEngine;

namespace Assets.Scripts
{
    public class CharacterMovement : MonoBehaviour
    {
        public GameObject model;
        
        private Animator anim;

        public float Speed = 1f;

        private int z;
        // Use this for initialization
        void Start ()
        {
            z = 0;
            anim = model.GetComponent<Animator>();
            anim.SetInteger("Speed", 2);
        }

        // Update is called once per frame
        void Update ()
        {
            var x = transform.localPosition.x;
            var y = transform.localPosition.y;
            transform.position = new Vector3(x-Speed*Time.deltaTime,y,z);
            transform.rotation = new Quaternion();

            if (Input.GetKey(KeyCode.S))
            {
                model.transform.eulerAngles = new Vector3(45, -90, 0);

            }
            if (Input.GetKeyUp(KeyCode.S))
            {
                model.transform.eulerAngles = new Vector3(0, -90, 0);

            }

            if (Input.GetKeyDown(KeyCode.D))
            {
                var zInt = z + 6 > 6 ? z : z + 6;
                z = zInt;

                transform.localPosition = new Vector3(x, y, zInt);

            }

            if (Input.GetKeyDown(KeyCode.A))
            {
                var zInt = z - 6 < -6 ? z : z- 6;
                z = zInt;
                transform.localPosition = new Vector3(x, y, zInt);

            }
        }

        void OnTriggerExit(Collider other)
        {
            if (other.gameObject.name == "Collisions_03")
            {
                Destroy(other.gameObject.transform.parent.parent.gameObject);
                Debug.Log("Left Trigger");
            }
           
        }
    }
}
