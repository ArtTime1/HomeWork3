using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeShip : MonoBehaviour
{
    public GameObject[] StarShips;
   
    void Start()
    {
        
    }


    public void RightChange()
    {
        for (int i = 0; i < StarShips.Length; i++)
        {
            if (StarShips[i].activeSelf == true)
            {
                if (i == StarShips.Length - 1)
                {
                    StarShips[i].SetActive(false);
                    i = 0;
                    StarShips[i].SetActive(true);
                    break;
                }
                StarShips[i].SetActive(false);
                StarShips[i + 1].SetActive(true);
                break;
            }
        }
    }

    public void LeftChange()
    {
        for (int i = 0; i < StarShips.Length; i++)
        {
            if (StarShips[i].activeSelf == true)
            {
                if (i == 0)
                {
                    StarShips[i].SetActive(false);
                    i = StarShips.Length - 1; ;
                    StarShips[i].SetActive(true);
                    break;
                }
                StarShips[i].SetActive(false);
                StarShips[i - 1].SetActive(true);
                break;
            }
        }
    }
}
