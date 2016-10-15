using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TouchInput : MonoBehaviour {

    public LayerMask touchInputMask;
    private Camera playerCam;

    private List<GameObject> touchlist = new List<GameObject>();
    private GameObject[] touchesOld;

    void Start()
    {
        playerCam = this.gameObject.GetComponent<Camera>();
    }

	void Update () 
    {
	
        if(Input.touchCount > 0)
        {
            touchesOld = new GameObject[touchlist.Count];
            touchlist.CopyTo(touchesOld);
            touchlist.Clear();


            foreach (Touch touch in Input.touches)
            {
                Ray ray = playerCam.ScreenPointToRay(touch.position);
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit, touchInputMask))
                {
                    GameObject recipient = hit.transform.gameObject;
                    touchlist.Add(recipient);

                    if (touch.phase == TouchPhase.Began)
                    {
                        recipient.SendMessage("OnTouchDown", hit.point, SendMessageOptions.DontRequireReceiver);
                    }

                    if (touch.phase == TouchPhase.Ended)
                    {
                        recipient.SendMessage("OnTouchUp", hit.point, SendMessageOptions.DontRequireReceiver);
                    }

                    if (touch.phase == TouchPhase.Stationary || touch.phase == TouchPhase.Moved)
                    {
                        recipient.SendMessage("OnTouchStay", hit.point, SendMessageOptions.DontRequireReceiver);
                    }

                    if (touch.phase == TouchPhase.Canceled)
                    {
                        recipient.SendMessage("OnTouchExit", hit.point, SendMessageOptions.DontRequireReceiver);
                    }
                } 
            }
            foreach (GameObject g in touchesOld)
            {
                if (!touchlist.Contains(g))
                {
                    g.SendMessage("OnTouchExit", SendMessageOptions.DontRequireReceiver);
                }
            }
        }
	}
}
