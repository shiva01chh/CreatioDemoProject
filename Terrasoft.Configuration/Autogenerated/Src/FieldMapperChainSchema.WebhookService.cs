namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FieldMapperChainSchema

	/// <exclude/>
	public class FieldMapperChainSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FieldMapperChainSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FieldMapperChainSchema(FieldMapperChainSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("78eea549-96b0-4d4a-9003-79a704dc0682");
			Name = "FieldMapperChain";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("fe674b36-6b4e-4761-be68-f76112863a49");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,83,193,106,227,48,16,61,187,208,127,24,186,23,7,74,124,111,26,95,194,182,20,218,165,208,133,61,46,138,61,142,197,218,146,59,146,82,66,233,191,175,172,177,131,18,187,109,46,138,103,222,204,27,189,121,82,162,69,211,137,2,225,55,18,9,163,43,187,220,104,85,201,157,35,97,165,86,151,23,239,151,23,137,51,82,237,224,229,96,44,182,62,223,52,88,244,73,179,188,71,133,36,139,213,57,230,81,170,87,31,244,225,31,132,59,15,133,77,35,140,185,129,59,137,77,249,36,186,14,105,83,11,169,2,38,203,50,184,149,170,246,173,108,169,11,40,8,171,245,213,195,57,246,42,203,61,184,115,219,70,122,76,223,111,210,14,110,96,82,230,107,222,3,205,113,150,128,240,195,60,147,220,11,139,156,236,248,227,164,254,78,20,86,211,1,254,86,147,216,106,104,137,170,228,174,167,20,207,164,61,214,74,236,105,194,196,156,15,87,53,174,109,5,29,242,49,112,143,214,128,38,48,253,105,107,132,64,7,109,224,131,138,9,151,199,242,44,174,31,228,152,155,122,38,212,47,51,73,118,104,135,127,137,172,32,157,185,29,172,215,160,92,211,44,70,92,66,104,29,169,57,37,192,67,241,109,134,45,93,172,184,248,131,143,207,91,48,142,97,94,4,88,231,159,16,237,69,227,48,160,63,190,214,255,9,109,173,203,57,241,191,247,153,119,181,13,159,37,27,133,125,119,84,250,167,114,45,146,216,54,120,251,7,183,181,214,255,252,139,112,173,242,37,57,156,149,166,49,218,88,242,79,36,135,55,174,98,196,53,112,120,140,190,104,71,5,94,179,20,156,65,101,165,61,252,242,79,117,92,199,94,16,187,99,160,25,86,240,40,141,157,206,52,174,33,30,37,190,115,62,24,173,239,50,93,226,81,12,50,233,233,136,241,92,204,80,105,66,81,212,144,198,237,33,90,36,248,23,58,144,29,157,21,165,151,254,24,116,59,211,40,190,236,34,118,203,224,169,56,255,133,61,56,122,26,12,177,254,247,31,81,242,72,36,12,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("78eea549-96b0-4d4a-9003-79a704dc0682"));
		}

		#endregion

	}

	#endregion

}

