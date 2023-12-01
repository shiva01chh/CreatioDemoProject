namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ITranslationProviderSchema

	/// <exclude/>
	public class ITranslationProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ITranslationProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ITranslationProviderSchema(ITranslationProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("cd13a96a-b434-42c3-9a58-2582a3d879ed");
			Name = "ITranslationProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("78785e02-81e9-4a6c-b0c2-c299c97e7bb9");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,84,77,139,219,48,16,61,103,97,255,131,200,94,92,48,246,125,215,53,148,52,20,67,91,150,77,104,207,90,123,146,21,181,165,48,35,133,134,165,255,189,35,41,31,78,234,100,179,208,156,172,209,211,155,55,111,38,163,101,7,180,146,53,136,57,32,74,50,11,155,77,140,94,168,165,67,105,149,209,217,28,165,166,54,124,223,222,188,222,222,140,28,41,189,20,179,13,89,232,30,78,206,252,182,109,161,246,96,202,190,128,6,84,245,1,211,79,129,144,77,181,85,86,1,49,128,33,119,8,75,126,38,42,109,1,23,172,232,94,84,189,220,143,104,214,170,1,12,216,149,123,110,85,45,212,14,122,6,57,122,13,232,61,245,55,176,47,166,161,123,241,24,222,199,203,60,207,69,65,174,235,36,110,202,93,224,39,42,11,36,236,129,53,219,99,243,83,112,177,146,40,59,161,217,202,143,227,95,176,25,151,79,64,198,33,235,226,83,86,228,225,126,24,222,203,192,214,185,78,127,231,240,184,236,149,35,234,16,15,248,119,114,253,144,173,27,38,91,251,155,35,182,181,81,77,44,187,7,79,200,162,111,28,151,145,138,237,247,160,226,243,183,65,195,135,135,11,94,207,192,79,12,137,250,69,234,37,52,125,138,173,92,138,122,233,218,30,128,31,44,110,67,24,176,55,26,128,32,155,56,23,231,141,18,43,52,53,80,152,225,46,96,255,181,238,137,121,38,177,130,249,169,7,20,76,160,36,234,17,81,94,42,62,133,255,73,17,157,219,57,152,250,169,78,197,103,201,141,80,29,148,226,32,240,162,139,62,255,160,135,61,215,250,117,211,134,38,174,181,14,129,42,189,48,239,55,235,28,254,168,53,23,172,161,228,171,34,91,84,179,189,16,175,163,20,39,194,82,79,51,250,207,86,17,12,207,27,49,51,179,93,233,88,92,121,162,222,6,89,205,194,96,23,183,197,85,182,176,140,1,95,102,94,66,82,77,181,235,0,229,115,11,111,122,116,177,218,233,111,168,157,95,102,50,120,200,42,99,197,241,56,92,106,188,27,151,209,246,107,138,153,31,40,147,248,106,155,111,167,237,14,116,19,215,112,56,255,137,59,255,40,24,98,252,251,11,233,217,99,96,148,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("cd13a96a-b434-42c3-9a58-2582a3d879ed"));
		}

		#endregion

	}

	#endregion

}

