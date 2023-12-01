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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,83,193,106,227,48,16,61,187,208,127,24,186,23,7,74,124,111,26,95,194,182,20,218,165,208,133,61,46,138,61,142,197,218,146,59,146,82,66,233,191,239,88,178,131,18,187,109,46,138,103,222,204,27,189,121,82,162,69,211,137,2,225,55,18,9,163,43,187,220,104,85,201,157,35,97,165,86,151,23,239,151,23,137,51,82,237,224,229,96,44,182,156,111,26,44,250,164,89,222,163,66,146,197,234,28,243,40,213,43,7,57,252,131,112,199,80,216,52,194,152,27,184,147,216,148,79,162,235,144,54,181,144,202,99,178,44,131,91,169,106,110,101,75,93,64,65,88,173,175,30,206,177,87,89,206,224,206,109,27,201,152,190,223,164,29,220,192,164,140,107,222,61,205,113,22,143,224,97,158,73,238,133,197,144,236,194,199,73,253,157,40,172,166,3,252,173,38,177,213,208,18,85,25,186,158,82,60,147,102,172,149,216,211,248,137,67,222,95,213,184,182,21,116,200,199,192,61,90,3,154,192,244,167,173,17,60,29,180,158,15,170,64,184,60,150,103,113,253,32,199,220,212,51,161,126,153,73,178,67,59,252,75,100,5,233,204,237,96,189,6,229,154,102,49,226,18,66,235,72,205,41,1,12,197,183,25,182,116,177,10,197,31,225,248,188,69,192,5,24,139,0,235,252,19,162,189,104,28,122,244,199,215,250,63,161,173,117,57,39,254,247,62,99,87,91,255,89,6,163,4,223,29,149,254,169,92,139,36,182,13,222,254,193,109,173,245,63,126,17,174,85,92,146,195,89,105,26,163,141,37,126,34,57,188,133,170,128,184,134,16,30,163,47,218,81,129,215,65,138,144,65,101,165,61,252,226,167,58,174,99,47,40,184,99,160,25,86,240,40,141,157,206,52,174,33,30,37,190,115,62,24,173,239,50,93,226,81,12,50,233,233,136,241,92,129,161,210,132,162,168,33,141,219,67,180,72,224,23,58,144,29,157,21,165,151,124,12,186,157,105,20,95,118,17,187,101,240,84,156,255,194,30,33,122,26,244,49,254,253,7,223,135,59,243,11,5,0,0 };
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

