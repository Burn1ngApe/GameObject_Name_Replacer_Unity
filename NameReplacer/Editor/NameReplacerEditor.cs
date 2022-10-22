using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(NameReplacer))]
public class NameReplacerEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        GUILayout.Space(10);
        GUILayout.BeginHorizontal();

        if(GUILayout.Button("Change Names"))
        {
            var replacer = (NameReplacer)target;

            replacer.ReplaceNames();
        }

        GUILayout.EndHorizontal();
        GUILayout.Space(10);
        GUILayout.BeginHorizontal();

        GUI.backgroundColor = Color.red;
        if (GUILayout.Button("Clear Objects"))
        {
            var replacer = (NameReplacer)target;

            replacer.ReplaceNames();
        }

        GUILayout.EndHorizontal();
    }
}
