using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject gameObject;
    private Vector3 of;
    // Start is called before the first frame update
    void Start()
    {
        of = transform.position - gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = gameObject.transform.position+of;
    }
}
