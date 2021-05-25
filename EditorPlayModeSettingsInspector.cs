using UnityEditor;
using UnityEngine;

// Note: This file MUST be placed in an Editor folder.
// See: https://docs.unity3d.com/Manual/SpecialFolders.html
[CustomEditor(typeof(EditorPlayModeSettings))]
public class EditorPlayModeSettingsInspector : Editor {

    EditorPlayModeSettings ThisEPMS;

    void OnEnable() {

        ThisEPMS = (EditorPlayModeSettings)target;
    }

    public override void OnInspectorGUI() {

        DrawDefaultInspector();
        if (GUILayout.Button("Update Play Mode Settings")) {
            ThisEPMS.UpdatePlayModeSettings();
        }
    }
}

