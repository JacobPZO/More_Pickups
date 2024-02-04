using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuyBehavior : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Player")
        {
            Destroy(this.transform.parent.gameObject);

            Debug.Log("Broombally Doombally!!!");
        }
    }
}
