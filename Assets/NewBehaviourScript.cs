using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
     public Rigidbody rigibod;
    public Transform transform;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("x"))
        {
            transform.position = new Vector3(0, 0, 0);
            rigibod.velocity = new Vector3(0, 0, 0);
        }
        if (Input.GetKey("w")) rigibod.AddForce(0, 0, -500 * Time.deltaTime);
        if (Input.GetKey("a")) rigibod.AddForce(500 * Time.deltaTime, 0, 0);
        if (Input.GetKey("d")) rigibod.AddForce(-500 * Time.deltaTime, 0, 0);
        if (Input.GetKey("s")) rigibod.AddForce(0, 0, 500 * Time.deltaTime);
        if (Input.GetKey("space")) rigibod.AddForce(0, 900 * Time.deltaTime, 0);

    }
}
