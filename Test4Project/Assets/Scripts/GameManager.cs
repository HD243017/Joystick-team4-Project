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

    //������ 18-11-21 Ÿ�� ������ �� Ÿ�� ����
    void OnHit(int dmg)
    {
        // ������ ���� �� ��


        // health�� �ӽ� ����
        int health = 1;
        if(health <= 0)
        {
            //���� ���
            //������Ʈ �ı�
        }


    }

    // Update is called once per frame
    void Update()
    {
        


        //������ UI Score Update
        //scoreText.text = 
    }
}
