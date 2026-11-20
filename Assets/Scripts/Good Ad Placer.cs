using UnityEngine;
using System.Collections;

public class GoodAdPlacer : MonoBehaviour
{
    public GameObject GoodAdPrefab;
    private bool isOkToCreate = true;

    
    void Update()
    {
        if (isOkToCreate)
        {
            StartCoroutine(CountDownUntilCreation());
        }
        
    }
    IEnumerator CountDownUntilCreation()
    {
        isOkToCreate = false;
        float secondsToWait = Random.Range(GameParameters.GoodAdMinSecondsToWait,GameParameters.GoodAdMaxSecondsToWait);
        yield return new WaitForSeconds(secondsToWait);
        Place();
        isOkToCreate = true;
    }

    private void Place()
    {
        float randomX = Random.Range(-6.5f, 6.5f);
        float randomY = Random.Range(-3.5f, 3.5f);
        Instantiate(GoodAdPrefab, new Vector3(randomX, randomY, 10), Quaternion.identity);
    }
}
