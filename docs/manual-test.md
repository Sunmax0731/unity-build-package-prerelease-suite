# 手動テスト

## 準備

- リポジトリ: `D:\AI\UnityEditor\unity-build-package-prerelease-suite`
- `npm test` が成功していること
- Unity 2022.3以降が必要です
- パッケージ: `D:\AI\UnityEditor\unity-build-package-prerelease-suite\Packages\com.sunmax0731.unity.build.package.prerelease.suite\package.json`
- ローカルサーバーは不要です

## 手順

1. Unityで任意の検証用プロジェクトを開く
2. Package ManagerのAdd package from diskから `D:\AI\UnityEditor\unity-build-package-prerelease-suite\Packages\com.sunmax0731.unity.build.package.prerelease.suite\package.json` を追加する
3. メニュー `Window/Sunmax0731/Unityビルド・パッケージ・プレリリーススイート` を開く
4. `Scan Sample` を押す
5. OK、INFO、ERRORのサンプル結果が表示されることを確認する

## 期待結果

- 必須項目不足が分かる形で表示される。
- 次アクションがユーザーに理解できる。
- 実行ログ、出力ファイル、または画面表示をリリース前確認に使える。
