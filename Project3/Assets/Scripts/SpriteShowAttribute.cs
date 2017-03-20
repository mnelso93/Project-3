using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class SpriteShowAttribute : PropertyAttribute 
{
	public SpriteShowAttribute(int pixelWidth, int pixelHeight)
	{
		
	}
}

[CustomPropertyDrawer(typeof(SpriteShowAttribute))]
public class SpriteShowDrawer : PropertyDrawer
{
	public override float GetPropertyHeight (SerializedProperty property, GUIContent label)
	{
		return base.GetPropertyHeight (property, label)*2;
	}

	public override void OnGUI (Rect position, SerializedProperty property, GUIContent label)
	{
		int height = 18;
		DrawSpriteShow (property, position);
	}

	public void DrawSpriteShow(SerializedProperty property, Rect position)
	{
		EditorGUI.ObjectField (position, property);
	}
}
