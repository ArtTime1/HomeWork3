using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeMaterial : MonoBehaviour
{   
   public Material material;
   public GameObject[] Starships;
   
    public void ChangeMaterials()
    { for (int i = 0; i < Starships.Length; i++)
        {
            if (Starships[i].activeSelf == true)
            {
                Starships[i].GetComponent<MeshRenderer>().material = material;

            }
        }
       
    }
        
    

    
}
