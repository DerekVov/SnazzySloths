using System.Collections;
using UnityEngine;

public class AdPlacer : MonoBehaviour
{
    public GameObject AdPrefab;

    void Update()
    {
        StartCoroutine(CountDownUntilCreation());
    }
    IEnumerator CountDownUntilCreation()
    {
        yield return new WaitForSeconds(3f);
        Place();
    }

    private void Place()
    {
        Instantiate(AdPrefab, SpawnTools.RandomLocationWorldSpace(), Quaternion.identity);
    }
}
