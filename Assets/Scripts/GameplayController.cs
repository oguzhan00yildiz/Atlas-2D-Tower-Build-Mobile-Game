using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameplayController : MonoBehaviour
{
    public static GameplayController instance;

    

    public BoxSpawner box_Spawner;
    [HideInInspector]
    public BoxScript currentBox;
    public CameraFollow cameraScript;
    private int moveCount;
    public int x;

    public panelscript panel_1; //panelscript scriptinden panelscript classına yeni alan oluşturup Panel i çektik

    void Awake()
    {
        if (instance == null)
            instance = this;
    }



    // Start is called before the first frame update
    void Start()
    {
        box_Spawner.SpawnBox(x=1);  //ilk kutumuz sabit



    }

    // Update is called once per frame
    void Update()
    {
        DetectInput();

        

    }

    void DetectInput()
    {

        if (Input.GetMouseButton(0))  //ekran dokununca kutuyu yuakrdan bırakıyoruz
        {
            currentBox.DropBox();
        }
    }

    public void SpawnNewBox()
    {
        Invoke("NewBox", 2f);

        
       
        ScoreScript2.instance.AddScore(); //yeni kutu yaratıyoruz
    }
    void NewBox()
    {
        x = Random.Range(1, 6);  //yaratılacak kutunun rastgele olmasını sağlıyoruz



        box_Spawner.SpawnBox(x);
    }


    public void MoveCamera()  //kamera haraketi kontrolü sağlar
    {
        
        if(x==1)
        {

            moveCount = moveCount + 2;



        }

        else
        {

            moveCount++;



        }





        

        if (moveCount>=2)
        {

            

            moveCount = 0;
            cameraScript.targetPos.y += 1f;

        }
    }
    public void RestartGame()   //oyunu restartlar
    {
       
    
       panel_1.Panel.gameObject.SetActive(true);
    
    }


}


