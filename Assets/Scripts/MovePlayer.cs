using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float speed = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float x = Input.GetAxis("Oculus_CrossPlaform_PrimaryThumbstickHorizontal");
        float z = Input.GetAxis("Oculus_CrossPlatform_PrimaryThumbstickVertical");
        Vector3 movement = transform.forward * z + transform.right * x;
        transform.Translate(movement * speed * Time.deltaTime);
    }
}
