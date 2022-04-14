using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckUnlock : MonoBehaviour
{
    public GameObject door = null;

    // Start is called before the first frame update
    void Start()
    {
        this.door.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // OnTriggerEnter is called when the Collider other enters the trigger
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Key"))
        {
            if (this.door.activeInHierarchy)
            {
                // We Won
                this.door.SetActive(false);
            }

        }
    }
}
