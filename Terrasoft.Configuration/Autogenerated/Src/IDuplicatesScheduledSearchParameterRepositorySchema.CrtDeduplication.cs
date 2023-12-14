namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IDuplicatesScheduledSearchParameterRepositorySchema

	/// <exclude/>
	public class IDuplicatesScheduledSearchParameterRepositorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IDuplicatesScheduledSearchParameterRepositorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IDuplicatesScheduledSearchParameterRepositorySchema(IDuplicatesScheduledSearchParameterRepositorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("99c0874b-e6e1-4d26-9563-bae0f7a8c6d5");
			Name = "IDuplicatesScheduledSearchParameterRepository";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4c53ad23-c903-414d-89cd-b08703861304");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,197,83,205,78,227,64,12,62,83,169,239,96,193,101,145,80,114,135,110,15,75,87,171,30,64,104,219,23,112,39,78,51,98,58,19,217,147,66,132,246,221,153,153,38,41,180,18,168,28,150,156,98,199,254,254,172,88,220,144,212,168,8,150,196,140,226,74,159,221,58,91,234,117,195,232,181,179,217,140,138,166,54,90,165,106,60,122,25,143,206,46,152,214,161,128,185,245,196,101,88,190,134,249,172,27,34,89,168,42,172,24,42,22,132,172,170,7,228,192,17,6,255,82,237,68,123,199,237,120,20,64,242,60,135,137,52,155,13,114,59,237,234,48,194,36,100,189,0,2,15,243,224,29,160,82,36,18,223,234,30,80,192,149,224,43,2,233,24,161,24,68,128,36,242,172,39,202,223,48,213,205,42,76,129,238,213,159,42,254,44,102,48,132,112,71,190,114,133,92,195,67,130,77,222,142,204,165,198,109,69,234,81,146,98,220,162,54,184,210,70,251,54,186,192,189,171,207,77,193,170,13,11,82,147,210,165,166,162,239,198,133,13,130,13,48,217,160,33,63,20,49,73,68,105,234,231,249,110,229,62,188,159,79,151,145,243,8,41,6,174,162,238,108,146,167,205,61,16,147,111,216,202,116,201,13,129,62,213,195,147,246,85,39,134,169,60,214,147,79,129,158,181,120,185,2,23,160,248,73,11,65,137,70,40,40,233,169,163,150,149,115,6,254,144,159,203,193,201,228,119,220,255,33,158,181,93,195,30,250,242,230,163,27,49,37,149,95,48,83,80,137,141,241,176,69,211,132,79,255,241,72,239,110,179,117,186,232,108,204,118,138,14,114,249,213,46,6,196,19,211,153,145,161,211,211,249,214,36,118,146,191,20,193,5,217,98,247,147,135,234,95,234,189,109,165,78,124,94,1,129,89,50,91,68,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("99c0874b-e6e1-4d26-9563-bae0f7a8c6d5"));
		}

		#endregion

	}

	#endregion

}

