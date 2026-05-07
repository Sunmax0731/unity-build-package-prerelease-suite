$ErrorActionPreference = "Stop"
$root = Split-Path -Parent $PSScriptRoot
$packageRoot = Join-Path $root "Packages\com.sunmax0731.unity.build.package.prerelease.suite"
$required = @(
  "package.json",
  "Editor\UnityBuildPackagePrereleaseSuiteWindow.cs",
  "Editor\PrereleaseRuleEngine.cs",
  "Editor\UnityBuildPackagePrereleaseSuite.asmdef",
  "Samples~\sample-checklist.json",
  "docs\manual-test.md",
  "docs\requirements.md"
)
foreach ($relative in $required) {
  $path = Join-Path $packageRoot $relative
  if ($relative -like "docs\*") { $path = Join-Path $root $relative }
  if (!(Test-Path $path)) { throw "Missing required file: $relative" }
}
$pkg = Get-Content (Join-Path $packageRoot "package.json") -Encoding UTF8 -Raw | ConvertFrom-Json
if ($pkg.name -ne "com.sunmax0731.unity.build.package.prerelease.suite") { throw "Unexpected package name: $($pkg.name)" }
Write-Output "Package structure OK: com.sunmax0731.unity.build.package.prerelease.suite"
