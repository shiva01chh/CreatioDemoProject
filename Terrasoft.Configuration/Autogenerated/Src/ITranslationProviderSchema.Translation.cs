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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,84,77,107,219,64,16,61,59,144,255,176,56,23,21,132,116,79,84,65,113,77,17,180,37,196,38,61,111,164,145,179,84,187,107,102,118,77,76,200,127,207,126,248,67,118,101,199,129,250,164,157,125,251,230,205,155,241,40,46,129,150,188,6,54,7,68,78,186,53,217,68,171,86,44,44,114,35,180,202,230,200,21,117,225,251,250,234,245,250,106,100,73,168,5,155,173,201,128,188,59,58,187,183,93,7,181,7,83,246,3,20,160,168,247,152,126,10,132,108,170,140,48,2,200,1,28,228,6,97,225,158,177,74,25,192,214,41,186,101,85,47,247,61,234,149,104,0,3,118,105,159,58,81,51,177,133,158,64,142,94,3,122,71,253,11,204,179,110,232,150,221,135,247,241,50,207,115,86,144,149,146,227,186,220,6,254,160,48,64,204,236,89,179,29,54,63,6,23,75,142,92,50,229,172,252,58,254,11,235,113,249,0,164,45,58,93,238,148,21,121,184,31,134,247,50,56,235,172,84,191,93,120,92,246,202,97,117,136,7,252,39,185,30,121,103,135,201,86,254,230,128,109,165,69,19,203,238,193,19,50,232,27,231,202,72,217,230,123,80,241,233,219,160,225,203,221,25,175,103,224,39,134,88,253,204,213,2,154,62,197,70,46,69,189,116,105,15,192,15,150,107,67,24,176,15,26,128,192,155,56,23,167,141,98,75,212,53,80,152,97,25,176,255,90,247,224,120,38,177,130,249,177,7,20,76,160,36,234,97,81,94,202,190,133,255,73,17,157,219,58,152,250,169,78,217,119,238,26,33,36,148,108,47,240,172,139,62,255,160,135,61,215,250,117,211,154,38,182,51,22,129,42,213,234,207,155,117,10,127,208,154,51,214,80,242,83,144,41,170,217,78,136,215,81,178,35,97,169,167,25,253,103,171,8,134,231,141,28,179,99,187,208,177,184,242,88,189,9,58,53,173,70,25,183,197,69,182,56,25,3,190,204,188,132,164,154,42,43,1,249,83,7,31,122,116,182,218,233,11,212,214,47,51,30,60,116,42,99,197,241,56,92,106,188,27,151,209,246,75,138,153,239,41,147,248,106,147,111,171,237,6,84,19,215,112,56,191,197,157,127,16,12,177,254,239,29,242,129,193,232,157,6,0,0 };
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

