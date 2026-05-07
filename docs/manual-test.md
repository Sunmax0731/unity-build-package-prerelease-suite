# 手動テスト

## 準備

- Unity 2022.3 LTS 以降または Unity 6 を使用する。
- UPM package path: `D:\AI\UnityEditor\unity-build-package-prerelease-suite\Packages`
- ローカルサーバーは不要。

## 手順

1. PowerShellで `cd D:\AI\UnityEditor\unity-build-package-prerelease-suite` を実行する。
2. `powershell -NoProfile -ExecutionPolicy Bypass -File .\tools\test-package-structure.ps1` が成功することを確認する。
3. Unity プロジェクトを開き、Package Manager から `D:\AI\UnityEditor\unity-build-package-prerelease-suite\Packages\com.sunmax0731.unity.build.package.prerelease.suite` を Add package from disk で追加する。
4. Window メニューから `Build・Package・販売前リリーススイート` を開く。
5. Scan Sample を実行し、必須項目の不足が表示されることを確認する。

## 期待結果

- パッケージがUnityへ追加できる。
- EditorWindowが開く。
- サンプルチェック結果が表示される。
