using UnityEngine;
using System.Collections;

public class BadAd : MonoBehaviour
{
    public GameObject AdPrefab;
    int count = 0;
    
    public void Start()
    {
        StartCoroutine(CountdownUntilDeath());
    }

    IEnumerator CountdownUntilDeath()
    {
        yield return new WaitForSeconds(5f);
        Destroy(transform.parent.gameObject);
    }

    void OnMouseDown()
    {
        while(count < 5){
            float randomX = Random.Range(-6.5f, 6.5f);
            float randomY = Random.Range(-4f, 4f);
            Instantiate(AdPrefab, new Vector3(randomX, randomY, 10), Quaternion.identity);
            count++;
        }
        Destroy(transform.parent.gameObject);
        count = 0;
    }
}
