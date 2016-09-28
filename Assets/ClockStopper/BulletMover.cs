using UnityEngine;
using System.Collections;

public class BulletMover : MonoBehaviour {

    public ClockStopper clockStopper;

    public float moveSpeedX;
    public float moveSpeedY;

    public float rotateSpeed;

    private Vector3 tempPos;
    private Quaternion tempRotation;

    // Use this for initialization
    void Start () {
        clockStopper = GameObject.FindGameObjectWithTag("GameController").GetComponent<ClockStopper>();



        Destroy(this.gameObject, 5f);
	}
	
	// Update is called once per frame
	void Update () {
        tempPos = transform.localPosition;
       
        tempPos.x += Time.deltaTime * moveSpeedX * clockStopper.myTimeBend;
        tempPos.y += Time.deltaTime * moveSpeedY;

        transform.localPosition = tempPos;


        transform.Rotate(0 , 0, rotateSpeed * clockStopper.myTimeBend);
    }

    public void directionFlip()
    {

          moveSpeedX *= -1f;
    }
}
