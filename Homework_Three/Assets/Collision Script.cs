using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCollision : MonoBehaviour
{
    int collisionCount = 0;
    private void OnCollisionEnter(Collision other) {
        collisionCount++;
        Debug.Log("Collided with the walls count: "+collisionCount);
        if (other.gameObject.tag == "Player"){
            GetComponent<MeshRenderer>().material.color = Color.blue;
        }
    }
}
