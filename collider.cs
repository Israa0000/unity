using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class collider : MonoBehaviour
{
    [SerializeField] GameObject redRotateSquare;
    [SerializeField] GameObject blueRotateSquare;
    [SerializeField] GameObject redSquare;
    [SerializeField] GameObject blueSquare;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (CompareTag("PlayerRed"))
        {
            redRotateSquare.GetComponent<SpriteRenderer>().color = Color.magenta;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        
    }
}