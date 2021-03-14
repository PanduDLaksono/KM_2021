using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Player : MonoBehaviour
{
    private PlayerInventoryDisplay playerInventoryDisplay;
    private int totalSq = 0;
    void Start()
    {
        playerInventoryDisplay = GetComponent<PlayerInventoryDisplay>
        ();
    }
    void OnTriggerEnter2D(Collider2D hit)
    {
        if (hit.CompareTag("sq"))
        {
            totalSq++;
            playerInventoryDisplay.OnChangeSqTotal(totalSq);
            Destroy(hit.gameObject);
        }
    }
}