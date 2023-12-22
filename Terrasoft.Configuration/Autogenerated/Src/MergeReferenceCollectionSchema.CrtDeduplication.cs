namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MergeReferenceCollectionSchema

	/// <exclude/>
	public class MergeReferenceCollectionSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MergeReferenceCollectionSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MergeReferenceCollectionSchema(MergeReferenceCollectionSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5a6b80e9-72e3-4e49-9d00-89ee49b01416");
			Name = "MergeReferenceCollection";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4c53ad23-c903-414d-89cd-b08703861304");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,142,77,10,194,48,16,133,215,22,122,135,128,91,233,1,170,116,211,130,27,221,168,23,136,233,107,8,164,105,153,73,22,69,188,187,147,42,232,198,129,129,249,249,102,222,11,122,4,207,218,64,221,64,164,121,26,98,213,78,97,112,54,145,142,110,10,85,135,62,205,222,153,181,43,139,71,89,108,18,187,96,213,117,225,136,81,104,239,97,242,146,171,35,2,200,153,125,89,8,181,37,88,153,170,214,107,230,90,157,65,22,23,12,32,4,131,239,213,202,206,233,46,18,202,100,244,47,169,106,213,185,181,210,180,28,56,146,184,216,169,147,227,248,105,154,70,94,101,131,79,201,236,0,161,127,155,200,34,50,252,141,23,145,60,201,92,250,0,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5a6b80e9-72e3-4e49-9d00-89ee49b01416"));
		}

		#endregion

	}

	#endregion

}

