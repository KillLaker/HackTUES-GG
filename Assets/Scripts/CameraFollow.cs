using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
public Camera cam;
    public Transform player;
    void Update()
    {
        Vector3 Followposition = new Vector3(player.position.x, player.position.y, -10);

        Vector3 Movedir = (Followposition - cam.transform.position).normalized;
        float distance = Vector3.Distance(Followposition, cam.transform.position);
        float Cameraspeed = 5f;

        cam.transform.position = cam.transform.position + (Movedir * distance * Cameraspeed * Time.deltaTime);
    }


}
