using UnityEditor;
using UnityEngine;
using UnityEditorInternal;

[CustomPropertyDrawer(typeof(TagSelectorAttribute))]
public class TagSelectorDrawer : PropertyDrawer
{
   
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        int index = 0;
        string[] options = InternalEditorUtility.tags;

        index = System.Array.IndexOf(options, property.stringValue);
        
        index = EditorGUI.Popup(position, index, options);

        if (index >= 0)
        {
            property.stringValue = options[index];
        }
    }
}