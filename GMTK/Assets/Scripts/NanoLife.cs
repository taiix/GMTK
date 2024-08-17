using UnityEngine;

public class NanoLife : MonoBehaviour
{
    [SerializeField] private float lifeTimeInSeconds;

    private void Start()
    {
        lifeTimeInSeconds = Random.Range(120, 180);
    }

    private void Update()
    {
        lifeTimeInSeconds -= Time.deltaTime;

        if(lifeTimeInSeconds <= 0)
            Destroy(gameObject);
    }
}
