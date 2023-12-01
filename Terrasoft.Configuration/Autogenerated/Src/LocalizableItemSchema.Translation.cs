namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: LocalizableItemSchema

	/// <exclude/>
	public class LocalizableItemSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public LocalizableItemSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public LocalizableItemSchema(LocalizableItemSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("19dfea59-9b33-4952-b46b-b44061ba40b3");
			Name = "LocalizableItem";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6d72ca66-8680-4c3f-b4a0-15ba7a19db7c");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,165,83,77,107,131,64,16,61,39,144,255,48,208,75,11,18,239,73,91,40,9,20,105,75,3,13,189,111,116,148,165,235,174,236,71,192,134,252,247,142,187,198,24,11,18,136,39,119,230,205,123,179,207,167,100,37,154,138,165,8,91,212,154,25,149,219,249,74,201,156,23,78,51,203,149,156,111,53,147,70,248,247,217,244,48,155,78,156,225,178,128,175,218,88,44,151,221,185,63,174,177,63,69,24,66,221,105,44,232,0,43,193,140,89,192,187,74,153,224,191,108,39,48,33,30,15,169,220,78,240,20,210,6,49,4,192,2,146,127,51,147,131,159,59,115,43,105,172,118,169,85,154,36,54,158,46,32,90,234,1,195,61,161,155,221,127,176,142,160,125,223,51,225,48,130,87,199,51,72,157,176,78,99,146,69,176,102,22,183,188,68,40,85,198,115,142,217,167,140,96,167,148,0,110,94,156,85,5,74,36,195,48,123,128,198,163,201,228,13,107,120,106,152,151,254,248,221,208,82,193,211,135,210,234,196,78,229,78,41,180,62,58,17,234,157,21,67,51,185,20,36,196,96,5,15,59,182,214,160,204,130,59,151,86,109,180,170,80,91,142,3,163,226,56,134,71,227,202,146,233,250,249,84,160,187,204,187,102,220,239,182,190,182,222,53,119,14,183,47,208,134,101,43,205,247,180,19,152,182,112,28,145,241,30,93,37,20,220,188,65,170,245,30,120,134,210,54,238,234,113,93,31,135,243,7,187,65,57,124,218,212,255,25,144,209,212,184,112,151,187,94,36,110,80,95,163,69,93,114,137,6,120,30,194,72,233,1,214,143,207,248,66,62,243,195,8,94,183,209,32,139,161,122,89,164,26,61,127,19,60,225,29,149,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("19dfea59-9b33-4952-b46b-b44061ba40b3"));
		}

		#endregion

	}

	#endregion

}

