using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PickupObject : MonoBehaviour
{
    public UiHandler UIH;
    public AudioClip collectSound;
    private void Start()
    {
        UIH = GameObject.Find("UiHandler").GetComponent<UiHandler>();
    }

    private void OnTriggerEnter(Collider bookCollider)
    {
        if(bookCollider.gameObject.tag== "Player")
        {
            print("Item picked up");
            AudioSource.PlayClipAtPoint(collectSound, transform.position);
            UIH.books++;
            Destroy(gameObject);
            
        }
        
    }
}
