using UnityEngine;
using System.Collections;

public class GoodAd : MonoBehaviour
{
    public float destroyRadius = 3f;
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
        // Find all colliders within the radius
        Collider2D[] nearbyObjects = Physics2D.OverlapCircleAll(transform.parent.position, destroyRadius);

        // Destroy all nearby parent objects
        foreach (Collider2D nearby in nearbyObjects)
        {
            Destroy(nearby.transform.parent.gameObject);
        }
    }
}
