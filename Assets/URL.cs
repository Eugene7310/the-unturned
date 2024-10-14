using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class URL : MonoBehaviour
{
    public void OpenURL()
    {
        //Copy your portfolio website URL and past here

        Application.OpenURL("https://sites.google.com/d/1s7ErRfaBh2tPbWN17Hvfm__djRHVHO0v/p/1GyuBqQe7mph8fpXAc4I0t1UHx9qvcRXa/edit");
        Debug.Log("is this working");
    }
}
