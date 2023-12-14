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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,144,193,106,2,65,12,134,207,43,248,14,129,94,218,203,238,221,150,130,84,17,15,5,65,95,96,58,155,93,7,118,50,75,50,3,21,241,221,157,157,209,234,22,193,220,146,252,249,191,159,144,178,40,189,210,8,59,100,86,226,26,95,126,57,106,76,27,88,121,227,168,92,96,29,250,206,232,212,77,39,199,233,164,8,98,168,133,237,65,60,218,247,127,125,188,238,58,212,131,88,202,21,18,178,209,55,205,61,196,90,71,113,19,119,47,140,109,212,195,154,60,114,19,195,204,96,189,69,197,122,191,184,160,81,230,201,114,249,139,58,120,199,233,172,170,42,248,144,96,173,226,195,231,165,31,165,5,171,72,181,200,229,85,92,221,169,251,240,19,117,96,174,204,231,200,226,152,176,127,113,191,209,239,93,45,51,216,36,171,188,92,5,83,67,190,193,155,85,182,126,125,76,24,253,27,228,185,230,109,120,104,145,162,32,213,57,77,162,159,242,59,71,195,56,27,234,12,15,29,75,42,233,1,0,0 };
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

