using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Player : MonoBehaviour
{
    public Image sqImage;
    public Sprite iconSq;
    public Sprite iconNoSq;
    private bool carryingSq = false;
    void OnTriggerEnter2D(Collider2D hit)
    {
        if (hit.CompareTag("sq"))
        {
            carryingSq = true;
            UpdateSqImage();
            Destroy(hit.gameObject);
        }
    }
    private void UpdateSqImage()
    {
        if (carryingSq)
            sqImage.sprite = iconSq;
        else
            sqImage.sprite = iconNoSq;
    }
}