using UnityEngine;
using System.Collections;

public class PlayerMover : MonoBehaviour {
    public float moveSpeed = 10;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 tempPos = transform.position;
        if (Input.GetKey("d"))
        {
            tempPos.x += Time.deltaTime * moveSpeed;
        }

        if (Input.GetKey("a"))
        {
            tempPos.x -= Time.deltaTime * moveSpeed;
        }

        if (Input.GetKey("w"))
        {
            tempPos.z += Time.deltaTime * moveSpeed;
        }

        if (Input.GetKey("s"))
        {
            tempPos.z -= Time.deltaTime * moveSpeed;
        }

        transform.position = tempPos;
    }
}
