using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Grail : MonoBehaviour
{
    public Image grailImage;
    public Sprite iconGrail;
    public Sprite iconNoGrail;
    private bool carryingGrail = false;
    void OnTriggerEnter2D(Collider2D hit)
    {
        if (hit.CompareTag("grail"))
        {
            carryingGrail = true;
            UpdateGrailImage();
            Destroy(hit.gameObject);
        }
    }
    private void UpdateGrailImage()
    {
        if (carryingGrail)
            grailImage.sprite = iconGrail;
        else
            grailImage.sprite = iconNoGrail;
    }
}