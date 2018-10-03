using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinosaursInfo : MonoBehaviour {

    // 모든 공룡들을 관리
    List<DinosaurScript> dinosaurs = new List<DinosaurScript>();




	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}



    // ============================================== public funtion ============================================

    // 새로운 공룡을 추가
    public void AddDino(DinosaurScript dino)
    {
        dinosaurs.Add(dino);
    }

    // 해당 정보의 공룡을 삭제, 근대 쓸 일이 없을듯?
    public void DeleteDino(string name)
    {

    }


    // ============================================== private funtion ============================================



}
