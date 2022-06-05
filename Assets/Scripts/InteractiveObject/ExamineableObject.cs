using UnityEngine;
using UnityEngine.UI;

public class ExamineableObject : InteractiveObject
{
    public enum ObjectTypes
    {
        FIGURA,
        COMMON
    }

    private ItemDictionary items = new ItemDictionary();


    public ObjectTypes objectTypes;
    [TextArea(5, 100)]
    public string dialogText;
    public string audioName;
    public Sprite photoSprite;
    public bool isUIShown = false;

    //
    protected ObjectState _currentState; // reference to the active state
    //isntantiate a new state below
    public AktifState aktifState = new AktifState();
    public NonAktifState nonAktifState = new NonAktifState();

    public void SetState(ObjectState state)
    {
        _currentState = state;
        _currentState.EnterState(this);
    }
    public void SwitchState(ObjectState state)
    {
        _currentState = state;
        state.EnterState(this);
    }

    private void Start()
    {
        NetralColor();
        SetState(nonAktifState); // set state
    }

    void Update()
    {
        _currentState.UpdateState(this);

        if (Input.GetKeyDown(KeyCode.E) && playerInRange && Player.gameState == Player.GameState.GAMEPLAY && Player.currentState != Player.PlayerState.JUMPING
            ) 
        {

            //_currentState.UpdateState(this);
            if (this.TryGetComponent(out KeyObject key))
            {
                items.addToDict(key.GetKeyType().ToString(), this.photoSprite);
            }

            if (objectTypes == ObjectTypes.FIGURA)
            {
                GameObject fotoUI = PopUpUIManager.Instance.ActivateUI(photoSprite);
                fotoUI.transform.GetChild(0).GetComponent<Button>().onClick.AddListener(() => DialogManager.Instance.ShowDialogUI(dialogText));
                isUIShown = true;
                //Disini Audio untuk figura.
                AudioManager.instance.PlaySFX(audioName);
            }
            else
            {
                DialogManager.Instance.ShowDialogUI(dialogText);
            }

            //if (gameObject.name == "Lemari2")
            //{
            //    _state = ObjectState.Close;

            //    if(CekCounter == 3)
            //    {
            //        _state = ObjectState.Open;
            //    }
            //}

            //if (gameObject.name == "Botol2" && _currentState == nonAktifState)
            //{
                
            //    CekCounter++;
            //    Debug.Log(CekCounter);

            //    if(gameObject.name == "Lemari2" && CekCounter != 2)
            //    {
            //        SetState(aktifState);
            //    } 

            //}
            //if (gameObject.name == "Lemari2")
            //{
            //    _state = ObjectState.Open;

            //    if (CekCounter <= 4)
            //    {
            //        _state = ObjectState.Close;
            //    }
            //}

        }


    }


}
