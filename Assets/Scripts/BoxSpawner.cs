using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxSpawner : MonoBehaviour
{
    public GameObject box_Prefab;
    public GameObject box_Prefab1;
    public GameObject box_Prefab2;
    public GameObject box_Prefab3;
    public GameObject box_Prefab4;
    
    public int x;
   


    public void SpawnBox(int x)  //kutu yaratma kodumuz random birşekilde 5 kutudan birini yaratmak için
    {

        
        



        

        if (x == 1)
        {
            GameObject box_Obj = Instantiate(box_Prefab);  
            Vector3 temp = transform.position;
            temp.z = 0f;


            box_Obj.transform.position = temp;


        }
        else if(x==2)
        {


            GameObject box_Obj1 = Instantiate(box_Prefab1);
            Vector3 temp = transform.position;
            temp.z = 0f;


            box_Obj1.transform.position = temp;


        }

        else if (x==3)
        {

            GameObject box_Obj2 = Instantiate(box_Prefab2);
            Vector3 temp = transform.position;
            temp.z = 0f;

            box_Obj2.transform.position = temp;





        }








        else if (x==4)
        {

            GameObject box_Obj3 = Instantiate(box_Prefab3);
            Vector3 temp = transform.position;
            temp.z = 0f;


            box_Obj3.transform.position = temp;





        }


        else
        {



            GameObject box_Obj4 = Instantiate(box_Prefab4);
            Vector3 temp = transform.position;
            temp.z = 0f;


            box_Obj4.transform.position = temp;


        }

        

        






    }






}
