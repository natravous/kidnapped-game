using UnityEngine;

public class InteractiveObject : MonoBehaviour
{
    // public string promptText;
    // public PromptManager promptManager;

    //
    //public enum ObjectState //
    //{
    //    Open,
    //    Close,
    //}

    //public ObjectState _state;

   

    private int cekCunter; //

    public int CekCounter //
    {
        get
        {
            return cekCunter;
        }
        set
        {
            cekCunter = value;
        }
    }

    protected bool playerInRange = false;
    public bool PlayerInRange
    {
        get { return playerInRange; }
        set { playerInRange = value; }
    }
    protected GameObject player;
    protected SpriteRenderer objImg;
    protected Color oriColor;
    protected Color enterColor;
    // Start is called before the first frame update

    //
    //
    
    void Start()
    {
        NetralColor();
        //StartFunExtension();
        //objImg = GetComponent<SpriteRenderer>();
        //oriColor = objImg.color;
        //enterColor = new Color(0.5f, 0.5f, 0.5f, oriColor.a);
        //playerInRange = false;
        // promptManager = FindObjectOfType<PromptManager>();

        //masukState = GetComponent<FSMAction>();  //
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            player = other.gameObject;
            PlayerEnterFeedback();
            if (objImg != null)
            {
                objImg.color = enterColor;
            }

            // promptManager.ShowPromtBetter(promptText, gameObject.transform.position);
            playerInRange = (Player.gameState == Player.GameState.GAMEPLAY) ? true : false;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            if (objImg != null)
            {
                objImg.color = oriColor;
            }

            playerInRange = false;
            PlayerExitFeedback();
            // promptManager.HidePrompt();
        }
    }

    public void NetralColor()
    {
        StartFunExtension();
        objImg = GetComponent<SpriteRenderer>();
        oriColor = objImg.color;
        enterColor = new Color(0.5f, 0.5f, 0.5f, oriColor.a);
        playerInRange = false;
    }

    public virtual void PlayerEnterFeedback()
    {

    }

    public virtual void PlayerExitFeedback()
    {

    }

    public virtual void StartFunExtension()
    {

    }

    //public virtual bool ChangePosition() //
    //{
    //    _state = ObjectState.Close; //
    //    return true;
    //}

}
