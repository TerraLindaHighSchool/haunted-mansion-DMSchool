using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCollection : MonoBehaviour
{

    public Transform player;
    public GameObject GohstWall;

    void OnTriggerEnter(Collider col)
    {
        Debug.Log("bang");
        if (col.gameObject.name == player.name)
        {
            Debug.Log("hit");
            Destroy(GohstWall);
            Destroy(this.gameObject);
        }
    }
}
