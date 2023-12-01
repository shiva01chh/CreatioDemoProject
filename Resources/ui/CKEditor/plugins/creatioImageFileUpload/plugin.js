CKEDITOR.plugins.add('creatioImageFileUpload',
	{
		lang: 'en,ru',
		init: function(editor) {
			editor.addCommand('creatioImageFileUploadCommand', {
				allowedContent: {
					img: {
						attributes: '!src,srcset,alt,width,sizes'
					}
				},
				exec: function() {
					const hiddenUploadElement = CKEDITOR.dom.element.createFromHtml(
						'<input type="file" accept="image/*" multiple="multiple">',
					);
					hiddenUploadElement.once('change', function (evt) {
						const targetElement = evt.data.getTarget();
						for (let index = 0; index < targetElement.$.files.length; index++) {
							let dt = new DataTransfer();
							dt.items.add( targetElement.$.files[index]);
							editor.fire('paste', {
								method: 'paste',
								dataValue: '',
								dataTransfer: new CKEDITOR.plugins.clipboard.dataTransfer({
									files: dt.files,
									types: ['Files'],
								}),
							});
						}
					});
					var onFocus = function() {
						window.removeEventListener('focus', onFocus);
						editor.fire('CreatioImageWindowClose', {}, editor);
					};
					hiddenUploadElement.$.addEventListener('click', function() {
						window.addEventListener('focus', onFocus);
					});
					editor.fire('CreatioImageClick', {}, editor);
					hiddenUploadElement.$.click();
				}
			});
			editor.ui.addButton('CreatioImageFileUploadButton', {
				label: editor.lang.creatioImageFileUpload.label,
				command: 'creatioImageFileUploadCommand'
			});
		}
	});