namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IDeduplicationSearchQueryBuilderSchema

	/// <exclude/>
	public class IDeduplicationSearchQueryBuilderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IDeduplicationSearchQueryBuilderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IDeduplicationSearchQueryBuilderSchema(IDeduplicationSearchQueryBuilderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d41dcdd7-e798-4db1-b723-80024a0e025a");
			Name = "IDeduplicationSearchQueryBuilder";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4c53ad23-c903-414d-89cd-b08703861304");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,82,203,110,131,48,16,60,131,196,63,172,210,75,43,85,112,79,40,135,54,109,149,67,213,71,242,3,14,44,137,37,108,232,46,62,68,81,255,189,198,134,200,77,114,40,39,239,120,102,118,188,139,22,10,185,19,37,194,6,137,4,183,117,159,62,181,186,150,59,67,162,151,173,78,151,88,153,174,145,165,171,146,248,152,196,145,97,169,119,176,62,112,143,202,178,155,6,203,225,146,211,87,212,72,178,92,36,177,101,221,16,238,44,10,43,221,35,213,182,197,28,86,127,204,214,40,168,220,127,26,164,195,163,145,77,133,228,116,89,150,65,206,70,41,65,135,98,172,61,21,190,7,46,108,61,25,234,150,160,10,13,129,208,50,184,79,39,151,44,176,233,204,214,242,64,78,105,254,17,38,58,186,64,167,151,188,97,191,111,43,158,195,135,243,242,151,231,113,29,224,44,24,56,140,93,83,171,96,234,136,12,100,26,228,244,100,145,157,123,228,157,32,161,64,219,13,61,204,28,121,86,44,39,249,168,206,51,71,186,174,169,165,174,78,2,254,242,179,153,21,227,225,82,75,216,27,210,92,132,195,182,172,9,30,120,193,148,252,27,3,224,118,245,172,141,66,18,219,6,243,160,175,13,186,220,188,23,62,241,253,224,18,69,47,215,162,193,213,192,119,139,113,9,168,43,191,7,91,253,248,63,44,128,146,216,98,195,247,11,10,96,140,84,210,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d41dcdd7-e798-4db1-b723-80024a0e025a"));
		}

		#endregion

	}

	#endregion

}

