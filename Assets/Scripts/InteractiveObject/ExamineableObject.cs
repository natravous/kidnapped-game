using UnityEngine;
using UnityEngine.UI;

public class ExamineableObject : InteractiveObject
{
    ObjectState objState; //

   

    public enum ObjectTypes
    {
        FIGURA,
        COMMON
    }

    public ObjectTypes objectTypes;
    [TextArea(5, 100)]
    public string dialogText;
    public string audioName;
    public Sprite photoSprite;
    public bool isUIShown = false;

    

    void Update()
    {
        objState = ObjectState.Close; //
        if (Input.GetKeyDown(KeyCode.E) && playerInRange && Player.gameState == Player.GameState.GAMEPLAY && Player.currentState != Player.PlayerState.JUMPING)
        {
            objState = ObjectState.Open; //
            Debug.Log("Cek " + objState);
            CekCounter += 1;
            Debug.Log("cek counter " + CekCounter);

            if(CekCounter >= 2 && objState == ObjectState.Open) //
            {
                Debug.Log("Cek null " + objState + ", Cek counter " + CekCounter);
                
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
        }
    }


}
