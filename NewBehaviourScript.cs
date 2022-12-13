using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public SpriteRenderer spriteRenderer;
    public Sprite[] spriteArray;

    void Update()
    {  
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * 0.02f );
            spriteRenderer.sprite = spriteArray[];
        }
        else if (Input.GetKey(KeyCode.A))
        {
          transform.Translate(Vector3.left * 0.02f );
          spriteRenderer.sprite = spriteArray[];
        }
        else if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * 0.02f );
            spriteRenderer.sprite = spriteArray[];
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * 0.02f );
            spriteRenderer.sprite = spriteArray[];
        }
    }
}
