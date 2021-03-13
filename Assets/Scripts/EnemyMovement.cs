using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public GameObject WallCheckerL;
    public GameObject WallCheckerR;
    public LayerMask GroundLayer;
    private  bool IsRight = true;
    private RaycastHit2D coliderl;
    private RaycastHit2D coliderr;
    public float distance;
    public float speed;

    private void Update()
    {

        if (IsRight)
        {

            coliderr = Physics2D.Raycast(WallCheckerR.transform.position, Vector2.right, distance, GroundLayer);
            transform.Translate(Vector2.right * speed * Time.deltaTime);

        }
        else if (!IsRight)
        {
            coliderl = Physics2D.Raycast(WallCheckerL.transform.position, Vector2.left, distance, GroundLayer);
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }

        if (coliderl.collider != null && !IsRight)
        {
            GetComponent<SpriteRenderer>().flipX = false;
            IsRight = true;

        }
        else if (coliderr.collider != null && IsRight)
        {
            GetComponent<SpriteRenderer>().flipX = true;
            IsRight = false;

        }


    }

    public void OnDrawGizmos()
    {


          Gizmos.color = Color.green;
          Gizmos.DrawLine(WallCheckerR.transform.position, new Vector3(WallCheckerR.transform.position.x + distance,WallCheckerR.transform.position.y, 0f ));


          Gizmos.color = Color.green;
          Gizmos.DrawLine(WallCheckerL.transform.position, new Vector3(WallCheckerL.transform.position.x - distance,WallCheckerL.transform.position.y, 0f ));


    }
}