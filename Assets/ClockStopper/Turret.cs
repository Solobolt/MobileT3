using UnityEngine;
using System.Collections;

public class Turret : MonoBehaviour {

    public GameObject projectile;
    public float fireRate = 1f;

    private float timer;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;
        if (timer<=0)
        {

            GameObject curBullet = Instantiate(projectile,transform,false) as GameObject;

            if (transform.localPosition.x < 0)
            {
                curBullet.GetComponent<BulletMover>().directionFlip();
            }

            print("Fire");
            timer = 1f / fireRate;
        }
	}

    void OnValidate()
    {
        if (fireRate<=0)
        {
            fireRate = 0.001f;
        }
    }
}
