using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    private BallPlayer ball;

    private Vector3 moveDirection;
    private bool jump;

    [SerializeField]
    private GameObject explosion;

    private float moveHorizontal, moveVertical;

    private void Awake()
    {
        ball = GetComponent<BallPlayer>();
    }

    private void Update()
    {
        moveHorizontal = Input.GetAxis(TagManager.HORIZONTAL_TAG);
        moveVertical = Input.GetAxis(TagManager.VERTICAL_Tag);

        jump = Input.GetKeyDown(KeyCode.Space);
        moveDirection = new Vector3(-moveVertical, 0f, moveHorizontal).normalized;
    }

    private void FixedUpdate()
    {
        ball.Move(moveDirection);
        ball.Jump(jump);
    }

    public void DestroyPlayer()
    {
        Instantiate(explosion,transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}//classs






















