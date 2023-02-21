using UnityEngine;

public class Rock : MonoBehaviour
{
    public bool collided;
    float timer = 0;


    private void Update()
    {
        if (collided)
        {
            timer += Time.deltaTime;
        }

        if (timer > 3)
        {
            SimpleSpawnRock.instance.TrySpawnRock();
            gameObject.SetActive(false);
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("floor"))
        {
            collided = true;
        }
    }
}