using System;
using UnityEditor;
using UnityEngine;

public class Ads : MonoBehaviour
{
      void OnMouseDown()
      {
         Destroy(transform.parent.gameObject);
      }
}
