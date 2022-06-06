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

    //// Item dictionary
    //static private Dictionary<Key.typeKey, Sprite> keyItems = new Dictionary<Key.typeKey, Sprite>();
    //static private Dictionary<string, Sprite> spriteItems = new Dictionary<string, Sprite>();

    //public Sprite GetSprite(Key.typeKey key)
    //{
    //    return keyItems[key];
    //}
    //public Sprite GetSprite(string key)
    //{
    //    return spriteItems[key];
    //}
    //public void Add(Key.typeKey key, Sprite spr)
    //{
    //    if (keyItems.ContainsKey(key))
    //    {
    //        return;
    //    }
    //    keyItems.Add(key, spr);
    //}
    //public void Add(string key, Sprite spr)
    //{
    //    if (spriteItems.ContainsKey(key))
    //    {
    //        return;
    //    }
    //    spriteItems.Add(key, spr);
    //}
}
