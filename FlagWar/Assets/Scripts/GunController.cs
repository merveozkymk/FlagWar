using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    public GameObject cross;
    private Vector3 mousePos;
    public float offSet;
    void Update()
    {
        mousePos = Camera.main.ScreenToWorldPoint(new Vector3(
            Input.mousePosition.x,
            Input.mousePosition.y,
            transform.position.z
        ));

        cross.transform.position = new Vector3(
            mousePos.x,
            mousePos.y,
            transform.position.z
        );
    }
    void FixedUpdate()
    {
        float rotateZ = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotateZ + offSet);
    }
}
