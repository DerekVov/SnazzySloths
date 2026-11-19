using System;
using UnityEditor;
using UnityEngine;

public class Ads : MonoBehaviour
{
   //what I was thinking is on button press, destroy object clone.
   //I can potentially inherit this to the good and bad ads if we do end up having time with this
   public void CloseAd()
   {
      Destroy(gameObject);
   }
}
