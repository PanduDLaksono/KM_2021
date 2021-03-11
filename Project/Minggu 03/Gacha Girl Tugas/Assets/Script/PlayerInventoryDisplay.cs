using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class PlayerInventoryDisplay : MonoBehaviour
{
    public Image[] sqPlaceholders;
    public Sprite iconSqYellow;
    public Sprite iconSqGrey;
    public void OnChangeSqTotal(int sqTotal)
    {
        for (int i = 0; i < sqPlaceholders.Length; ++i)
        {
            if (i < sqTotal)
                sqPlaceholders[i].sprite = iconSqYellow;
            else
                sqPlaceholders[i].sprite = iconSqGrey;
        }
    }
}