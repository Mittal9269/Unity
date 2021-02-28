using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectKeys : MonoBehaviour
{

   public GameObject CountBox;
   public AudioSource collectSound;

   void OnTriggerEnter(){
       KeysCount.currentCount += 1; 
       collectSound.Play();
       Destroy(gameObject);
   }
}
