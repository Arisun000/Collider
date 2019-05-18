using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RayCon : MonoBehaviour
{
	private float distance = 50;
	private int i;
	public int health = 50;
	public GameObject Enemy;
    void Start()
    {
    	
    }

    void Update()
    {
    	RaycastHit hit;
    	Vector3 center = new Vector3(Screen.width/2,Screen.height/2);
        Ray ray = Camera.main.ScreenPointToRay(center);
        Debug.DrawRay (ray.origin, ray.direction * distance, Color.red);
		
		if (Physics.Raycast(ray, out hit, 50.0f)) {
  		//Rayが当たるオブジェクトがあった場合
			if(hit.collider.tag == "Enemy" && Input.GetMouseButton(0)) {
				health--;
			}
    }

    	if(health <= 0) {
    		Destroy(Enemy);
		}
	}
}
