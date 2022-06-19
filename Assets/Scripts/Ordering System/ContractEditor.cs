using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Furniture.Ordering
{
    [CustomEditor(typeof(Contract))]
    public class ContractEditor : Editor
    {
        private string message = "";
        public override void OnInspectorGUI()
        {
            var script = (Contract)target;

            GUILayout.Label($"Message: {message}");

            if (GUILayout.Button("Apply Changes to File", GUILayout.Height(20)))
            {
                script.SaveObjectives();
                message = $"Last Save {System.DateTime.Now}";
            }

            base.OnInspectorGUI();
        }
    }
}