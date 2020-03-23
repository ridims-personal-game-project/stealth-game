using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    private Vector2 movement;
    private SpriteRenderer mySpriteRenderer;
    bool isFacingRight = true;
    /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
    void Awake()
    {
        mySpriteRenderer = GetComponent<SpriteRenderer>();
    }

    /// <summary>
    /// This function is called every fixed framerate frame, if the MonoBehaviour is enabled.
    /// </summary>
    void FixedUpdate()
    {
        //Standard movement script
        float inputX = Input.GetAxisRaw("Horizontal");
        Debug.Log("X " + inputX);
        float inputY = Input.GetAxisRaw("Vertical");
        Debug.Log("Y " + inputY);
        movement = new Vector2(inputX, inputY);

        transform.Translate(movement * speed * Time.deltaTime);

        if(inputX == -1 && isFacingRight){
            mySpriteRenderer.flipX = true;
        }
        if(inputX == 1 && isFacingRight){
            mySpriteRenderer.flipX = false;
        }
    }
}
