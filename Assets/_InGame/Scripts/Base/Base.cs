using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Base : MonoBehaviour
{
    public GameObject UI;
    public void OnMouseDown()
    {
        UI.gameObject.SetActive(true);
    }
    public void ClosePanel()
    {
        UI.gameObject.SetActive(false);
    }
}
