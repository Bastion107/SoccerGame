using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float speed;
    public float clampValue;

    // Update is called once per frame
    void Update()
    {
        MovePaddle(Input.GetAxis("Horizontal"));
//        Debug.Log(Input.GetAxis("vertical"));
//        gameObject.transform.position += new Vector3(0, 0, Input.GetAxis("vertical"));
    }

    public void MovePaddle(float inputAxisInfo) 
    {
        Vector3 clampedGameObjectPosition 
            = gameObject.transform.position
            + new Vector3(0, 0, inputAxisInfo * speed);

        clampedGameObjectPosition.z = Mathf.Clamp(clampedGameObjectPosition.z, -clampValue, clampValue);

        gameObject.transform.position = clampedGameObjectPosition;


    }

}
