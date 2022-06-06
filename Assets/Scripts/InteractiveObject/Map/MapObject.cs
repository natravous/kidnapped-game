using UnityEngine;

public class MapObject : InteractiveObject
{
    [SerializeField]
    private Map.MapObj mapType;

    public Map.MapObj GetMapObj()
    {
        return mapType;
    }

    void Awake()
    {
        if (Player.obtainedMaps.Contains(GetMapObj()))
        {
            GetComponent<ExamineableObject>().enabled = false;
            GetComponent<Collider2D>().enabled = false;
            this.enabled = false;
            //gameObject.SetActive(false);
        }
    }

    private void Update()
    {
        if (Player.obtainedMaps.Contains(GetMapObj()) && GetComponent<ExamineableObject>().isUIShown)
        {
            //gameObject.SetActive(false);
            GetComponent<ExamineableObject>().enabled = false;
            GetComponent<Collider2D>().enabled = false;
            this.enabled = false;
        }
        if (Input.GetKeyDown(KeyCode.E) && playerInRange && Player.currentState != Player.PlayerState.JUMPING)
        {
            if (GetComponent<ExamineableObject>().enabled)
            {
                AudioManager.instance.PlaySFX("");
                Player.obtainedMaps.Add(GetMapObj());
            }
        }
    }
}
