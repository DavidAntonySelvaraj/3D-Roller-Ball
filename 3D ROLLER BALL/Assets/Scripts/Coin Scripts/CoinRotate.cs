using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRotate : MonoBehaviour
{

    [SerializeField]
    private float rotateSpeed = 100f;
    [SerializeField]
    private bool rotateX, rotateY, rotateZ;



    private void Update()
    {
        if (rotateX)
            transform.Rotate(Vector3.right * Time.deltaTime * rotateSpeed);

        if (rotateY)
            transform.Rotate(Vector3.up * Time.deltaTime * rotateSpeed);

        if (rotateZ)
            transform.Rotate(Vector3.forward * Time.deltaTime * rotateSpeed);
    }


}//class



































