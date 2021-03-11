using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Player : MonoBehaviour
{
    public Text sqText;
    private int totalSq = 0;
    void Start()
    {
        UpdateSqText();
    }
    void OnTriggerEnter2D(Collider2D hit)
    {
        if (hit.CompareTag("sq"))
        {
            totalSq++;
            UpdateSqText();
            Destroy(hit.gameObject);
        }
    }
    private void UpdateSqText()
    {
        string sqMessage = "SQ = " + totalSq;
        sqText.text = sqMessage;
    }
}