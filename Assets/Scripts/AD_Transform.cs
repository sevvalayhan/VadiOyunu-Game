using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class AD_Transform : MonoBehaviour
{
    public Camera camera;
    Vector2 startPosition;
    [SerializeField] GameObject nextButton;
    int yerlestirilenParca = 0;
    public GameObject[] box_list;
    


    private void OnMouseDrag()
    {
        Vector3 position = camera.ScreenToWorldPoint(Input.mousePosition);
        position.z = 0;
        transform.position = position;
    }

    void Awake()
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
                    float mesafe = Vector2.Distance(box.transform.position, transform.position);

                    if (mesafe <= 1)
                    {
                        transform.position = box.transform.position;

                        if (transform.position.Equals(box.transform.position))
                        {

                            //SayiArttir();
                            break;
                        }
                    }
                    else
                    {
                        transform.position = startPosition;
                    }
                }
            }
        }
    }
    void SayiArttir()
    {
        int toplamParcaSayisi = box_list.Count();
        yerlestirilenParca = yerlestirilenParca + 1;
        if (yerlestirilenParca.Equals(toplamParcaSayisi))
        {
            nextButton.SetActive(true);//bir sonraki soruya geçmek için bu buton aktifleþecek
        }

    }






}
