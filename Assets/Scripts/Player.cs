using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    public SpriteRenderer spriteRenderer;
    public Sprite[] sprites;
    public int spriteIndex;
    public bool moveable = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
   

    void FixedUpdate()
    {
        var keyboard = Keyboard.current;
        if (keyboard == null)
        { return; }

        if (moveable)
        {
            if (keyboard.upArrowKey.isPressed || keyboard.wKey.isPressed)
            {
                transform.rotation = Quaternion.identity;
                spriteIndex = 0;
                spriteRenderer.sprite = sprites[spriteIndex];
                rb.linearVelocityY += 0.1f;
            }

            if (keyboard.downArrowKey.isPressed || keyboard.sKey.isPressed)
            {
                transform.rotation = Quaternion.Euler(0, 0, 180);
                spriteIndex = 1;
                spriteRenderer.sprite = sprites[spriteIndex];
                rb.linearVelocityY -= 0.1f;
            }

            if (keyboard.leftArrowKey.isPressed || keyboard.aKey.isPressed)
            {
                transform.rotation = Quaternion.Euler(0, 0, 90);
                spriteIndex = 2;
                spriteRenderer.sprite = sprites[spriteIndex];
                rb.linearVelocityX -= 0.1f;
            }

            if (keyboard.rightArrowKey.isPressed || keyboard.dKey.isPressed)
            {
                transform.rotation = Quaternion.Euler(0, 0, 270);
                spriteIndex = 3;
                spriteRenderer.sprite = sprites[spriteIndex];
                rb.linearVelocityX += 0.1f;
            }
        }

        if (spriteIndex >= 2)
        {
            rb.linearVelocityY *= 0.9f;
        }
        else if (spriteIndex <= 1)
        {
            rb.linearVelocityX *= 0.9f;
        }
    }
}
