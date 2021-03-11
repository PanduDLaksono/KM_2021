using UnityEngine;
using System.Collections;
public class PlayerInventory : MonoBehaviour
{
    private PlayerInventoryDisplay playerInventoryDisplay;
    private bool carryingSq = false;
    void Start()
    {
        playerInventoryDisplay = GetComponent<PlayerInventoryDisplay>();
        playerInventoryDisplay.OnChangeCarryingSq(carryingSq);
    }
    void OnTriggerEnter2D(Collider2D hit)
    {
        if (hit.CompareTag("sq"))
        {
            carryingSq = true;
            playerInventoryDisplay.OnChangeCarryingSq(carryingSq);
            Destroy(hit.gameObject);
        }
    }
}