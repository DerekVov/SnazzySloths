using System.Collections;
using UnityEngine;

public class AdPlacer : MonoBehaviour
{
    public GameObject AdPrefab;
    private bool isOkToCreate = true;

    [SerializeField] private GameObject adArea;
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
        float secondsToWait = Random.Range(GameParameters.AdMinSecondsToWait,GameParameters.AdMaxSecondsToWait);
        yield return new WaitForSeconds(secondsToWait);
        Place();
        isOkToCreate = true;
    }

    private void Place()
    {
        float randomX = Random.Range(-6.5f, 6.5f);
        float randomY = Random.Range(-3.5f, 3.5f);
        Instantiate(AdPrefab, new Vector3(randomX, randomY, 10), Quaternion.identity);
    }
}
