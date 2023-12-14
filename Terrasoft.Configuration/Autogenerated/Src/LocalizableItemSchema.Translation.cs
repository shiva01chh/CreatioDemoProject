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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,165,83,203,106,195,48,16,60,39,144,127,88,232,165,5,19,223,147,182,80,18,40,166,45,13,52,244,174,88,107,35,42,75,70,143,128,27,242,239,213,195,113,28,23,76,32,62,89,187,179,51,171,241,88,144,10,117,77,114,132,45,42,69,180,44,204,124,37,69,193,74,171,136,97,82,204,183,138,8,205,195,251,108,122,152,77,39,86,51,81,194,87,163,13,86,203,238,220,31,87,216,159,114,24,135,186,83,88,186,3,172,56,209,122,1,239,50,39,156,253,146,29,199,204,241,4,72,109,119,156,229,144,123,196,16,0,11,200,254,205,76,14,97,238,204,45,133,54,202,230,70,42,39,177,9,116,17,209,82,15,24,238,29,218,239,254,131,77,2,237,251,158,112,139,9,188,90,70,33,183,220,88,133,25,77,96,77,12,110,89,133,80,73,202,10,134,244,83,36,176,147,146,3,211,47,214,200,18,5,58,195,144,62,128,247,104,50,121,195,6,158,60,243,50,28,191,61,173,43,4,250,88,90,157,216,93,185,83,138,173,143,78,196,245,206,138,177,153,93,10,58,196,96,133,0,59,182,214,160,160,209,157,75,171,54,74,214,168,12,195,129,81,105,154,194,163,182,85,69,84,243,124,42,184,187,204,187,102,218,239,182,190,182,222,249,59,199,219,151,104,226,178,181,98,123,183,19,232,182,112,28,145,9,30,93,37,20,221,188,65,170,245,30,24,69,97,188,187,106,92,55,196,225,252,193,110,80,142,159,54,15,127,6,80,55,53,46,220,229,174,23,137,27,212,215,104,80,85,76,160,6,86,196,48,186,244,0,233,199,103,124,161,144,249,97,4,175,219,104,144,197,88,189,44,186,154,127,254,0,113,166,116,182,150,4,0,0 };
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

