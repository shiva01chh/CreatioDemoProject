const minAmountOfButtons = 5;
const buttonsSpacing = 8;
const firstButtonWidth = 90;
const hideClass = 'item-hide';
let CKEditorCurrentInstanceName;
const editorToolbars = [];
const toolbarElements = [];

CKEDITOR.plugins.add('expandcollapse',
{
	lang: 'en,ru',
	init: function (editor) {
		const lang = editor.lang.expandcollapse;
		editor.ui.addButton('Expand',
			{
				label: lang.expand,
				command: 'Expand',
				icon: CKEDITOR.plugins.getPath('expandcollapse') + 'expand.svg',
			});
		editor.addCommand('Expand', { exec: expandToolbar });

		editor.ui.addButton('Collapse',
			{
				label: lang.collapse,
				command: 'Collapse',
				icon: CKEDITOR.plugins.getPath('expandcollapse') + 'collapse.svg'
			});
		editor.addCommand('Collapse', { exec: collapseToolbar });

		editor.on('focus', () => initToolbar());
		editor.on('toggleToolbar', (e) => onToggleToolbar(e.data.display));
	}
});

function onToggleToolbar(display) {
	if(display) {
		toggleToolbar();
	} else {
		expandToolbar(false);
	}
}

function initToolbar() {
	CKEditorCurrentInstanceName = CKEDITOR.currentInstance.name;
	setEventsToButtons();
}

function toggleToolbar() {
	expandToolbar(false);
	collapseToolbar(false);
}

function setEventsToButtons () {
	getToolbarItems().forEach(item => {
		item.onfocus = (event) => {
			if(event.target.style.position === 'absolute') {
				if(event.currentTarget.id > event.relatedTarget.id) {
					getLastVisibleButton(event.relatedTarget.id).focus();
				} else {
					getPreviousVisibleButton().focus();
				}
			}
		}
	});
}

function collapseToolbar(refresh = true) {
	const items = getToolbarItems();
	if(items) {
		let collapseStartIndex = getCollapseIndex(items[1]);
		collapseStartIndex = correctCollapseIndex(collapseStartIndex, items.length);
		const itemsToCollapse = items.slice(collapseStartIndex);
		hideSeparator(items, itemsToCollapse, collapseStartIndex);
		toggleItems(itemsToCollapse, true);
		if(collapseStartIndex < items.length - 1) {
			toggleItem(getExpandButton());
		}
		refreshToolbar(refresh);
	}
}

function expandToolbar(refresh = true) {
	const items = getToolbarItems();
	if(items) {
		toggleItems(items);
		toggleItem(getExpandButton(), true);
		refreshToolbar(refresh);
	}
}

function refreshToolbar(refresh) {
	if(refresh) {
		const toolbar = getToolbar();
		// for Safari force re-render dom element after toolbar buttons visibility manipulation.
		// https://stackoverflow.com/questions/8840580/force-dom-redraw-refresh-on-chrome-mac
		toolbar.style.display = 'flex';
		setTimeout(() => {
			toolbar.style.display = 'block';
		}, 0);
	}
}

function getToolbar() {
	return document.querySelector('#cke_' + CKEditorCurrentInstanceName);
}

function getToolbarItems() {
	if(!editorToolbars[CKEditorCurrentInstanceName]) {
		const items = getToolbarElementByClass('cke_toolgroup')?.childNodes;
		editorToolbars[CKEditorCurrentInstanceName] = items ? Array.from(items) : null;
	}
	return editorToolbars[CKEditorCurrentInstanceName];
}

function getToolbarElementByClass(className) {
	if(!toolbarElements[CKEditorCurrentInstanceName + className]) {
		toolbarElements[CKEditorCurrentInstanceName + className] = document.querySelector(`#cke_${CKEditorCurrentInstanceName} .${className}`)
	}
	return toolbarElements[CKEditorCurrentInstanceName + className];
}

function getExpandButton() {
	return getToolbarElementByClass('cke_button__expand');
}

function getCollapseButton() {
	return getToolbarElementByClass('cke_button__collapse');
}

function getPreviousVisibleButton() {
	const visibleItems = getToolbarItems().filter(x => !x.classList.contains(hideClass));
	return visibleItems[visibleItems.length - 2];
}

function getLastVisibleButton(id) {
	let visibleButton = getToolbarItems().findLast(x => !x.classList.contains(hideClass));
	if(visibleButton.id === id) {
		visibleButton = getToolbarElementByClass('cke_combo_button');
	}
	return visibleButton;
}

function toggleItems(items, hide = false) {
	items.forEach(item => {
		toggleItem(item, hide);
	});
}

function toggleItem(item, hide = false) {
	hide ? item.classList.add(hideClass) : item.classList.remove(hideClass);
	item.style.display = hide ? 'none' : '';
}

function getCollapseIndex(item) {
	const currentInstance = CKEDITOR.currentInstance || CKEDITOR.instances[CKEditorCurrentInstanceName];
	const currentEditorWidth = currentInstance.getResizable().getClientSize().width;
	const averageButtonWidth = parseInt(window.getComputedStyle(item).width.replace('px', ''));
	return Math.round((currentEditorWidth - firstButtonWidth) / (averageButtonWidth + buttonsSpacing)) - 1;
}

function correctCollapseIndex(collapseStartIndex, buttonsCount) {
	if(collapseStartIndex < minAmountOfButtons) {
		collapseStartIndex = minAmountOfButtons - 1;
	}
	if(collapseStartIndex >= buttonsCount - 4) {
		collapseStartIndex = buttonsCount - 1;
	}
	return collapseStartIndex;
}

function hideSeparator(items, itemsToCollapse, collapseStartIndex) {
	if(items[collapseStartIndex - 1].className === 'cke_toolbar_separator') {
		itemsToCollapse.unshift(items[collapseStartIndex - 1]);
	}
}
