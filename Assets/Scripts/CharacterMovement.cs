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
        void Start()
        {
            z = 0;
            anim = model.GetComponent<Animator>();
            anim.SetInteger("Speed", 2);
        }

        // Update is called once per frame
        void Update()
        {
            if (!GameManager.StartGame)
            {
                anim.SetInteger("Speed", 0);
                model.transform.eulerAngles = new Vector3(0, -90, 0);
                transform.rotation = new Quaternion();
                var xs = transform.localPosition.x;
                var ys = transform.localPosition.y;
                transform.position = new Vector3(xs, ys, z);
                return;
            }

            anim.SetInteger("Speed", 2);

            var x = transform.localPosition.x;
            var y = transform.localPosition.y;
            transform.position = new Vector3(x - Speed * Time.deltaTime, y, z);
            model.transform.eulerAngles = new Vector3(0, -90, 0);
            transform.rotation = new Quaternion();

            if (GameManager.State.VerticalState == "Bottom")
            {
                model.transform.eulerAngles = new Vector3(45, -90, 0);

            }

            if (GameManager.State.VerticalState == "Middle")
            {
                model.transform.eulerAngles = new Vector3(0, -90, 0);

            }

            if (!GameManager.State.HasChangedHorizontal)
                return;

            GameManager.State.HasChangedHorizontal = false;

            if (GameManager.State.HorizonalState == "Right")
            {
                var zInt = 6;
                z = zInt;

                transform.localPosition = new Vector3(x, y, zInt);

            }
            else if (GameManager.State.HorizonalState == "Center")
            {
                var zInt = 0;
                z = zInt;

                transform.localPosition = new Vector3(x, y, zInt);

            }
            else if (GameManager.State.HorizonalState == "Left")
            {
                var zInt = -6;
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


/*if (Input.GetKey(KeyCode.S) || GameManager.State.VerticalState == "Bottom")
           {
               model.transform.eulerAngles = new Vector3(45, -90, 0);

           }
           if (Input.GetKeyUp(KeyCode.S) || GameManager.State.VerticalState == "Middle")
           {
               model.transform.eulerAngles = new Vector3(0, -90, 0);

           }

           if (Input.GetKeyDown(KeyCode.D) || GameManager.State.VerticalState == "Right")
           {
               var zInt = z + 6 > 6 ? z : z + 6;
               z = zInt;

               transform.localPosition = new Vector3(x, y, zInt);

           }

           if (Input.GetKeyDown(KeyCode.A) || GameManager.State.VerticalState == "Left")
           {
               var zInt = z - 6 < -6 ? z : z - 6;
               z = zInt;
               transform.localPosition = new Vector3(x, y, zInt);

           }
           */
