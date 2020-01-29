using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class OndeCollectible : MonoBehaviour
{
    [SerializeField] SimpleSonarShader_Object simpleShader;
    Sequence sequence;
    IEnumerator timer;

    float lastTime;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Light());
        //simpleShader.StartSonarRing(transform.position, 1)
        //sequence = DOTween.Sequence();
        //sequence.AppendInterval(0.5f).OnComplete(() => simpleShader.StartSonarRing(transform.position, 1));
        //sequence.Restart();
    }

    private IEnumerator Light()
    {
        lastTime = Time.time;
        for (; ; )
        {
            if(lastTime + 0.5f < Time.time)
            {
                lastTime = Time.time;
                simpleShader.StartSonarRing(transform.position, 1);
                print("LIGHT");
            }
            yield return null;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
