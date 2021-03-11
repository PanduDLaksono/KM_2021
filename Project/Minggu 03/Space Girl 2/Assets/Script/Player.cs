using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Player : MonoBehaviour
{
    public Text sqText;
    private bool carryingSq = false;
    
    void Start(){
        UpdateSqText();
        }

    void OnTriggerEnter2D(Collider2D hit){
        if (hit.CompareTag("sq")){
            carryingSq = true;
            UpdateSqText();
            Destroy(hit.gameObject);
            }
    }

    private void UpdateSqText()
    {
        string sqMessage = "Tidak punya sq :(";
        if (carryingSq) sqMessage = "Punya sq :D";
        sqText.text = sqMessage;
    } 
}
