using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TrapMove : MonoBehaviour {

    private RectTransform trans;
    private Vector2 size;
    private float hieght;

    public float speed = 100.0f;
	// Use this for initialization
	void Start () {
        trans = this.gameObject.GetComponent<RectTransform>();
        size = trans.sizeDelta;
        hieght = size.y;
        print(Screen.height);
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 tempPos = transform.position;
        tempPos.y -= Time.deltaTime * speed;
        transform.position = tempPos;
	}


}
