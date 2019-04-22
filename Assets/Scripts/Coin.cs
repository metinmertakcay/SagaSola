﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
   public int coinValue = 1;
    public GameObject coin = null;
    public AudioClip audioClip = null;

    void OnTriggerEnter ( Collider other )
    {
        if ( other.tag == "Player" )
        {
            

            Manager.instance.UpdateCoinCount ( coinValue );

            coin.SetActive ( false );

            this.GetComponent<AudioSource> ().PlayOneShot ( audioClip );

            Destroy ( this.gameObject, audioClip.length );
        }
    }
}
