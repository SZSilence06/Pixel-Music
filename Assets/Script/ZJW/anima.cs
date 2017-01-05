using UnityEngine;
using System.Collections;

public class anima : MonoBehaviour {
    public GameObject pixels;
    private int frame = 0;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        foreach (Transform child in pixels.transform)
        {
            if (frame < 180)
            {
                child.Rotate(new Vector3(2.0f, 2.0f, 0.0f));
            }
            if (frame >= 180 && frame<360)
            {
                child.Rotate(new Vector3(0.0f, 2.0f, 2.0f));
            }
            if (frame >= 360 && frame < 540)
            {
                child.Rotate(new Vector3(2.0f, 0.0f, 2.0f));
            }
        }
        frame++;
        if (frame>=540) {
            frame = 0;
        }
	}
}
