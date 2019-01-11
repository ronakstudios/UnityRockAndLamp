using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lampscript : MonoBehaviour
{
    public Light light;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("z"))
        {
            if( light.intensity == 1)
            {
                light.intensity = 4;
            }
            else
            {
                light.intensity = 1;
            }
        }

    }
}
