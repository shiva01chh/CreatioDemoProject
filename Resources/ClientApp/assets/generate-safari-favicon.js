(() => {
	const isSafari =
		/constructor/i.test(window.HTMLElement) ||
		(function (p) {
			return p.toString() === '[object SafariRemoteNotification]';
		})(!window['safari'] || (typeof safari !== 'undefined' && window['safari'].pushNotification));
	// TODO RND-37115
	if (isSafari) {
		const linkElement = document.createElement('link');
		linkElement.setAttribute('rel', 'icon');
		linkElement.setAttribute('type', 'image/x-icon');
		linkElement.setAttribute('href', 'favicon-orange.ico');
		document.head.appendChild(linkElement);
	}
})();
