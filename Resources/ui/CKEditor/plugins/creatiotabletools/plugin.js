/**
 * This Source Code Form is subject to the terms of the Mozilla
 * Public License, v. 2.0. If a copy of the MPL was not distributed
 * with this file, You can obtain one at https://mozilla.org/MPL/2.0/
 */

CKEDITOR.plugins.add('creatiotabletools', {
	lang: 'en,ru',
	requires: 'bpmonlinetabletools,contextmenu',
	init: function (editor) {
		var lang = editor.lang.creatiotabletools;
		editor.addMenuGroup('creatiotabletools');
		editor.addMenuItems({

			tablecolumn_insertBefore: {
				label: lang.column.insertBefore,
				group: 'creatiotabletools',
				command: 'columnInsertBefore',
			},

			tablecolumn_insertAfter: {
				label: lang.column.insertAfter,
				group: 'creatiotabletools',
				command: 'columnInsertAfter',
			},

			tablecolumn_delete: {
				label: lang.column.deleteColumn,
				group: 'creatiotabletools',
				command: 'columnDelete',
			},

			tablerow_insertBefore: {
				label: lang.row.insertBefore,
				group: 'creatiotabletools',
				command: 'rowInsertBefore',
			},

			tablerow_insertAfter: {
				label: lang.row.insertAfter,
				group: 'creatiotabletools',
				command: 'rowInsertAfter',
			},

			creatio_tablerow_delete: {
				label: lang.row.deleteRow,
				group: 'creatiotabletools',
				command: 'rowDelete',
			},
			creatio_tabledelete: {
				label: lang.table.deleteTable,
				group: "creatiotabletools",
				command: 'tableDelete',
			},
			tablecell_merge: {
				label: lang.cell.merge,
				group: 'creatiotabletools',
				command: 'cellMerge',
			},
			tablecell_unmerge: {
				label: lang.cell.unmerge,
				group: 'creatiotabletools',
				command: 'cellUnmerge',
			},
		});

		if ( editor.contextMenu ) {
			editor.contextMenu.addListener( function( element, selection, path ) {
				var cell = path.contains( { 'td': 1, 'th': 1 }, 1 );
				if ( cell && !cell.isReadOnly() ) {
					var isMergedCells = cell.getAttribute('rowSpan') > 1 || cell.getAttribute('colSpan');
					return {
						tablecolumn_insertBefore: CKEDITOR.TRISTATE_OFF,
						tablecolumn_insertAfter: CKEDITOR.TRISTATE_OFF,
						tablerow_insertBefore: CKEDITOR.TRISTATE_OFF,
						tablerow_insertAfter: CKEDITOR.TRISTATE_OFF,
						tablecolumn_delete: CKEDITOR.TRISTATE_OFF,
						creatio_tablerow_delete: CKEDITOR.TRISTATE_OFF,
						creatio_tabledelete: CKEDITOR.TRISTATE_OFF,
						tablecell_merge: CKEDITOR.plugins.bpmonlinetabletools.mergeCells( selection, null, true ) ? CKEDITOR.TRISTATE_OFF : CKEDITOR.TRISTATE_DISABLED,
						tablecell_unmerge: isMergedCells ? CKEDITOR.TRISTATE_OFF : CKEDITOR.TRISTATE_DISABLED,
					};
				}
				return null;								
			} );
		}
	},
});
