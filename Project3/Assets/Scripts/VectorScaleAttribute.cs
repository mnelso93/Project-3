using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class VectorScaleAttribute : PropertyAttribute 
{
	public VectorScaleAttribute(float scaleMin, float scaleMax)
	{
	}
}

[CustomPropertyDrawer(typeof(VectorScaleAttribute))]
public class VectorScaleDrawer : PropertyDrawer
{
	public float currentValueX = 1;
	public float currentValueY = 1;
	public float currentValueZ = 1;

	public override void OnGUI (Rect position, SerializedProperty property, GUIContent label)
	{
		float height = 18;
		DrawVectorScale (height, position);
		//base.OnGUI (position, property, label);
	}

	public override float GetPropertyHeight (SerializedProperty property, GUIContent label)
	{
		return base.GetPropertyHeight (property, label) * 3;
	}

	public void DrawVectorScale (float height, Rect position)
	{
		currentValueX = EditorGUI.Slider(position, "X scale", currentValueX, .1f, 5f);
		position.y += height;
		currentValueY = EditorGUI.Slider(position, "Y scale", currentValueY, .1f, 5f);
		position.y += height;
		currentValueZ = EditorGUI.Slider(position, "Z scale", currentValueZ, .1f, 5f);
	}
}