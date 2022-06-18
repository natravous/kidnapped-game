using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ItemDictionary
{

    // Item dictionary
    static private Dictionary<Key.typeKey, Sprite> keyItems = new Dictionary<Key.typeKey, Sprite>();
    static private Dictionary<Map.MapObj, Sprite> mapItems = new Dictionary<Map.MapObj, Sprite>();

    public List<Key.typeKey> GetKeys()
    // Get List of Keys that already stored by player
    {
        return keyItems.Keys.ToList();
    }
    public List<Map.MapObj> GetMaps()
    // Get List of Maps that already stored by player
    {
        return mapItems.Keys.ToList();
    }
    public Sprite GetSprite(Key.typeKey key)
    // Get sprite object from the key
    {
        return keyItems[key];
    }
    public Sprite GetSprite(Map.MapObj map)
    // Get sprite object from the map
    {
        return mapItems[map];
    }
    public bool Contains(Key.typeKey key)
    {
        return keyItems.ContainsKey(key);
    }
    public bool Contains(Map.MapObj map)
    {
        return mapItems.ContainsKey(map);
    }
    public void Add(Key.typeKey key, Sprite sprite)
    {
        if (this.Contains(key))
        {
            return;
        }
        keyItems.Add(key, sprite);
    }
    public void Add(Map.MapObj map, Sprite sprite)
    {
        if (this.Contains(map))
        {
            return;
        }
        mapItems.Add(map, sprite);

    }

    }
