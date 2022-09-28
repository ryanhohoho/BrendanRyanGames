using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemScript : MonoBehaviour
{

    public Item item;
    // This is the pickup script for the 2d Items
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Picking up " + item.name);
            bool wasPickedUp = Inventory.instance.Add(item); //adds it to inventory and destroys the original one on the floor
        }
    }
}
