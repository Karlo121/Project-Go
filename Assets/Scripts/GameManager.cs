using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject stone;
    

    void Update()
    {
       if (Input.GetMouseButtonDown(0)) {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);

            if (hit.collider.CompareTag("ClickPoint")) {
                SpawnStone(hit.collider.transform.position.x, hit.collider.transform.position.y, -2);
            }
            else {
                Debug.Log("Wrong placement");
            }
        }
    }

    public void SpawnStone(float x,float y, float z) {
        Instantiate(stone, new Vector3(x,y,z), Quaternion.identity);
    }




    
    

}
