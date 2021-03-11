using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class PlayerInventoryDisplay : MonoBehaviour
{
    public Text sqText;
    public void OnChangeCarryingSq(bool carryingSq)
    {
        string sqMessage = "Gada SQ";
        if (carryingSq) sqMessage = "Ada SQ hehe";
        sqText.text = sqMessage;
    }
}