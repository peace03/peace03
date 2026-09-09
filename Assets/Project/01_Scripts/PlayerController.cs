using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 0.05f;

    public GameObject BulletPrefab;
    public float bulletSpeed = 0.5f;

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
        //플레이어 이동
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0, speed, 0));
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(0, -speed, 0));
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(-speed, 0,0));
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(speed, 0,0));
        }

        // 플레이어 미사일 발사
        if (Input.GetKeyDown(KeyCode.Space))
        {
            for (int i = 1; i <= 3; i++)
            {
                GameObject bullet = Instantiate(BulletPrefab);
                bullet.transform.position = transform.position + Vector3.up * (0.5f * i);
                bullet.GetComponent<Rigidbody>().AddForce(Vector3.up * bulletSpeed);
            }
        }
    }
}
