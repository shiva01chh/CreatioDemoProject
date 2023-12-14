namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IFileImportServiceSchema

	/// <exclude/>
	public class IFileImportServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IFileImportServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IFileImportServiceSchema(IFileImportServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1053b299-f5b8-465b-9060-5fe6f2707c72");
			Name = "IFileImportService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("39b49a3d-3e30-4c01-a6cc-3961eeed3fd5");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,229,85,77,111,130,64,16,61,99,226,127,216,232,5,19,195,15,208,244,210,38,54,52,161,26,49,241,96,60,172,48,208,109,97,151,238,44,36,166,233,127,239,176,128,213,216,120,233,73,229,66,246,205,155,143,55,179,48,146,231,128,5,143,128,173,64,107,142,42,49,222,147,146,137,72,75,205,141,80,210,155,137,12,252,188,80,218,244,123,95,253,158,83,162,144,41,11,247,104,32,247,66,208,149,136,32,80,49,100,211,75,70,111,13,59,34,16,101,168,33,165,184,140,249,210,128,78,40,245,132,249,191,73,90,39,75,221,180,7,42,200,104,30,25,247,149,170,101,15,108,112,70,31,140,182,196,47,202,93,38,34,38,186,192,127,198,117,106,17,135,42,2,48,111,42,198,9,91,88,95,155,214,217,204,11,104,212,119,153,183,22,38,13,190,172,212,7,184,141,91,93,202,98,30,174,6,99,182,132,207,18,208,204,148,206,185,33,156,168,1,32,242,20,26,200,123,65,37,199,236,81,197,251,208,236,51,56,161,28,80,111,173,121,81,64,60,174,211,57,206,146,70,163,36,194,229,168,86,186,115,50,180,86,108,231,207,66,94,65,221,10,119,52,189,94,133,221,28,17,169,108,95,38,234,32,239,25,204,153,209,61,27,125,43,128,233,230,125,205,173,184,60,236,174,27,243,221,59,208,71,115,207,141,176,218,239,250,54,52,162,111,92,127,86,230,18,3,242,167,237,115,252,87,56,181,44,184,166,253,65,187,1,111,186,29,149,18,113,125,247,255,45,126,8,50,110,214,36,157,190,155,229,125,4,89,164,126,126,0,216,247,208,230,68,8,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1053b299-f5b8-465b-9060-5fe6f2707c72"));
		}

		#endregion

	}

	#endregion

}

