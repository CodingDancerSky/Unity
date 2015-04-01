using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	private Space
	void FixedUpdate(){
		
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f ,moveVertical);
		
		//GetComponent<Rigidbody>().AddForce(movement * speed * Time.deltaTime);
		//rigidbody.AddForce(movement * speed * Time.deltaTime);
		
	}
}
