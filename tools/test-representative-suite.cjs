const assert = require('node:assert/strict');
const fs = require('node:fs');
const path = require('node:path');

const root = path.resolve(__dirname, '..');
const suite = JSON.parse(fs.readFileSync(path.join(root, 'Packages/com.sunmax0731.unity.build.package.prerelease.suite/Samples~/representative-suite.json'), 'utf8'));
assert.equal(suite.product, 'unity-build-package-prerelease-suite');
assert.ok(suite.scenarios.length >= 4);
assert.ok(suite.scenarios.some((scenario) => scenario.expected.result === 'failed'));
assert.ok(suite.scenarios.some((scenario) => scenario.expected.result === 'warning'));
const engine = fs.readFileSync(path.join(root, 'Packages', 'com.sunmax0731.unity.build.package.prerelease.suite', 'Editor', 'PrereleaseRuleEngine.cs'), 'utf8');
assert.match(engine, /ERROR:/);
assert.match(engine, /INFO:/);
console.log('Representative suite OK: unity-build-package-prerelease-suite');
