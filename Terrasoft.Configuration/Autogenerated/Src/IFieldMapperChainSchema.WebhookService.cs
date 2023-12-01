namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IFieldMapperChainSchema

	/// <exclude/>
	public class IFieldMapperChainSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IFieldMapperChainSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IFieldMapperChainSchema(IFieldMapperChainSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a18d0b8b-0554-48fe-80f3-0d61e8456086");
			Name = "IFieldMapperChain";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("fe674b36-6b4e-4761-be68-f76112863a49");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,82,77,107,195,48,12,61,39,144,255,32,218,203,6,35,185,111,89,46,101,43,61,116,12,90,216,217,77,148,198,44,182,131,108,111,148,210,255,62,219,73,183,164,116,80,31,140,173,143,167,167,39,73,38,80,119,172,68,216,34,17,211,170,54,233,66,201,154,239,45,49,195,149,76,226,99,18,71,86,115,185,135,205,65,27,20,206,223,182,88,122,167,78,151,40,145,120,249,148,196,46,42,203,50,200,181,21,130,209,161,24,254,219,6,161,35,245,197,43,36,80,53,124,227,174,81,234,19,80,26,110,14,233,57,43,27,165,117,118,215,242,18,184,52,72,181,167,182,122,229,216,86,107,214,117,72,139,134,113,71,42,58,250,138,48,156,57,225,222,209,129,53,154,70,85,250,17,222,3,196,56,228,130,219,216,188,68,163,193,56,158,194,87,168,160,246,213,116,122,145,155,93,79,206,59,70,76,128,116,58,62,207,134,230,2,93,61,43,124,239,231,126,7,208,60,11,241,55,128,108,148,165,18,167,32,58,216,110,1,233,229,125,115,239,89,225,111,47,189,111,113,144,253,31,4,66,99,73,234,80,115,42,70,158,157,125,78,251,104,245,34,173,64,98,187,22,243,143,158,155,91,10,43,164,155,81,225,245,12,179,170,122,29,238,198,209,218,144,219,164,2,38,74,61,64,111,134,73,235,191,214,191,94,238,251,61,139,230,40,171,126,228,225,127,74,226,147,127,184,243,3,100,252,237,36,208,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a18d0b8b-0554-48fe-80f3-0d61e8456086"));
		}

		#endregion

	}

	#endregion

}

