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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,142,77,10,194,64,12,133,215,22,122,135,128,91,233,1,170,184,105,193,141,110,212,11,140,211,215,97,160,157,150,100,102,81,196,187,155,169,130,43,3,129,252,124,201,123,193,140,144,217,88,208,29,204,70,166,62,86,205,20,122,239,18,155,232,167,80,181,232,210,60,120,187,118,101,241,44,139,77,18,31,28,221,22,137,24,149,30,6,216,188,148,234,132,0,246,118,95,22,74,109,25,78,167,212,12,70,164,166,11,216,225,138,30,140,96,241,187,90,217,57,61,84,130,108,70,255,146,84,83,235,215,202,240,114,144,200,234,98,71,103,47,241,219,28,143,250,42,27,124,105,102,7,8,221,199,68,22,209,97,142,55,103,62,81,2,242,0,0,0 };
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

