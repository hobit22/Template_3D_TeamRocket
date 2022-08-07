using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MobileT : MonoBehaviour
{
    public Text txt;
    private void OnMouseUp()
    {
        txt.text = "OnMouseUP";
    }
    private void OnMouseDrag()
    {
        txt.text = "OnMouseDrag";
    }
    private void OnMouseDown()
    {
        txt.text = "OnMouseDown";
    }
}
