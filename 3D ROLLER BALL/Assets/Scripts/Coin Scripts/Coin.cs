using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag(TagManager.PLAYER_TAG))
        {
            //tell the game manager that coin is picked
            AudioManager.instance.PlayCoinSound();
            gameObject.SetActive(false);
        }
    }
}//class

































