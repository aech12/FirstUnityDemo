using UnityEngine;
using UnityEngine.AI;

public class Interactable : MonoBehaviour
{
    public bool isInteractable = false;
    public Popup_Lvl1_Menu popupMenu; // Reference to the Popup_Lvl1_Menu script

    void Update()
    {
        if (isInteractable && Input.GetMouseButtonDown(0))
        {
            popupMenu.OpenMenu();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            isInteractable = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            isInteractable = false;
        }
    }    
}