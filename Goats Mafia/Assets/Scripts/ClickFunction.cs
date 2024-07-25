using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickFunction : MonoBehaviour
{
    [SerializeField] GameObject trash;
    private bool near = false;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            near = true;
        }
    }
    public void OnMouseDown()
    {
        if (near == true)
        {
            DestroyImmediate(trash);
        }
    }
}
