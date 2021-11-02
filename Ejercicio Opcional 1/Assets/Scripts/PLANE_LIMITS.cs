using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLANE_LIMITS : MonoBehaviour
{
    private float limXPos = 50.0f;
    private float limXNeg = -50.0f;
    private float limZPos = 25.0f;
    private float limZNeg = -25.0f;
    private float positionY = 0.5f;
    private float speed = 20f;


    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, positionY, 0);

    }

    // Update is called once per frame
    void Update()
    {
      MoveGameObject(Vector3.right * Time.deltaTime * speed, KeyCode.RightArrow);
      MoveGameObject(Vector3.left * Time.deltaTime * speed, KeyCode.LeftArrow);
      MoveGameObject(Vector3.forward * Time.deltaTime * speed, KeyCode.UpArrow);
      MoveGameObject(Vector3.back * Time.deltaTime * speed, KeyCode.DownArrow);

        if (transform.position.x >= limXPos)
        {
            transform.position = new Vector3(limXPos, transform.position.y, transform.position.z);
        }

        if (transform.position.x <= limXNeg)
        {
            transform.position = new Vector3(limXNeg, transform.position.y, transform.position.z);
        }

        if (transform.position.z >= limZPos)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, limZPos);
        }

        if (transform.position.z <= limZNeg)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, limZNeg);
        }
    }

    public void MoveGameObject(Vector3 direction, KeyCode keyCode)
    {
        if (Input.GetKey(keyCode))
        {
            transform.Translate(direction);
        }



    }
}
