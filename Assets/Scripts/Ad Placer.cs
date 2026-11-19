using System.Collections;
using UnityEngine;

public class AdPlacer : MonoBehaviour
{
    public GameObject AdPrefab;
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
        float secondsToWait = Random.Range(GameParameters.AdMinSecondsToWait,GameParameters.AdMaxSecondsToWait);
        yield return new WaitForSeconds(3f);
        Place();
        isOkToCreate = true;
    }

    private void Place()
    {
        Vector3 location = SpawnTools.RandomLocationWorldSpace();
        print(location.x + ", " + location.y);
        Instantiate(AdPrefab, SpawnTools.RandomLocationWorldSpace(), Quaternion.identity);
    }
}
