using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RFB_Transform : MonoBehaviour
{
    public Camera camera;
   // public Animator question1Animator;      
    Vector2 startPosition;
    [SerializeField] GameObject nextButton;   
   


    [SerializeField] GameObject[] box_list;

    private void OnMouseDrag()
    {
        Vector3 position = camera.ScreenToWorldPoint(Input.mousePosition);
        position.z = 0;
        transform.position = position;
    }

    void Start()
    {
        startPosition = transform.position;       

    }


    void Update()
    {
       

        if (Input.GetMouseButtonUp(0))
        {
            foreach (GameObject box in box_list)
            {

                if (box.name.Equals(gameObject.name))
                {
                    float mesafe = Vector3.Distance(box.transform.position, transform.position);

                    if (mesafe <= 1)
                    {
                        transform.position = box.transform.position;
                       
                       nextButton.SetActive(true);                     
                                                       
                    }
                    else
                    {
                        transform.position = startPosition;
                       
                    }

                }
            }

        }

        
    }



    
}







