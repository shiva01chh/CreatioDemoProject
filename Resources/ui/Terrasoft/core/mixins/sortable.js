/**
 * Mixin, which adds sorting capabilities to the collection, array, any item store.
 * Used in {@link Terrasoft.Collection}.
 * To mix a mixin, the class must implement the sortByFn method, where sorting and sorting will be implemented
 * elements, by a comparator function
 */
Ext.define("Terrasoft.core.mixins.Sortable", {
	alternateClassName: "Terrasoft.Sortable",

	/**
	 * Sorting direction
	 * @type {Terrasoft.OrderDirection}
	 */
	sortDirection: Terrasoft.OrderDirection.ASC,

	/**
	 * The name of the property by which objects will be sorted
	 * @type {String}
	 */
	sortProperty: "Name",

	/**
	 * The basic function is a comparator that compares 2 elements
	 * @private
	 * @return {Function}
	 */
	getDefaultSortFn: function(propertyName) {
		const defaultSortFn = function(object1, object2) {
			const property1 = object1[propertyName];
			const property2 = object2[propertyName];
			if (property1 === property2) {
				return 0;
			}
			if (property1 === null) {
				return 1;
			}
			if (property2 === null) {
				return -1;
			}
			return (property1 < property2) ? -1 : 1;
		};
		return defaultSortFn;
	},

	/**
	 * Returns the generated function-comparator
	 * @private
	 * @param {String} sortProperty The name of the property to sort. If not specified is used by default
	 * @param {Terrasoft.OrderDirection} sortDirection Sorting direction.
	 * If not specified is used by default
	 * @param {function} sortFn The comparison function of 2 elements
	 * @return {function} Returns the generated function-comparator
	 */
	generateSortFn: function(sortProperty, sortDirection, sortFn) {
		const order = sortDirection || this.sortDirection;
		const modifier = (order === Terrasoft.OrderDirection.ASC) ? 1 : -1;
		let fn;
		if (sortFn) {
			fn = sortFn;
		} else {
			const property = sortProperty || this.sortProperty;
			fn = this.getDefaultSortFn(property);
		}
		const resultFn = function(object1, object2) {
			return modifier * fn(object1, object2);
		};
		return resultFn;
	},

	/**
	 * Sorts a set of items
	 * @param {String} property The name of the property to sort. If not specified is used by default
	 * @param {Terrasoft.OrderDirection} direction Sorting direction.
	 * If not specified is used by default
	 * @param {function} sortFn The comparison function of 2 elements
	 */
	sort: function(property, direction, sortFn) {
		sortFn = this.generateSortFn(property, direction, sortFn);
		this.sortByFn(sortFn);
		return this;
	}

});
