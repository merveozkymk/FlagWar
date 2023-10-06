using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class FlagController : MonoBehaviour
{
    public GameObject player;
    public GameObject FlagPoint;
    public GameObject Controller;
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            transform.SetParent(player.transform);
            transform.localPosition = Vector3.zero;
        }
        if (col.tag == "Enemy")
        {
            transform.SetParent(FlagPoint.transform);
            transform.localPosition = Vector3.zero;
        }
        if (col.tag == "WinPoint1")
        {
            Controller.GetComponent<PanelController>().LevelPanelControl();
        }
        if (col.tag == "WinPoint2")
        {
            Controller.GetComponent<PanelController>().WinPanelControl();
        }
    }
}
