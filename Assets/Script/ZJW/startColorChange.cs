using UnityEngine;
using System.Collections;

public class startColorChange : MonoBehaviour
{

    private int frame = 0;
    private SpriteRenderer render;
    private bool isClick = false;
    void Start()
    {
        render = GetComponent<SpriteRenderer>();
    }
    void OnMouseDown()
    {
        isClick = true;
        render.color = render.color;
    }

    void OnMouseUp()
    {
    }
    void Update()
    {
        if (!isClick) {
            render.color = new Color((0.9f + 0.1f * Mathf.Sin(frame / 180f * Mathf.PI * 2f)), (0.9f - 0.1f * Mathf.Sin(frame / 180f * Mathf.PI * 2f)), (0.9f - 0.1f * Mathf.Sin(frame / 180f * Mathf.PI * 2f)));
        }
        frame++;
        if (frame>=180) {
            frame = 0;
        }
    }
}