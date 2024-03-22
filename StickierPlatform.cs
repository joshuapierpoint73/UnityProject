using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickierPlatform : MonoBehaviour
{
    
  void OnCollisionEnter (Collision collision)
    {
        if (collision.gameObject.name == "Capsule")
        {
            collision.gameObject.transform.SetParent(transform);
        }

    }

   void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "Capsule")
        {
            collision.gameObject.transform.SetParent(null);
        }

    }
}
