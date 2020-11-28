using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomEle : MonoBehaviour
{
    float randomX ;
    float randomZ ;
    
    public GameObject EleInstance;
    bool canCreate=true;

    // Update is called once per frame
    void Start()
    {
        randomX = Random.Range(0f,500f);
        randomZ = Random.Range(0f,500f);
        CreateEle();
    }

    void CreateEle()
    {
        Debug.Log("함수실행");
        if(canCreate){
            Instantiate(EleInstance, new Vector3(randomX,0f,randomZ),Quaternion.identity);
            StartCoroutine(WaitforResponseEle());
            Debug.Log("만들었습니다.");
            canCreate = false;
        }
    }

    IEnumerator WaitforResponseEle()
    {
        randomX = Random.Range(0f,500f);
        randomZ = Random.Range(0f,500f);
        yield return new WaitForSeconds(1f);
        canCreate = true;
    }
}
