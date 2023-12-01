namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ISearchDuplicatesActionExecutorSchema

	/// <exclude/>
	public class ISearchDuplicatesActionExecutorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ISearchDuplicatesActionExecutorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ISearchDuplicatesActionExecutorSchema(ISearchDuplicatesActionExecutorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3b0287fd-e228-4668-ae2a-c035310e2343");
			Name = "ISearchDuplicatesActionExecutor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4c53ad23-c903-414d-89cd-b08703861304");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,144,207,106,195,48,12,198,207,41,244,29,4,187,180,151,228,222,141,194,104,74,233,97,48,232,94,192,115,148,212,16,203,65,178,97,165,236,221,231,218,253,151,50,168,110,146,62,125,191,15,145,178,40,131,210,8,95,200,172,196,181,190,92,57,106,77,23,88,121,227,168,172,177,9,67,111,116,234,166,147,227,116,82,4,49,212,193,238,32,30,237,235,67,31,175,251,30,245,73,44,229,6,9,217,232,155,230,30,98,173,163,184,137,187,23,198,46,234,97,75,30,185,141,97,22,176,221,161,98,189,175,207,104,148,247,100,185,254,65,29,188,227,116,86,85,21,188,73,176,86,241,97,121,238,71,105,193,42,82,29,114,121,17,87,119,234,33,124,71,29,152,11,243,57,178,56,38,236,53,238,7,250,189,107,100,1,159,201,42,47,55,193,52,144,111,240,102,149,173,103,255,19,70,255,6,121,174,153,159,30,90,164,40,72,77,78,147,232,191,249,157,163,97,156,197,250,3,215,235,92,43,232,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3b0287fd-e228-4668-ae2a-c035310e2343"));
		}

		#endregion

	}

	#endregion

}

