using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Sunmax0731.UnityBuildPackagePrereleaseSuite
{
    public sealed class UnityBuildPackagePrereleaseSuiteWindow : EditorWindow
    {
        private Vector2 scroll;
        private readonly List<string> findings = new List<string>();

        [MenuItem("Window/Sunmax0731/Build・Package・販売前リリーススイート")]
        public static void Open()
        {
            GetWindow<UnityBuildPackagePrereleaseSuiteWindow>("Build・Package・販売前リリーススイート");
        }

        private void OnGUI()
        {
            EditorGUILayout.LabelField("Build・Package・販売前リリーススイート", EditorStyles.boldLabel);
            EditorGUILayout.HelpBox("Unityパッケージのビルド、パッケージ構造、販売前チェック、手動検証準備をまとめる。", MessageType.Info);
            if (GUILayout.Button("Scan Sample"))
            {
                findings.Clear();
                findings.AddRange(PrereleaseRuleEngine.EvaluateSample());
            }
            scroll = EditorGUILayout.BeginScrollView(scroll);
            foreach (var finding in findings)
            {
                EditorGUILayout.HelpBox(finding, finding.Contains("ERROR") ? MessageType.Error : MessageType.Info);
            }
            EditorGUILayout.EndScrollView();
        }
    }
}
