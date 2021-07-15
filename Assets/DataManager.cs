using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour{
    static DataManager instance;


    public static DataManager Instance{
        get{return instance;}
    }

    private void Awake(){
        if(instance == null){
            DontDestroyOnLoad(gameObject); // 씬 이동해도 오브젝트 유지함 -> 시간 데이터 사운드 오브젝트 같은ㄴ것에 설정
            instance = this;
        }

        else{
            DestroyObject(gameObject);
        }
    }

    public int score = 0;
}
