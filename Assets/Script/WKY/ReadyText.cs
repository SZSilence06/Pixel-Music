using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ReadyText : MonoBehaviour {
    int frame = 0;
    Text text = null;

	// Use this for initialization
	void Start () {
        this.text = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        frame++;
        if(frame == 100)
        {
            this.text.text = "Go!";
        }
        if(frame >= 170 && frame <= 200)
        {
            Color newColor = text.color;
            newColor.a -= 1.0f / 30.0f;
            text.color = newColor;
        }
        if(frame == 200)
        {
            DestroyObject(this.gameObject);
        }
	}
}
