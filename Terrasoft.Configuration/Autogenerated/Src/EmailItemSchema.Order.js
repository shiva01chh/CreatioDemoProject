define("EmailItemSchema", ["EmailConstants", "LinkOrderFilterMixin"], function(EmailConstants) {
    return {
        entitySchemaName: EmailConstants.entitySchemaName,
        methods: {},
        diff: /**SCHEMA_DIFF*/[]/**SCHEMA_DIFF*/,
        mixins: {
            LinkOrderFilterMixin: "Terrasoft.LinkOrderFilterMixin"
        },
        attributes: {
            "Order": {
                lookupListConfig: {
                    columns: ["Contact", "Account"],
                    filters: [
                        function() {
                            return this.filterOrderByContactAndAccount();
                        }
                    ]
                }
            }
        },
        rules: {}
    };
});
