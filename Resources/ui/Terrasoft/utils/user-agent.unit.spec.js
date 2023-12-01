describe("user-agent.unit.spec.js", () => {
	let getRootTest;
	beforeAll(() => {
		getRootTest = window.getRootTest.bind(this, "user-agent.unit.spec.js");
	});
	beforeAll(done =>
		require(["user-agent"], () => done())
	);

	const testCases = [
		{
			browser: { name: 'Chrome', major: '82', },
			expected: false,
		},
		{
			browser: { name: 'Chrome', major: '84', },
			expected: true,
		},
		{
			browser: { name: 'Firefox', major: '79', },
			expected: false,
		},
		{
			browser: { name: 'Firefox', major: '80', },
			expected: true,
		},
		{
			browser: { name: 'Safari', major: '11', },
			expected: false,
		},
		{
			browser: { name: 'Safari', major: '12', },
			expected: true,
		},
		{
			browser: { name: 'Mobile Safari', major: '11', },
			expected: false,
		},
		{
			browser: { name: 'Mobile Safari', major: '12', },
			expected: true,
		},
		{
			browser: { name: 'Yandex', major: '18', },
			expected: false,
		},
		{
			browser: { name: 'Yandex', major: '19', },
			expected: true,
		},
		{
			browser: { name: 'Edge', major: '83', },
			expected: false,
		},
		{
			browser: { name: 'Edge', major: '84', },
			expected: true,
		},
		{
			browser: { name: 'WebKit', major: '603', },
			expected: false,
		},
		{
			browser: { name: 'WebKit', major: '604', },
			expected: true,
		},
		{
			browser: { name: 'Chrome WebView', major: '83', },
			expected: false,
		},
		{
			browser: { name: 'Chrome WebView', major: '84', },
			expected: true,
		},
		{
			browser: { name: '?', major: '?', },
			expected: false,
		}
	];

	testCases.forEach(testCase => {
		describe(`when browser is ${testCase.browser.name} ${testCase.browser.major}`, () => {
			beforeEach(() => {
				window.UAParser = function() {	
					this.getBrowser = () => (testCase.browser);
				}
			});

			it("should return expected value", () => {
				expect(Terrasoft.utils.UserAgent.isBrowserSupported()).toBe(testCase.expected);
			});
		});
	});
});
