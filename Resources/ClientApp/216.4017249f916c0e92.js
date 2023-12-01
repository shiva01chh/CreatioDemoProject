"use strict";(self.webpackChunkapp_studio_enterprise_system_designer=self.webpackChunkapp_studio_enterprise_system_designer||[]).push([[216],{7216:(se,A,i)=>{i.r(A),i.d(A,{DEPEND_ON_SQL_SCRIPTS:()=>ee,SQL_SCRIPT_SCHEMA:()=>K,SqlDesignerStructureService:()=>h,SqlScriptSchemaDataService:()=>g,SqlScriptSchemaDesignerModule:()=>y});var O=i(55211),B=i(88692),b=i(20092),E=i(17914),L=i(25237),G=i(83331),M=i(15756),w=i(95236),N=i(74817),F=i(7392),x=i(93254),_=i(42094),I=i(56707),u=i(26522),S=i(65149),r=i(80542),l=i(28262),c=i(75378),P=i(98168),Z=i(54882),k=i(26903),H=i(74970),Y=i(27969);class U extends l.$W{constructor(e){super(e),this._dialogService=e.get(u.xA)}get translationPrefix(){return"SchemaDesigners"}_getMiniCardConfig(e){const t=this._getDependSqlMiniCardConfig(e),s={title:this.getTranslation("SqlSchemaDesignerMiniPage.Title"),cancelBtnTitle:this.getTranslation("BaseDesignerStructureService.MiniPage.Cancel"),dynamicForm:r.jlq.create(t),useValidation:!0};return this.getIsApplyButtonVisible()&&(s.okBtnTitle=this.getApplyButtonTitle()),s}_getDependSqlMiniCardConfig(e){return[{columns:[{formComponents:[new r.kSE({controlType:r.$5M.TextBox,key:"name",label:this.getTranslation("BaseDesignerStructureService.MiniPage.NameTitle"),value:e.name,isDisabled:!0}),new r.kSE({controlType:r.$5M.TextBox,key:"packageName",label:this.getTranslation("BaseDesignerStructureService.MiniPage.PackageTitle"),value:e.packageName,isDisabled:!0})]}]}]}openMiniCard(e){const t=this._getMiniCardConfig(e);return this._dialogService.open(r.Eqq,{data:t})}openMultiselectMiniCard(e){return this._dialogService.open(r.iQ4,{data:e})}getIsControlsDisabled(){return!1}getApplyButtonTitle(){return this.getTranslation("BaseDesignerStructureService.MiniPage.Ok")}getIsApplyButtonVisible(){return!0}openDependOnSqlScriptsMiniCard(e){return this.openMiniCard(e).pipe((0,H.h)(t=>t!==void 0),(0,Y.U)(t=>e),(0,k.B)())}}var p;(function(a){a[a.MSSql=0]="MSSql",a[a.Oracle=1]="Oracle",a[a.PostgreSql=2]="PostgreSql"})(p||(p={}));var o;(function(a){a[a.BeforePackage=0]="BeforePackage",a[a.AfterPackage=1]="AfterPackage",a[a.AfterSchemaData=2]="AfterSchemaData",a[a.UninstallApp=3]="UninstallApp"})(o||(o={}));class z extends S.iL{constructor(){super(...arguments),this.dbEngineType=p.MSSql,this.installType=o.AfterPackage,this.dependOnSqlScripts=new S.Ts,this.dependencySqlScripts=new S.Ts,this.backwardCompatibilityConfirmed=!1}get packageName(){if(this.package)return this.package.name}get DefaultName(){return"SqlScriptSchema"}findChildrenItem(e){return this.dependOnSqlScripts.findItem(e)||this.dependencySqlScripts.findItem(e)}findGroup(e){return this.dependOnSqlScripts.uId===e?this.dependOnSqlScripts:this.dependencySqlScripts.uId===e?this.dependencySqlScripts:null}updateDescription(e){super.updateDescription(e),this.dbEngineType=e.dbEngineType,this.installType=e.installType,this.backwardCompatibilityConfirmed=e.backwardCompatibilityConfirmed}}class V extends S.y1{}var Q=i(35732),n=i(64537);class g extends S.wY{constructor(e){super(e)}getDependOnSqlScripts(e){const t=this.serviceEndpoint+"GetDependOnSqlScripts";return this.httpClient.post(t,e,{headers:new Q.WM({"Content-Type":"application/json"})}).pipe((0,k.B)())}validateSchema(e){const t=this.serviceEndpoint+"ValidateSchema";return this.httpClient.post(t,e).pipe((0,k.B)())}}g.\u0275fac=function(e){return new(e||g)(n.LFG(n.zs3))},g.\u0275prov=n.Yz7({token:g,factory:g.\u0275fac});class f extends U{constructor(e){super(e),this._searchColumnsSqlSchemas=["name","packageName"],this._apiDataService=e.get(g),this._maskService=e.get(u.Bm)}get translationPrefix(){return"SchemaDesigners.MultiSelectSqlSchemasMiniPage"}_getDependOnSelectMiniCardData(e){return e.map(t=>{const s=new V;return s.uId=t.uId,s.name=t.name,s.packageName=t.package.name,s.scriptSchema=t,s})}_getMultiSelectSqlSchemasDialogData(e){const t={columns:[{name:"name",caption:this.getTranslation("TableColumn.Name"),valueType:c.DataValueType.Text},{name:"packageName",caption:this.getTranslation("TableColumn.Package"),valueType:c.DataValueType.Text}]};return{title:this.getTranslation("Title"),dataSchema:t,data:this._getDependOnSelectMiniCardData(e),sortColumn:"name",sortDirection:"asc",searchColumns:this._searchColumnsSqlSchemas}}execute(e){this._maskService.showBodyMask();const t=e.schema;return this._apiDataService.getDependOnSqlScripts(t).pipe((0,P.b)(()=>this._maskService.hideBodyMask()),(0,Z.z)(s=>{const d=this._getMultiSelectSqlSchemasDialogData(s.values);return this.openMultiselectMiniCard(d)})).pipe((0,P.b)(s=>{s.forEach(d=>{this.getMetaItemsGroup(e).addItem(d)})}),(0,k.B)())}}f.\u0275fac=function(e){return new(e||f)(n.LFG(n.zs3))},f.\u0275prov=n.Yz7({token:f,factory:f.\u0275fac,providedIn:"root"});class m extends U{constructor(e){super(e)}getIsControlsDisabled(){return!0}getIsApplyButtonVisible(){return!1}execute(e){const s=this.getMetaItemsGroup(e).findItem(e.itemUId);return this.openDependOnSqlScriptsMiniCard(s)}}m.\u0275fac=function(e){return new(e||m)(n.LFG(n.zs3))},m.\u0275prov=n.Yz7({token:m,factory:m.\u0275fac});var $=i(19791),j=i(11465),J=i(61528),W=i(5998);class D extends l.ZS{constructor(e,t,s,d){super(e),this._featureService=t,this._domSanitizer=s,this._academyHelpUrlService=d}get editDescriptionCaptionKey(){return"SchemaDesigners.SqlSchemaDesignerMiniPage.Title"}_getDbEngineTypeToFormConfig(e){return new r.kSE({controlType:r.$5M.DropDown,key:"dbEngineType",label:this.translateService.instant("SchemaDesigners.SqlSchemaDesignerMiniPage.DbmsType"),value:e.dbEngineType.toString(),required:!0,isDisabled:this.getIsReadOnly(e),options:[{key:p.MSSql.toString(),value:p[p.MSSql]},{key:p.Oracle.toString(),value:p[p.Oracle]},{key:p.PostgreSql.toString(),value:p[p.PostgreSql]}]})}_getInstallTypeToFormConfig(e){return new r.kSE({controlType:r.$5M.DropDown,key:"installType",label:this.translateService.instant("SchemaDesigners.SqlSchemaDesignerMiniPage.InstallationType"),value:e.installType.toString(),required:!0,isDisabled:this.getIsReadOnly(e),options:[{key:o.BeforePackage.toString(),value:o[o.BeforePackage]},{key:o.AfterPackage.toString(),value:o[o.AfterPackage]},{key:o.AfterSchemaData.toString(),value:o[o.AfterSchemaData]},{key:o.UninstallApp.toString(),value:o[o.UninstallApp]}]})}_getBackwardCompatibilityConfirmedToFormConfig(e){return new r.kSE({controlType:r.$5M.CheckBox,key:"backwardCompatibilityConfirmed",label:this.translateService.instant("SchemaDesigners.SqlSchemaDesignerMiniPage.BackwardCompatibilityConfirmed"),value:e.backwardCompatibilityConfirmed,isDisabled:this.getIsReadOnly(e)})}_getBackwardCompatibilityConfirmedLabelWithInnerLink(){const e=this._getHelpLinkUrl();return new r.kSE({controlType:r.$5M.LabelWithInnerLink,label:this.translateService.instant("SchemaDesigners.SqlSchemaDesignerMiniPage.BackwardCompatibilityConfirmedLabelBeforeLink"),key:e.caption,value:e.url,info:this.translateService.instant("SchemaDesigners.SqlSchemaDesignerMiniPage.BackwardCompatibilityConfirmedLabelAfterLink")})}_getHelpLinkUrl(){return{url:this._domSanitizer.bypassSecurityTrustUrl(this._articleUrl),caption:this.translateService.instant("SchemaDesigners.SqlSchemaDesignerMiniPage.AcademyHelpUrlCaption")}}_getAcademyHelpUrl(){return this._academyHelpUrlService.getAcademyHelpUrl("BackwardCompatibilitySqlScript")}getMiniCardControls(e){const t=super.getMiniCardControls(e),s=e.model;return t.push(this._getDbEngineTypeToFormConfig(s),this._getInstallTypeToFormConfig(s),this.getPackageNameToFormConfig(s)),this._featureState&&(t.push(this._getBackwardCompatibilityConfirmedToFormConfig(s)),t.push(this._getBackwardCompatibilityConfirmedLabelWithInnerLink())),t}execute(e){return this._featureService.getFeatureState("FeatureUseSqlScriptBackwardCompatibility").pipe((0,J.w)(t=>(this._featureState=t,t?this._getAcademyHelpUrl().pipe((0,P.b)(s=>{this._articleUrl=s}),(0,J.w)(()=>super.execute(e))):super.execute(e))))}}D.\u0275fac=function(e){return new(e||D)(n.LFG(n.zs3),n.LFG(j.UZ),n.LFG(W.H7),n.LFG($.ph))},D.\u0275prov=n.Yz7({token:D,factory:D.\u0275fac});var X=i(13528);class h extends l.ml{constructor(e){super(e)}get translationPrefix(){return"SchemaDesigners.SqlSchemaDesignerPage"}_getDependsOnSqlScriptActions(e){const t=new l.H0;return t.addCommandType=f,this.getActions(e,t)}_getDependsOnSqlScriptItemsActions(e){const t=new l.H0;return t.deleteCommandType=l.G8,t.showCommandType=m,this.getChildrenActions(e,t)}_generateDependentSqlScripts(e){const t=l.lw.create({caption:this.getTranslation("DependentScriptsCaption"),icon:"depends-by-icon.svg",uId:e.dependencySqlScripts.uId,newChildActions:[l.E_.createShowAction(m)]});return t.addChildren(e.dependencySqlScripts),t}_generateDependsOnSqlScript(e){const t=l.lw.create({caption:this.getTranslation("DependsOnScriptCaption"),uId:e.dependOnSqlScripts.uId,icon:"depends-on-icon.svg",actions:this._getDependsOnSqlScriptActions(e),newChildActions:this._getDependsOnSqlScriptItemsActions(e)});return t.addChildren(e.dependOnSqlScripts),t}getActions(e,t){return this.getIsReadOnly(e)?[]:[l.E_.createAddAction(t.addCommandType)]}getChildrenActions(e,t){return this.getIsReadOnly(e)?[l.E_.createShowAction(t.showCommandType)]:[l.E_.createShowAction(t.showCommandType),l.E_.createDeleteAction(t.deleteCommandType)]}getModelStructureData(e){const t=[],s=l.lw.create({caption:this.getTranslation("Caption"),icon:"sql-schema-designer-caption-icon.svg"}),d=this._generateDependsOnSqlScript(e),R=this._generateDependentSqlScripts(e);return t.push(s,d,R),t}}h.\u0275fac=function(e){return new(e||h)(n.LFG(n.zs3))},h.\u0275prov=n.Yz7({token:h,factory:h.\u0275fac});const K={body:"SELECT TOP(1) Id FROM Contact",uId:(0,c.generateGuid)(),caption:[{cultureName:"en-US",value:"test sql script"}],name:"TestSqlScript",dbEngineType:0,isReadOnly:!1,installType:2,package:{isChanged:!1,isLocked:!1,name:"TestPackageName",uId:(0,c.generateGuid)()},dependencySqlScripts:[{name:"Depend_By_Sql_Script",uId:(0,c.generateGuid)(),package:{isChanged:!1,isLocked:!1,name:"TestDependByPackage",uId:(0,c.generateGuid)()}}],dependOnSqlScripts:[{name:"Depend_On_Sql_Script",uId:(0,c.generateGuid)(),package:{isChanged:!1,isLocked:!1,name:"TestDependOnPackage",uId:(0,c.generateGuid)()}}]},ee=[{uId:(0,c.generateGuid)(),name:"TestSqlScript_1",caption:{values:[{cultureName:"en-En",value:"test sql script_1"}]},package:{isChanged:!1,isLocked:!1,name:"TestPackageName_1",uId:(0,c.generateGuid)()}},{uId:(0,c.generateGuid)(),name:"TestSqlScript_2",caption:{values:[{cultureName:"en-En",value:"test sql script_2"}]},package:{isChanged:!1,isLocked:!1,name:"TestPackageName_2",uId:(0,c.generateGuid)()}},{uId:(0,c.generateGuid)(),name:"TestSqlScript_3",caption:{values:[{cultureName:"en-En",value:"test sql script_3"}]},package:{isChanged:!1,isLocked:!1,name:"TestPackageName_3",uId:(0,c.generateGuid)()}},{uId:(0,c.generateGuid)(),name:"TestSqlScript_4",caption:{values:[{cultureName:"en-En",value:"test sql script_4"}]},package:{isChanged:!1,isLocked:!1,name:"TestPackageName_4",uId:(0,c.generateGuid)()}},{uId:(0,c.generateGuid)(),name:"TestSqlScript_5",caption:{values:[{cultureName:"en-En",value:"test sql script_5"}]},package:{isChanged:!1,isLocked:!1,name:"TestPackageName_5",uId:(0,c.generateGuid)()}},{uId:(0,c.generateGuid)(),name:"TestSqlScript_6_lalalallalalallalalalallalalallalalalallalala",caption:{values:[{cultureName:"en-En",value:"test sql script_6_lalalalallalalllaallalalalalalalal"}]},package:{isChanged:!1,isLocked:!1,name:"TestPackageName_6",uId:(0,c.generateGuid)()}}];var te=i(40508),ne=i(15748),ae=i(65304);class C extends l.jn{constructor(e){super(e),this.language=r.YpL.Sql}get designerStructureService(){return this._designerStructureService}get apiDataService(){return this._apiDataService}get modelType(){return z}_validatePageData(e){return this.apiDataService.validateSchema(e)}_validateInfoDialog(e){e.success?this.openInfoDialog(this.translateInstant("SchemaDesigners.SqlSchemaDesignerPage.SqlScriptValidateCaption")):this.openInfoDialog(e.errorInfo.message)}injectDependencies(){super.injectDependencies(),this._designerStructureService=this.injector.get(h),this._apiDataService=this.injector.get(g)}getGtmSchemaName(){return"SqlScriptSchemaDesignerPage"}validate(){this.showBodyMask();const e=this.preProcessModelForSave(this.model);this._validatePageData(e).pipe((0,X.R)(this.destroyed$)).subscribe(t=>{this.hideBodyMask(),t&&this._validateInfoDialog(t)})}onCodeChanged(e){this.model.body=e,this.setIsChanged()}}C.\u0275fac=function(e){return new(e||C)(n.Y36(n.zs3))},C.\u0275cmp=n.Xpm({type:C,selectors:[["ts-sql-script-schema-designer-page"]],features:[n.qOj],decls:12,vars:11,consts:[[1,"base-section-wrap"],[3,"saveButtonVisible","saveClick","cancelClick","closeClick"],["mat-button","",1,"action-button",3,"click"],[1,"schema-designer-page"],[1,"schema-designer-structure-wrapper","pane"],[3,"dataSource","caption","isSearchEnabled","designerTypeCaptionImage","itemActionClick"],[1,"schema-designer-page-main-content"],[1,"pane"],[1,"schema-designer-page-code-editor-wrapper"],[3,"text","language","readOnly","textChange"]],template:function(e,t){e&1&&(n.TgZ(0,"div",0)(1,"ts-schema-designer-page-header",1),n.NdJ("saveClick",function(){return t.save()})("cancelClick",function(){return t.cancel()})("closeClick",function(){return t.close()}),n.TgZ(2,"button",2),n.NdJ("click",function(){return t.validate()}),n._uU(3),n.ALo(4,"translate"),n.qZA()(),n.TgZ(5,"div",3)(6,"div",4)(7,"ts-schema-designer-structure",5),n.NdJ("itemActionClick",function(d){return t.onStructureItemClick(d)}),n.qZA()(),n.TgZ(8,"div",6)(9,"div",7)(10,"div",8)(11,"ts-code-editor",9),n.NdJ("textChange",function(d){return t.onCodeChanged(d)}),n.qZA()()()()()()),e&2&&(n.xp6(1),n.Q6J("saveButtonVisible",t.saveButtonVisible()),n.xp6(2),n.hij(" ",n.lcZ(4,9,"BasePageComponent.Check")," "),n.xp6(4),n.Q6J("dataSource",t.schemaStructure)("caption",t.model.name)("isSearchEnabled",t.isSearchEnabled)("designerTypeCaptionImage","sql-schema-caption-icon.svg"),n.xp6(4),n.Q6J("text",t.model.body)("language",t.language)("readOnly",t.isReadOnlyMode))},dependencies:[te.w,M.eB,ne.h,ae.a,I.X$],encapsulation:2});class T extends S.gX{constructor(){super(z)}_createScripts(e){const t=e.map(d=>this.createSchema(d)),s=new S.Ts;return s.push(...t),s}convertToSchema(e){const t=super.createSchema(e);return t.dependOnSqlScripts=this._createScripts(e.dependOnSqlScripts),t.dependencySqlScripts=this._createScripts(e.dependencySqlScripts),t}}T.\u0275fac=function(e){return new(e||T)},T.\u0275prov=n.Yz7({token:T,factory:T.\u0275fac});var q=i(7976);const ie=[{path:"",component:C},{path:"new",component:C},{path:":uId",component:C}];class v{}v.\u0275fac=function(e){return new(e||v)},v.\u0275mod=n.oAB({type:v}),v.\u0275inj=n.cJS({imports:[q.Bz.forChild(ie),q.Bz]}),function(){(typeof ngJitMode>"u"||ngJitMode)&&n.kYT(v,{imports:[q.Bz],exports:[q.Bz]})}();class y{}y.\u0275fac=function(e){return new(e||y)},y.\u0275mod=n.oAB({type:y}),y.\u0275inj=n.cJS({providers:[r.Pnv,u.xA,f,m,l.G8,{provide:r.thQ,useValue:"SqlScriptSchemaDesignerModule"},g,h,(0,S.Ap)("SqlScriptSchemaDesignerService.svc"),{provide:S.Jk,useClass:T},u.Bm,{provide:l.ZS,useClass:D}],imports:[r.kLW,v,I.aw,r.Y05,u._M,M.yu,G.Ps,w.wp,N.x4,x.uw,E.To,F.gR,L.N6,_.SJ,u.Su,b.u5,B.ez,O.nZ,l.Z_,S.JI]}),function(){(typeof ngJitMode>"u"||ngJitMode)&&n.kYT(y,{declarations:[C],imports:[r.kLW,v,I.aw,r.Y05,u._M,M.yu,G.Ps,w.wp,N.x4,x.uw,E.To,F.gR,L.N6,_.SJ,u.Su,b.u5,B.ez,O.nZ,l.Z_,S.JI]})}()}}]);
