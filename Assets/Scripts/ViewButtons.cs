using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ViewButtons : MonoBehaviour
{
    
    public void upView()
    {
        GameObject.Find("ViewCamera").transform.position = new Vector3(-0.5f, 12f, 4f);
        GameObject.Find("ViewCamera").transform.rotation = Quaternion.AngleAxis(-90f, Vector3.left);
    }

    public void downView()
    {
        
        GameObject.Find("ViewCamera").transform.position = new Vector3(-0.5f, -12f, 4f);
        GameObject.Find("ViewCamera").transform.rotation = Quaternion.AngleAxis(90f, Vector3.left);
    }

    public void faceView()
    {
        GameObject.Find("ViewCamera").transform.position = new Vector3(0f, 2f, -8f);
        GameObject.Find("ViewCamera").transform.rotation = Quaternion.AngleAxis(0f, Vector3.left);
    }

    public void leftView()
    {
        GameObject.Find("ViewCamera").transform.position = new Vector3(15f, 2f, 2f);
        GameObject.Find("ViewCamera").transform.rotation = Quaternion.AngleAxis(-90f, Vector3.up);
    }
}

