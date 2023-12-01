namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SupportMailBoxBinderSchema

	/// <exclude/>
	public class SupportMailBoxBinderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SupportMailBoxBinderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SupportMailBoxBinderSchema(SupportMailBoxBinderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("bc5ec1ee-8ee0-40d6-ba02-de9f93ecefc3");
			Name = "SupportMailBoxBinder";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,80,209,106,194,64,16,124,54,224,63,44,233,139,133,146,188,171,21,170,180,80,168,180,212,66,159,47,151,77,122,144,220,30,123,23,81,164,255,222,53,167,69,81,159,142,221,153,155,157,25,171,90,244,78,105,132,47,100,86,158,170,144,45,200,86,166,238,88,5,67,118,152,236,134,201,160,243,198,214,103,20,198,236,69,233,64,108,208,79,174,48,190,177,16,86,219,146,21,84,240,59,198,90,228,96,209,40,239,199,176,234,156,35,14,75,101,154,57,109,230,198,150,200,61,47,207,115,152,250,174,109,21,111,103,135,57,194,80,17,11,132,8,154,177,122,76,95,207,53,62,209,145,55,98,104,155,230,179,236,168,148,159,72,185,174,104,140,6,189,119,112,213,0,140,225,201,185,231,53,218,240,102,124,64,139,60,87,30,229,235,174,247,246,31,98,137,225,135,74,137,241,209,75,70,240,32,79,107,233,192,148,8,107,50,37,188,91,81,92,5,197,97,116,148,150,122,3,110,2,232,248,222,195,190,224,193,160,144,75,217,9,253,8,79,122,180,175,45,22,190,205,246,110,167,55,227,63,192,45,100,54,74,47,203,138,7,126,15,1,209,150,49,99,63,199,237,249,82,118,73,242,7,88,125,214,127,55,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("bc5ec1ee-8ee0-40d6-ba02-de9f93ecefc3"));
		}

		#endregion

	}

	#endregion

}

