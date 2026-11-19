using UnityEngine;
using System.Collections;

public class GoodAd : MonoBehaviour
{
    // Starts Coroutine
    public void Start()
    {
        StartCoroutine(CountdownUntilDeath());
    }
    // this one will also have a lifetime
    IEnumerator CountdownUntilDeath()
    {
        yield return new WaitForSeconds(5f);
        Destroy(transform.parent.gameObject);
    }

    void OnMouseDown()
    {
        // Not only should this destroy the ad it should destroy all parent objects in its radius
        Destroy(transform.parent.gameObject);
    }
}
