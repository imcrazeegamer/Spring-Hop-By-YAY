using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class ButtonPushing : MonoBehaviour
{
    public enum Scence { Main, Stat, Power, Hat, Inventory }

    [SerializeField]
    private List<Canvas> list;

    private Dictionary<Scence, Canvas> Scenes = new Dictionary<Scence, Canvas>(); 
    
    private void Awake()
    {
        foreach(Canvas c in list)
        {
            foreach(Scence s in EnumUtil.GetValues<Scence>())
            {
                if(c.name == s.ToString())
                {
                    Scenes[s] = c;
                }
            }
        }
        ChangeArtaficalScence(Scence.Main.ToString());
    }

    public void ChangeArtaficalScence(string s)
    {
        //entry.Key = Scence Enum Value, entry.Value = Canvas that matches the key;
        foreach (KeyValuePair<Scence, Canvas> entry in Scenes)
        {
            
            entry.Value.gameObject.SetActive(entry.Key.ToString() == s);
            SetActiveAllChildren(entry.Value.gameObject.transform, entry.Key.ToString() == s);
        }
    }
    
    public static class EnumUtil
    {
        public static IEnumerable<T> GetValues<T>()
        {
            return Enum.GetValues(typeof(T)).Cast<T>();
        }
    }

    private void SetActiveAllChildren(Transform transform, bool value)
    {
        foreach (Transform child in transform)
        {
            child.gameObject.SetActive(value);

            SetActiveAllChildren(child, value);
        }
    }
}
