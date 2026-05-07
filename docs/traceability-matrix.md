# トレーサビリティマトリクス

| ID | 要件 | 実装 | 自動テスト | ユーザーdocs | リリースdocs |
| --- | --- | --- | --- | --- | --- |
| QFR-001 | 必須項目不足を検出する | Packages/com.sunmax0731.unity.build.package.prerelease.suite/package.json<br>Packages/com.sunmax0731.unity.build.package.prerelease.suite/Editor/PrereleaseRuleEngine.cs<br>Packages/com.sunmax0731.unity.build.package.prerelease.suite/Editor/UnityBuildPackagePrereleaseSuiteWindow.cs | tools/test-package-structure.ps1<br>tools/test-representative-suite.cjs | docs/user-guide.md | docs/release-checklist.md |
| QFR-002 | 代表シナリオを継続検証する | Packages/com.sunmax0731.unity.build.package.prerelease.suite/Samples~/representative-suite.json | tools/test-representative-suite.cjs | docs/manual-test.md | docs/qcds-evaluation.md |
| CFR-001 | ローカルで低コストに検証する | package.json | npm test | docs/installation-guide.md | tools/package-docs.ps1 |
| DFR-001 | リリース前判断の証跡を残す | docs/qcds-strict-metrics.json | tools/qcds-evaluate.cjs | README.md | docs/pre-release.md |
| SFR-001 | 秘密情報と外部実行リスクを抑える | docs/security-privacy-checklist.md | tools/qcds-evaluate.cjs | docs/user-guide.md | docs/release-checklist.md |
