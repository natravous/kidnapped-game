using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ItemDictionary
{
    static private Dictionary<string, Sprite> itemdict = new Dictionary<string, Sprite>();

    public Sprite getImage(string key)
    {
        return itemdict[key];
    }

    public void addToDict(string key, Sprite img)
    {
        if (this.isKey(key) == true)
        {
            return;
        }
        itemdict.Add(key, img);
    }

    public bool isKey(string key)
    {
        return itemdict.ContainsKey(key);
    }

    public int totalItems()
    {
        return itemdict.Count;
    }

    public Dictionary<string, Sprite> getDict()
    {
        return itemdict;
    }
}
