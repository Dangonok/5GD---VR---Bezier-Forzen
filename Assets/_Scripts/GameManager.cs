using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    public GameDatas datas;
    public List<SimpleSonarShader_Object> sonarObject = new List<SimpleSonarShader_Object>();
    public List<Collectible> collectibles = new List<Collectible>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void SetSonar()
    {
        for (int i = 0; i < sonarObject.Count; i++)
        {
            for (int j = 0; j < collectibles.Count; j++)
            {
                sonarObject[i].StartSonarRing(collectibles[j].transform.position,10000);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
