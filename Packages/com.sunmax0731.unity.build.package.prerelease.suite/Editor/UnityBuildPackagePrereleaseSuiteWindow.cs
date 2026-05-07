using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Sunmax0731.UnityBuildPackagePrereleaseSuite
{
    public sealed class UnityBuildPackagePrereleaseSuiteWindow : EditorWindow
    {
        private Vector2 scroll;
        private readonly List<string> findings = new List<string>();

        [MenuItem("Window/Sunmax0731/Unityビルド・パッケージ・プレリリーススイート")]
        public static void Open()
        {
            GetWindow<UnityBuildPackagePrereleaseSuiteWindow>("Unityビルド・パッケージ・プレリリーススイート");
        }

        private void OnGUI()
        {
            EditorGUILayout.LabelField("Unityビルド・パッケージ・プレリリーススイート", EditorStyles.boldLabel);
            EditorGUILayout.HelpBox("Unityパッケージの構造、ビルド対象、販売前チェック、手動検証準備をまとめる。", MessageType.Info);
            using (new EditorGUILayout.HorizontalScope())
            {
                DrawCard("対象", "Package");
                DrawCard("状態", findings.Count == 0 ? "未検証" : "確認済み");
                DrawCard("次", "Manual Test");
            }
            if (GUILayout.Button("Scan Sample"))
            {
                findings.Clear();
                findings.AddRange(PrereleaseRuleEngine.EvaluateSample());
            }
            scroll = EditorGUILayout.BeginScrollView(scroll);
            foreach (var finding in findings)
            {
                var type = finding.StartsWith("ERROR") ? MessageType.Error : finding.StartsWith("INFO") ? MessageType.Info : MessageType.None;
                EditorGUILayout.HelpBox(finding, type);
            }
            EditorGUILayout.EndScrollView();
        }

        private static void DrawCard(string label, string value)
        {
            using (new EditorGUILayout.VerticalScope(EditorStyles.helpBox, GUILayout.MinWidth(100)))
            {
                EditorGUILayout.LabelField(label, EditorStyles.miniLabel);
                EditorGUILayout.LabelField(value, EditorStyles.boldLabel);
            }
        }
    }
}
