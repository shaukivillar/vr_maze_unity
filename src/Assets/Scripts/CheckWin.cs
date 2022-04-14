using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckWin : MonoBehaviour
{

    public GameObject WinMessage;

    // Start is called just before any of the Update methods is called the first time
    private void Start()
    {
        this.WinMessage.SetActive(false);
    }



    // OnTriggerEnter is called when the Collider other enters the trigger
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("MainCamera"))
        {
            if (!this.WinMessage.activeInHierarchy)
            {
                // We Won
                this.WinMessage.SetActive(true);
            }
            
        }
    }


}
