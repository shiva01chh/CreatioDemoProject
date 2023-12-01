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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,82,203,110,131,48,16,60,131,196,63,172,210,75,43,85,112,79,40,135,54,109,149,67,213,71,242,3,14,44,137,37,48,116,215,62,68,81,255,189,198,134,200,77,114,40,39,239,120,102,118,188,139,18,45,114,47,74,132,13,18,9,238,106,157,62,117,170,150,59,67,66,203,78,165,75,172,76,223,200,210,85,73,124,76,226,200,176,84,59,88,31,88,99,107,217,77,131,229,112,201,233,43,42,36,89,46,146,216,178,110,8,119,22,133,149,210,72,181,109,49,135,213,31,179,53,10,42,247,159,6,233,240,104,100,83,33,57,93,150,101,144,179,105,91,65,135,98,172,61,21,190,7,46,108,61,25,234,142,160,10,13,129,208,50,88,167,147,75,22,216,244,102,107,121,32,167,52,255,8,19,29,93,160,211,75,222,80,239,187,138,231,240,225,188,252,229,121,92,7,56,11,6,14,99,215,212,181,48,117,68,6,50,13,114,122,178,200,206,61,242,94,144,104,65,217,13,61,204,28,121,86,44,39,249,168,206,51,71,186,174,169,165,170,78,2,254,242,179,153,21,227,225,82,75,168,13,41,46,194,97,91,214,4,15,188,96,74,254,141,1,112,187,122,86,166,69,18,219,6,243,160,175,13,186,220,188,23,62,241,253,224,18,69,47,215,162,193,213,192,119,139,113,9,168,42,191,7,91,253,248,63,44,128,146,216,98,246,251,5,218,83,93,93,209,2,0,0 };
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

