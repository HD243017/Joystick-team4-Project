using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{



    public Text scoreText;
    public Image[] lifeImage;
    public GameObject gameOverSet;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    //정용진 18-11-21 타격 데미지 및 타격 점수
    void OnHit(int dmg)
    {
        // 데미지 들어가야 할 것


        // health는 임시 변수
        int health = 1;
        if(health <= 0)
        {
            //점수 계산
            //오브젝트 파괴
        }


    }

    // Update is called once per frame
    void Update()
    {
        


        //정용진 UI Score Update
        //scoreText.text = 
    }
}
