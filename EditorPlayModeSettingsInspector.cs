using UnityEditor;
using UnityEngine;

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

