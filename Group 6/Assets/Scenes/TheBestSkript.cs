using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheBestSkript : MonoBehaviour
{
    public float speed = 50;
    // Update is called once per frame
    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.up * verticalInput * Time.deltaTime * speed);
    }
}
