using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ButtonPad : MonoBehaviour {

    public GameObject player;

    private Rigidbody2D rb;

    void Start()
    {
        rb = player.GetComponent<Rigidbody2D>();
    }

	public void MoveForward()
    {
        
    }
}
