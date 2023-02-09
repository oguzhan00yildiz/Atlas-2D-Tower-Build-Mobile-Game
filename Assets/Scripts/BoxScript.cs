using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxScript : MonoBehaviour
{

    private float min_X = -2.2f, max_X = 2.2f;

    private bool canMove;
    private float move_Speed = 2f;

    private Rigidbody2D myBody;

    private bool gameOver;
    private bool ignoreCollision;
    private bool ignoreTrigger;


    void Awake()
    {

        myBody = GetComponent<Rigidbody2D>();  
        myBody.gravityScale = 0;        // atılacak kutuların yerçekimi kuvvetini başta sıfırlıyoruz



    }



    // Start is called before the first frame update
    void Start()
    {
        canMove = true;

        if (Random.Range(0, 2) > 0)
        {
            move_Speed *= -1f;                      

        }

        GameplayController.instance.currentBox = this;  // kutuyu yaratıyoruz





    }

    // Update is called once per frame
    void Update()
    {

        Movebox();
    }

    void Movebox()  // // kutu sola giderse sağa sağa giderse sola gitmesini sağlıyoruz
    {


        if (canMove)
        {

            Vector3 temp = transform.position;

            temp.x += move_Speed * Time.deltaTime;

            if (temp.x > max_X)
            {
                move_Speed *= -1f;

            }
            else if (temp.x < min_X)

            {
                move_Speed *= -1f;
            }

            transform.position = temp;


        }



    }

    public void DropBox()
    {
        canMove = false;
        myBody.gravityScale = Random.Range(2, 4);  // kutuyu 2 ila 4 arasında g kuvvetiyle yukarıdan bırakıyoruz
    }

    void Landed()
    {
        if (gameOver)
            return;

        ignoreCollision = true;
        ignoreTrigger = true;

        GameplayController.instance.SpawnNewBox();  //kutu yere inince yeni kutumuzu canlandırıyoruz
        GameplayController.instance.MoveCamera();   //kameramızı yukarı kaldırıyoruz





    }


    void RestartGame()
    {
        GameplayController.instance.RestartGame();  //oyunu yeniden başlatma kodumuz
    }

    void OnCollisionEnter2D(Collision2D target)
    {
        if (ignoreCollision)
            return;

        if (target.gameObject.tag == "Platform")  
        {
            Invoke("Landed", 2f);
            ignoreCollision = true;
        }

        if (target.gameObject.tag == "Box") //kutu eğer başka kutuya çarparsa yeni kutu yaratılıyor
        {
            Invoke("Landed", 2f);
            ignoreCollision = true;
        }

    }

    void OnTriggerEnter2D(Collider2D target)
    {

        if (ignoreTrigger)
            return;
        if (target.tag == "GameOver")   //kutu eğer platforma çarparsa oyun bitiyor
        {
            CancelInvoke("Landed");
            
            gameOver = true;
            ignoreTrigger = true;

            Invoke("RestartGame", 2f); //restart menüsü açılıyor

        }
    }




}
