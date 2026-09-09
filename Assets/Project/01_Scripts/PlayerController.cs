using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Vector3 newPos = transform.position;
        //vector3 newpos = this.gameobject.getcomponent<transform>().position;
        //newpos.x += 5;
        //transform.position = newpos;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0, 0.05f, 0));
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(0, -0.05f, 0));
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(-0.05f, 0,0));
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(0.05f, 0,0));
        }
    }
}
