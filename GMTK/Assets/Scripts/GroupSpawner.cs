using UnityEngine;

public class GroupSpawner : MonoBehaviour
{
    [SerializeField] private float goldenAngle;

    [SerializeField] private float radius;


    private int currentCount = 0;
    private float currentAngle = 0;
    private float currentRadius = 0;


    private void Update()
    {
        UpdateWhenNeeded();
    }

    void UpdateWhenNeeded()
    {
        if (currentCount != transform.childCount || 
            currentAngle != goldenAngle          ||
            currentRadius != radius)
        {
            PlaceNano();
        }
    }

    private void PlaceNano()
    {
        Debug.Log("update");
        for (int i = 0; i < transform.childCount; i++)
        {
            Vector3 pos = GetLocalPosition(i);
            transform.GetChild(i).localPosition = pos;
        }

        currentCount = transform.childCount;
        currentAngle = goldenAngle;
        currentRadius = radius;
    }

    Vector3 GetLocalPosition(int nanoIndex)
    {
        float x = radius * Mathf.Sqrt(nanoIndex) * Mathf.Cos(Mathf.Deg2Rad * nanoIndex * goldenAngle);
        float z = radius * Mathf.Sqrt(nanoIndex) * Mathf.Sin(Mathf.Deg2Rad * nanoIndex * goldenAngle);

        return new Vector3(x, 0, z);
    }

}
