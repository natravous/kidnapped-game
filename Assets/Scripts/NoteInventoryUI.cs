using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text.RegularExpressions;

public class NoteInventoryUI : MonoBehaviour
{
    public GameObject noteItem;
    public GameObject noteItemParent;
    public GameObject noteDetails;

    public GameObject pocketItem;
    public GameObject pocketItemParent;
    private ItemDictionary items = new ItemDictionary();

  
    private List<string> generatedNote = new List<string>();
    //
    private List<Key.typeKey> generatedKey = new List<Key.typeKey>();

    private List<Map.MapObj> generatedMap = new List<Map.MapObj>();

    [SerializeField]
    private Color originalColor;
    [SerializeField]
    private Color selectedColor;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnEnable()
    {
        foreach (KeyValuePair<string, string> note in Player.obtainedNotes)
        {
            if (!generatedNote.Contains(note.Key))
            {
                GameObject obj = Instantiate(noteItem, Vector3.zero, Quaternion.identity, noteItemParent.transform);
                obj.transform.GetChild(0).gameObject.GetComponent<Text>().text = note.Key;
                obj.transform.GetChild(1).GetComponent<Button>().onClick.AddListener(() =>
                {
                    ResetColor();
                    ClickColor(obj);
                    ShowDetail(note.Key);
                });
                generatedNote.Add(note.Key);
            }

        }
        // GetComponentInChildren<Text>().text = title;
        
        //
        foreach (Key.typeKey kunci in Player.obtainedKeys) //
        {
            if (!generatedKey.Contains(kunci))
            {
                GameObject obj = Instantiate(pocketItem, Vector3.zero, Quaternion.identity, pocketItemParent.transform);
                Sprite objSprite = items.GetSprite(kunci);
                obj.transform.gameObject.GetComponent<Button>().onClick.AddListener(() => 
                {
                    PopUpUIManager.Instance.ActivateUI(objSprite);
                    
                });
                obj.transform.GetChild(0).gameObject.GetComponent<Text>().text = Space(kunci.ToString());
                float oriRect = obj.transform.GetChild(1).gameObject.GetComponent<Image>().rectTransform.rect.width;
                obj.transform.GetChild(1).gameObject.GetComponent<Image>().sprite = objSprite;
                generatedKey.Add(kunci);
            }
            
            Debug.Log("Kunci yang sudah diambil: " + kunci.ToString()); //
        } 

        // Generate Maps
        foreach (Map.MapObj map in Player.obtainedMaps)
        {
            if (!generatedMap.Contains(map))
            {
                GameObject obj = Instantiate(pocketItem, Vector3.zero, Quaternion.identity, pocketItemParent.transform);
                obj.transform.gameObject.GetComponent<Button>().onClick.AddListener(() =>
                {
                    PopUpUIManager.Instance.ActivateUI(items.GetSprite(map));
                });
                obj.transform.GetChild(0).gameObject.GetComponent<Text>().text = Space(map.ToString());
                obj.transform.GetChild(1).gameObject.GetComponent<Image>().sprite = items.GetSprite(map);
                generatedMap.Add(map);
            }
        }

    }

    //public void ShowImage(GameObject obj)
    //{
    //    Debug.Log(obj.transform.GetChild(1).gameObject.GetComponent<Image>().sprite);
    //    GameObject fotoUI = PopUpUIManager.Instance.ActivateUI(obj.transform.GetChild(1).gameObject.GetComponent<Image>().sprite);
    //}

    private string Space(string text)
    {
        string returner = Regex.Replace(text, "([a-z])([A-Z])", "$1 $2");
        return returner;
    }

    private void ClickColor(GameObject obj)
    {
        obj.GetComponent<Image>().color = selectedColor;
        obj.transform.GetChild(0).GetComponent<Text>().color = originalColor;
    }
    private void ResetColor()
    {
        for (int i = 0; i < noteItemParent.transform.childCount; i++)
        {
            GameObject obj = noteItemParent.transform.GetChild(i).gameObject;
            if (obj.GetComponent<Image>().color.r == selectedColor.r)
            {
                obj.GetComponent<Image>().color = originalColor;
                obj.transform.GetChild(0).GetComponent<Text>().color = selectedColor;

            }

        }
    }
    private void ShowDetail(string title)
    {
        noteDetails.transform.GetChild(0).GetComponent<Text>().text = title;
        noteDetails.transform.GetChild(1).GetComponent<Text>().text = Player.obtainedNotes[title];
    }
}
