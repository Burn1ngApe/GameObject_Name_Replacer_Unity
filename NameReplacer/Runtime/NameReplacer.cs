using System.Collections.Generic;
using UnityEngine;

public class NameReplacer : MonoBehaviour
{
    public List<GameObject> ObjectsToChangeNames = new List<GameObject>();
    public string OldName, NewName;


    public void ReplaceNames()
    {
        foreach(var obj in ObjectsToChangeNames)
        {
            if(obj.name.Contains(OldName)) obj.name = obj.name.Replace(OldName, NewName);
        }
    }


    public void ClearObjetcs()
    {
        ObjectsToChangeNames.Clear();
    }
}
