using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameManager.Instance.collectibles.Add(this);
        GameManager.Instance.SetSonar();
    }

    private void OnDestroy()
    {
        GameManager.Instance.collectibles.Remove(this);
    }
}
