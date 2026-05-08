using UnityEditor;
using UnityEngine;

namespace Sunmax0731.UnityBuildPackagePrereleaseSuite
{
    public sealed class UnityBuildPackagePrereleaseSuiteWindow : EditorWindow
    {
        [MenuItem("Tools/Sunmax0731/unity-build-package-prerelease-suite")]
        public static void Open() => GetWindow<UnityBuildPackagePrereleaseSuiteWindow>("unity-build-package-prerelease-suite");

        private void OnGUI()
        {
            GUILayout.Label("Build・Package・販売前リリーススイート", EditorStyles.boldLabel);
            GUILayout.Label("Closed alpha editor package is importable.");
        }
    }
}
