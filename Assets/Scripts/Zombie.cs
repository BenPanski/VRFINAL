using UnityEngine;

public class Zombie : MonoBehaviour
{
    [HideInInspector] public GameManager gameManager;
    [SerializeField] int speed = 2;
    [SerializeField] int damage = 2;
    private void OnTriggerEnter(Collider other)
    {
        print("trigger");

        if (other.gameObject.CompareTag("Rock"))
        {
            other.gameObject.GetComponent<Rock>().collided = true;
            Destroy(gameObject);
        }
        else if (other.gameObject.CompareTag("GameManager"))
        {
            print("GameManager");
            other.gameObject.GetComponent<GameManager>().TakeDamage(damage);
            Destroy(gameObject);
        }

    }
    //private void Start()
    //{
    //    transform.LookAt(gameManager.transform);
    //}

    private void Update()
    {
        transform.LookAt(gameManager.transform);
        transform.position += transform.forward * Time.deltaTime * speed;
        
    }
}