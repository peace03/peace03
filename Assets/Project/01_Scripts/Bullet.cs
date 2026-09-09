using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void DestroySelf()
    {
        Destroy(gameObject,2f);
    }

    private void Start()
    {
        //DestroySelf();
        Invoke("DestroySelf", 2f);
    }
}
