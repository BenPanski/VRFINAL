using UnityEngine;

public class Rock : MonoBehaviour
{
    public bool collided;
    public bool StartDeathCount;

    [SerializeField] public float RespawnDelay;
    float timer = 0;


    private void Update()
    {
        if (collided)
        {
            timer += Time.deltaTime;
        }

        if (timer > RespawnDelay && !StartDeathCount)
        {
            SimpleSpawnRock.instance.TrySpawnRock();
            StartDeathCount = true;
        }
        if (StartDeathCount && timer >RespawnDelay*5)
        {
            gameObject.SetActive(false);
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("floor"))
        {
            collided = true;
        }
        if (other.CompareTag("Sack"))
        {
            SimpleSpawnRock.instance.TrySpawnRock();
            other.transform.parent.transform.Translate(Vector3.up * 2 *-1*0.5f);
            gameObject.SetActive(false);
        }
    }

   
}