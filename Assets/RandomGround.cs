using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomGround : MonoBehaviour
{

    List<GameObject> ground;

    int count;

    // Start is called before the first frame update
    void Start()
    {
        ground = new List<GameObject>();
        count = 3;
        
    }
    //버튼을 눌럿을때
    //카운트 다운 후
    //바닥이 사라짐

    public void BtnClick()
    {
        count -= 1;
        int ran = Random.Range(0, 1);

        ground[ran].gameObject.SetActive(false);

    }
}
