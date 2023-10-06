using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthController : MonoBehaviour
{
    public int health = 3;
    public GameObject Heart1;
    public GameObject Heart2;
    public GameObject Heart3;
    public void HealthBar()
    {
        health--;
        if(health==2)
        {
            Heart1.gameObject.SetActive(false);
        }
        if (health==1)
        {
            Heart2.gameObject.SetActive(false);
        }
        if (health<=0)
        {
            Heart3.gameObject.SetActive(false);
        }
    }
}
