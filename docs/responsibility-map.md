# 責務マップ

| 領域 | 責務 | ファイル |
| --- | --- | --- |
| 入力正規化 | 入力を配列として扱える形にする | src/input.mjs |
| 検証 | 必須項目と状態を判定する | src/validators.mjs |
| 表示モデル | ステータス、カード、次アクションを組み立てる | src/review-model.mjs |
| レポート/UI | 利用者に結果を表示する | Packages/com.sunmax0731.unity.build.package.prerelease.suite/package.json、Packages/com.sunmax0731.unity.build.package.prerelease.suite/Editor/PrereleaseRuleEngine.cs、Packages/com.sunmax0731.unity.build.package.prerelease.suite/Editor/UnityBuildPackagePrereleaseSuiteWindow.cs、tools/test-package-structure.ps1 |
| 評価 | QCDSと文字化けを検証する | tools/qcds-evaluate.cjs |
