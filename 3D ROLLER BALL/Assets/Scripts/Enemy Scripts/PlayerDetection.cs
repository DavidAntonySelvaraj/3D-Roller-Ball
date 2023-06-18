using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDetection : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(TagManager.PLAYER_TAG))
        {
            collision.gameObject.GetComponent<BallController>().DestroyPlayer();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(TagManager.PLAYER_TAG))
        {
            other.GetComponent<BallController>().DestroyPlayer();
        }
    }
}//class




































