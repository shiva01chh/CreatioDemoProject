﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ESNNotificationTextFormerSchema

	/// <exclude/>
	public class ESNNotificationTextFormerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ESNNotificationTextFormerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ESNNotificationTextFormerSchema(ESNNotificationTextFormerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("615ac9f9-a7fd-447a-8d74-8c8b66ed21a3");
			Name = "ESNNotificationTextFormer";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b66b5ae8-46e0-4931-ad78-c2c1ba5fd6ea");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,189,86,219,78,219,64,16,125,54,18,255,176,50,47,142,100,249,3,146,210,10,66,64,72,36,160,226,62,85,85,181,177,39,97,139,47,209,238,58,52,173,248,247,206,94,124,77,236,0,15,205,11,120,247,204,57,179,51,103,47,25,77,65,108,104,4,36,4,206,169,200,87,50,152,230,217,138,173,11,78,37,203,179,211,147,191,167,39,78,33,88,182,38,143,59,33,33,157,116,190,17,159,36,16,41,176,8,110,32,3,206,162,26,211,164,77,211,60,59,60,195,1,199,113,230,140,195,26,121,200,52,161,66,140,201,236,113,177,200,37,91,177,72,231,18,194,111,121,157,243,20,184,6,111,138,101,194,34,18,41,108,63,116,76,110,191,66,202,178,24,53,155,4,142,90,87,45,136,201,75,154,73,20,125,224,108,75,37,104,9,103,99,62,72,164,230,137,144,92,101,174,179,91,96,229,200,57,201,240,79,190,242,122,229,71,147,126,26,44,8,100,18,226,187,60,162,9,251,67,151,9,60,234,41,203,237,134,76,38,80,193,220,126,170,59,246,124,140,70,67,6,40,230,168,129,153,31,163,169,96,3,84,11,120,153,131,16,116,13,195,92,53,206,53,237,119,206,32,139,77,71,236,183,109,207,53,131,36,238,235,13,7,26,231,89,178,35,223,4,112,108,100,102,204,72,126,22,173,239,35,18,218,1,188,136,100,206,149,144,246,150,213,49,62,235,109,177,215,209,109,203,142,136,54,26,193,95,39,33,172,195,94,134,142,243,58,156,230,28,228,83,222,91,10,219,128,27,144,87,248,57,219,98,179,60,245,95,200,176,236,91,154,20,96,211,113,44,50,198,201,57,141,120,46,48,155,78,126,184,153,229,94,3,189,202,252,62,113,175,170,104,215,248,188,164,149,168,247,113,218,176,138,238,208,46,243,120,87,45,236,35,204,151,77,130,146,124,75,185,174,3,18,234,18,5,97,110,67,235,234,52,160,106,109,251,208,122,197,22,202,65,22,60,179,29,9,148,83,168,244,90,11,240,181,170,175,9,71,125,189,119,156,195,221,223,247,103,221,123,181,74,239,246,138,233,162,80,190,251,100,166,124,146,47,127,97,165,62,147,21,102,243,64,57,214,68,2,23,165,37,218,163,193,244,9,162,231,11,190,46,212,233,179,40,146,196,115,219,136,178,126,149,193,34,220,137,120,78,221,43,103,87,182,27,181,131,190,187,211,18,229,254,104,53,215,70,95,238,236,25,225,153,241,190,120,131,235,112,196,101,42,231,237,61,80,101,214,177,233,110,3,23,229,94,236,211,51,128,142,80,106,206,173,129,176,242,100,235,44,50,1,202,141,101,48,214,178,40,223,78,235,9,111,223,244,33,164,155,196,88,244,67,158,47,227,177,101,100,216,157,37,210,111,247,195,111,212,202,111,174,194,175,106,222,178,240,158,39,245,129,255,31,77,217,232,240,17,63,133,22,82,118,74,237,113,134,239,26,21,210,61,243,213,34,70,179,172,72,3,100,16,224,41,250,3,183,191,134,249,149,120,247,108,84,183,113,207,197,104,27,50,75,55,114,103,163,94,152,140,158,136,167,82,42,139,226,68,84,192,222,133,164,120,131,234,181,48,54,72,103,80,110,248,9,50,177,20,75,116,194,243,228,152,178,126,96,188,73,181,255,181,242,62,197,234,45,242,38,213,225,7,206,251,148,235,151,203,155,164,143,60,136,14,104,191,54,119,105,63,119,112,43,212,38,184,231,218,48,222,200,16,125,105,217,200,140,141,223,125,112,244,171,246,95,86,102,172,57,132,35,205,223,63,27,194,215,208,112,12,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateBodyTemplateLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateBodyTemplateLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("e4399fbc-e9a5-40a2-8060-6e13837ce944"),
				Name = "BodyTemplate",
				CreatedInPackageId = new Guid("b66b5ae8-46e0-4931-ad78-c2c1ba5fd6ea"),
				CreatedInSchemaUId = new Guid("615ac9f9-a7fd-447a-8d74-8c8b66ed21a3"),
				ModifiedInSchemaUId = new Guid("615ac9f9-a7fd-447a-8d74-8c8b66ed21a3")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("615ac9f9-a7fd-447a-8d74-8c8b66ed21a3"));
		}

		#endregion

	}

	#endregion

}

