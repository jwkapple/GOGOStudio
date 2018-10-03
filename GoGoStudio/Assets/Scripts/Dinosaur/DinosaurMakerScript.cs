using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinosaurMakerScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}




    // ============================================== public funtion ============================================

    // 공룡 생성 함수
    // name 이름의 공룡을 pos 위치에 생성
    public void MakeDinosaur()
    {
        // 공룡을 가져와서..
        GameObject temp = Resources.Load("Dinosaur/TestDino") as GameObject;

        // Scene에 표시한 뒤..
        GameObject dino = MonoBehaviour.Instantiate(temp);

        // 지정된 위치로 이동
        dino.transform.position = new Vector2(0, 0);

        // DinosaursInfo에 공룡 생성을 알리며, 해당 공룡의 정보를 전송.
        GetComponent<DinosaursInfo>().AddDino(dino.GetComponent<DinosaurScript>());
    }




    // ============================================== private funtion ============================================




}
