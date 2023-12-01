namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IImportParametersRepositorySchema

	/// <exclude/>
	public class IImportParametersRepositorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IImportParametersRepositorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IImportParametersRepositorySchema(IImportParametersRepositorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0944487b-5887-4694-84cc-de8e541b2ac6");
			Name = "IImportParametersRepository";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("a83ae89b-1206-453d-b626-f37ab41fffbf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,148,75,111,219,48,12,199,207,9,144,239,64,244,212,1,129,125,223,188,92,218,46,208,105,69,179,199,89,177,232,76,152,45,25,146,220,194,24,246,221,71,89,118,226,87,187,36,91,96,32,48,197,199,143,127,83,84,188,64,91,242,20,225,11,26,195,173,206,92,116,167,85,38,15,149,225,78,106,21,125,146,57,178,162,212,198,173,150,191,86,203,69,101,165,58,192,174,182,14,139,15,163,119,10,205,115,76,125,156,141,182,168,208,200,116,226,195,62,147,137,140,101,181,207,101,10,82,57,52,153,39,96,161,204,35,55,4,69,70,251,132,165,182,210,105,83,195,123,96,15,202,73,87,159,108,201,216,125,67,73,61,225,34,142,99,72,108,85,20,220,212,155,206,240,181,20,220,33,88,199,15,8,58,3,217,68,131,69,107,9,247,24,22,143,227,146,210,23,0,69,69,62,222,72,113,179,73,226,198,50,239,160,240,37,96,237,124,157,161,243,179,150,162,197,232,249,220,110,43,50,75,177,134,147,210,205,129,125,80,21,165,29,36,124,23,164,155,239,240,30,115,210,1,202,163,32,144,105,115,101,159,161,100,136,97,98,166,143,80,172,133,31,122,191,9,185,69,103,59,166,148,171,20,115,200,114,126,136,254,7,88,227,109,208,85,70,217,13,155,214,72,226,238,208,123,239,181,206,61,14,179,172,159,244,174,9,64,113,121,107,237,132,249,82,109,89,20,215,79,218,184,81,54,200,2,76,68,23,13,226,55,158,87,56,39,252,228,203,6,1,6,154,92,173,69,105,116,74,254,68,59,21,226,234,79,126,161,18,45,67,47,178,163,146,138,182,129,242,155,71,76,101,232,95,212,199,46,197,172,16,107,104,172,199,58,103,207,127,239,166,190,72,247,163,199,149,234,162,244,247,235,45,141,186,89,190,151,205,194,165,179,144,229,39,214,32,237,92,147,192,149,128,231,48,8,51,16,163,251,113,202,155,248,254,214,48,217,183,190,153,239,84,178,147,231,136,125,251,55,9,32,163,93,7,153,209,5,136,253,57,77,62,53,255,33,204,58,131,188,24,209,238,26,163,207,237,215,104,120,187,124,108,219,21,122,46,221,63,140,105,111,137,122,224,87,81,23,191,87,75,122,232,247,7,171,114,10,207,171,7,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0944487b-5887-4694-84cc-de8e541b2ac6"));
		}

		#endregion

	}

	#endregion

}

