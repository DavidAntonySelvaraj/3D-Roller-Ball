using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        //GameplayManager.instance.SetCoinCount(-1);

        if (other.CompareTag(TagManager.PLAYER_TAG))
        {
            GameplayManager.instance.SetCoinCount(-1);
            AudioManager.instance.PlayCoinSound();
            gameObject.SetActive(false);
        }
    }
}//class

































