(function () {
	const almColorClass = 'alm-color';
	const orangeMountains = 'assets/mountains-image-orange.svg';
	const defaultMountains = 'assets/mountains-image.svg';
	const orangeLogo = 'assets/logo-image-orange.svg';
	const defaultLogo = 'assets/logo-image.svg';
	const onHideLoadingAnimation = () => {
		window.removeEventListener('hide_loading_animation', onHideLoadingAnimation);
		document.querySelector('#logo-image-container').remove();
		const loadingAnimation = document.querySelector('#loading-animation');
		loadingAnimation.style.animation = 'hide-opacity-animation 1s normal';
		loadingAnimation.style.opacity = 0;
		setTimeout(() => {
			loadingAnimation.remove();
			document.body.style.overflow = '';
		}, 1000);
	};

	const getQueryParams = (url) => {
		const queryIndex = url.lastIndexOf('?');
		const obj = {};
		if (queryIndex < 0) {
			return obj;
		}
		const params = url.substring(queryIndex + 1);
		params.split('&').forEach((q) => {
			const items = q.split('=');
			obj[items[0]] = items[1];
		});
		return obj;
	};

	const loadBackgroundLoader = () => {
		const loadingAnimation = document.getElementById('loading-animation');
		const logoImage = document.getElementById('logo-image');
		const imgMountains = document.getElementById('mountains-image');
		const trolleyBackgrounds = document.querySelectorAll('.trolley-background');
		const params = getQueryParams(location.search);
		switch (params.bgLoader) {
			case 'orange':
				logoImage.src = orangeLogo;
				imgMountains.src = orangeMountains;
				loadingAnimation.classList.add(almColorClass);
				for (const element of trolleyBackgrounds) {
					element.classList.add(almColorClass);
				}
				break;
			default:
				logoImage.src = defaultLogo;
				imgMountains.src = defaultMountains;
				loadingAnimation.classList.remove(almColorClass);
				for (const element of trolleyBackgrounds) {
					element.classList.remove(almColorClass);
				}
				break;
		}
	};

	window.addEventListener(
		'load',
		() => {
			document.body.style.overflow = 'hidden';
			window.addEventListener('hide_loading_animation', onHideLoadingAnimation, false);
		},
		false,
	);

	document.addEventListener('DOMContentLoaded', loadBackgroundLoader);
})();
