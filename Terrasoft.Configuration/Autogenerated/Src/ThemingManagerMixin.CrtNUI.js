 define("ThemingManagerMixin", [], function() {
     Ext.define("Terrasoft.configuration.ThemingManagerMixin", {
         alternateClassName: "Terrasoft.ThemingManagerMixin",
         extend: "Terrasoft.BaseObject",

         _currentThemeProfileKey: "CurrentTheme",
         _defaulTheme: {
             id: "60abcb5d-bb5e-4e88-bdfa-79cfb7d17b06",
             caption: "Default",
             cssSelector: "default-theme",
             code: "default",
         },

         /**
          * @return{Promise<unknown>}
          */
         loadThemes: async function() {
             const themes = {
                 "60abcb5d-bb5e-4e88-bdfa-79cfb7d17b06": {
                     id: "60abcb5d-bb5e-4e88-bdfa-79cfb7d17b06",
                     caption: "Default",
                     cssSelector: "default-theme",
                     code: "default",
                 },
                 "b002bd94-d970-4637-bac2-54252e17a604": {
                     id: "b002bd94-d970-4637-bac2-54252e17a604",
                     caption: "Freedom",
                     cssSelector: "freedom-theme",
                     code: "freedom",
                 }
             };
             return themes;
         },

         /**
          * @return{Promise<unknown>}
          */
         loadCurrentTheme: async function() {
             return new Promise((resolve) => {
                 const jsonData = { key: this._currentThemeProfileKey };
                 Terrasoft.ServiceProvider.executeRequest("QuerySchemaProfile", jsonData, function(profiles) {
                     profiles = Array.isArray(profiles) ? profiles : [];
                     const currentTheme = profiles.pop() ?? this._defaulTheme;
                     resolve(currentTheme);
                 }, this);
             })
         },

         /**
          * @param {Object} currentTheme
          * @param {String} currentTheme.id
          * @param {String} currentTheme.caption
          * @param {String} currentTheme.code
          * @param {String} currentTheme.cssSelector
          * @return{Promise<unknown>}
          */
         saveCurrentTheme: async function(currentTheme) {
             return new Promise((resolve, reject) => {
                 const jsonData = {
                     data: Ext.encode(currentTheme),
                     key: this._currentThemeProfileKey
                 };
                 Terrasoft.ServiceProvider.executeRequest("UserSchemaProfile", jsonData, function (response) {
                     if (response.success) {
                         resolve();
                     } else {
                         reject(response?.errorInfo?.message);
                     }
                 }, this);
             });
         },

         /**
          * Apply current theme to body tag.
          * @return {Promise<unknown>}
          */
         applyCurrentTheme: async function() {
             const isEnabledChangeTheme = Terrasoft.Features.getIsEnabled("ChangeTheme");
             if (isEnabledChangeTheme) {
                 const currentTheme = await this.loadCurrentTheme();
                 document.body.classList.add(currentTheme?.cssSelector ?? "default-theme");
                 return;
             }
             const themes = ['freedom-theme', 'default-theme', 'brigth-theme'];
             const hasTheme = themes.some(theme => document.body.classList.contains(theme));
             if (!hasTheme) {
                 document.body.classList.add("default-theme");
             }
         },

     });
	 return {};
 });
