using UnityEngine;

public class Map : MonoBehaviour
{
    [SerializeField]
    private MapObj map;
    public enum MapObj
    {
        Map1,
        Map2,
        Map3
    }

    public MapObj GetMapObj()
    {
        return map;
    }

    void Awake()
    {
        if (Player.obtainedMaps.Contains(GetMapObj()))
        {
            gameObject.SetActive(false);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Player.obtainedMaps.Add(GetMapObj());
            gameObject.SetActive(false);
        }
    }
}