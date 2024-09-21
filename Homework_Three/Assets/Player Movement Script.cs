using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float speed = 7f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xValue = Input.GetAxis("Horizontal")* Time.deltaTime * speed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        transform.Translate(xValue, 0, zValue);

    }
}
