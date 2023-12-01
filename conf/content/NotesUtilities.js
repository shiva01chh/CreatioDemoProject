﻿Terrasoft.configuration.Structures["NotesUtilities"] = {innerHierarchyStack: ["NotesUtilities"]};
define("NotesUtilities", ["terrasoft", "NotesUtilitiesResources", "ConfigurationFileApi"],
		function(Terrasoft, resources) {
	var NotesUtilitiesClass = Ext.define("Terrasoft.configuration.mixins.NotesUtilities", {
		alternateClassName: "Terrasoft.NotesUtilities",

		/**
		 * ######### ########### # ##.
		 * @private
		 * @param {Array} files #####.
		 */
		insertImagesToNotes: function(files) {
			this.Terrasoft.each(files, function(file) {
				this.addImageToNotes(file);
			}, this);
		},

		/**
		 * ########## ######### ######## ######.
		 * @private
		 * @param {Array} files #####.
		 * @return {Object} ######### ######## ######.
		 */
		getImagesUploadConfig: function(files) {
			var fileEntitySchemaName = this.getFileEntitySchemaName();
			return {
				columnName: "Data",
				entitySchemaName: fileEntitySchemaName,
				files: files,
				isChunkedUpload: true,
				onUpload: this.onNotesImagesUpload,
				onComplete: this.onNotesImagesUploadComplete,
				onFileComplete: this.onNotesImageUploadComplete,
				parentColumnName: this.entitySchema.name,
				parentColumnValue: this.get("Id"),
				scope: this
			};
		},

		/**
		 * ########## ####### ########## ######## #####.
		 * @private
		 * @param {Boolean|String} error False, ### ########## ######, ##### ##### ######.
		 * @param {Object} xhr ######.
		 * @param {Object} file ####.
		 */
		onNotesImageUploadComplete: function(error, xhr, file) {
			if (!error) {
				this.addImageToNotes(file);
			}
		},

		/**
		 * ########## ####### ######### ###########. ########## ######## ######## ##### # #####.
		 * @private
		 * @param {String} fileName ######## #####.
		 * @param {String} url #####.
		 * @return {Terrasoft.BaseViewModel} ####### ######### ###########.
		 */
		getNotesImagesCollectionItem: function(fileName, url) {
			return this.Ext.create("Terrasoft.BaseViewModel", {
				values: {
					fileName: fileName,
					url: url
				}
			});
		},

		/**
		 * ######### #### # ######### ########### # ###########.
		 * @private
		 * @param {Object} file ####.
		 */
		addImageToNotes: function(file) {
			this.readAsDataURL(file, function(image) {
				var imagesCollection = this.get("NotesImagesCollection");
				imagesCollection.addItem(image);
			}, this);
		},

		/**
		 * ###### ###### ############ # ############# ######### ###### ##### ######### ###########.
		 * @private
		 */
		promtSaveRecordBeforeImagesUpload: function() {
			var message = resources.localizableStrings.SaveRecordBeforeImageInsert;
			this.showConfirmationDialog(message, function(returnCode) {
				if (returnCode === this.Terrasoft.MessageBoxButtons.NO.returnCode) {
					return;
				}
				this.save({
					isSilent: true,
					callback: this.insertImagesAfterRecordSaved,
					scope: this
				});
			}, [this.Terrasoft.MessageBoxButtons.YES.returnCode, this.Terrasoft.MessageBoxButtons.NO.returnCode]);
		},

		/**
		 * ######### ########### ##### ########## ##### ######.
		 * @private
		 * @param {Object} response ######### ########## ######.
		 */
		insertImagesAfterRecordSaved: function(response) {
			var config = this.get("ImagesUploadConfig");
			this.Terrasoft.ConfigurationFileApi.upload(config);
			this.sendSaveCardModuleResponse(response.success);
		},

		/**
		 * ######### ########### ## ###### ##### # ###### ####### # ######### # ##########.
		 * #### # ####### ########### ###### ######, ##### ######### ###########.
		 * @private
		 * @param {Array} images ###########.
		 */
		uploadImages: function(images) {
			var config = this.getImagesUploadConfig(images);
			var isNewRecord = (this.isAddMode() || this.isCopyMode());
			if (isNewRecord) {
				this.set("ImagesUploadConfig", config);
				this.promtSaveRecordBeforeImagesUpload();
			} else {
				this.Terrasoft.ConfigurationFileApi.upload(config);
			}
		},

		/**
		 * Read data from file.
		 * @public
		 * @param {File} file selected file.
		 * @param {Function} callback Callback.
		 * @param {Object} scope Execution context.
		 */
		readAsDataURL: function(file, callback, scope) {
			const localFile = file instanceof File
				? file
				: new File([file], file.name);
			FileAPI.readAsDataURL(localFile, function(event) {
				if (event.type !== "load") {
					return;
				}
				var image = this.getNotesImagesCollectionItem(event.target.name, event.result);
				Ext.callback(callback, scope || this, [image]);
			}.bind(this));
		},

		/**
		 * ############## ######### ### ###########, ########### # ######## ##########.
		 */
		initNotesImagesCollection: function() {
			this.set("NotesImagesCollection", this.Ext.create("Terrasoft.BaseViewModelCollection"));
		}
	});
	return Ext.create(NotesUtilitiesClass);
});


