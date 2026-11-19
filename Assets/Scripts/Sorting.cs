using UnityEngine;

public class Sorting : MonoBehaviour
{
    private static int nextSortingOrder = 0;

    void Awake()
    {
        SpriteRenderer[] renderers =
            GetComponentsInChildren<SpriteRenderer>();

        foreach (SpriteRenderer sr in renderers)
        {
            if (sr.gameObject.name == "Close")
            {
                sr.sortingOrder = nextSortingOrder + 1;
            }
            else
            {
                sr.sortingOrder = nextSortingOrder;
            }
        }

        nextSortingOrder += 2;
    }
}
