using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mouse : MonoBehaviour
{
    private Camera cam;
    private Vector3 targetPosition;

    void Start()
    {
        Debug.Log(transform.gameObject.name);
        cam = Camera.main;
    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            Debug.Log($"Input mouse Poisition: {Input.mousePosition}");


            targetPosition = cam.ScreenToWorldPoint(Input.mousePosition);
            targetPosition.z = 0f;


            Vector3 direction = targetPosition - transform.position;
            Quaternion rotation = Quaternion.LookRotation(Vector3.forward, direction);
            transform.rotation = rotation;


        }
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, 0.09f);

       
    }


}
