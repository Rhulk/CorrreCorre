using UnityEngine;
using System.Collections;

public class SeguirPersonaje : MonoBehaviour {

	public Transform personaje;
	public float separacion = 6f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per framef 
	void Update () {
		transform.position = Vector3 (personaje.position.x + separacion, transform.posiontion.y, transform.position.z);
	}
}
