namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IEsnMessageReaderSchema

	/// <exclude/>
	public class IEsnMessageReaderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IEsnMessageReaderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IEsnMessageReaderSchema(IEsnMessageReaderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("06f8b050-f68f-4336-acf7-4f1801ecd769");
			Name = "IEsnMessageReader";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,213,85,203,110,219,48,16,60,219,128,255,97,161,94,90,160,144,238,173,34,32,112,93,195,135,54,69,146,31,96,164,149,77,68,92,26,92,178,129,81,244,223,203,135,100,43,110,82,216,1,250,242,197,22,185,51,156,153,149,151,36,20,242,86,212,8,183,104,140,96,221,218,124,174,169,149,107,103,132,149,154,242,197,205,231,217,244,219,108,58,113,44,105,13,55,59,182,168,222,31,61,123,76,215,97,29,0,156,47,145,208,200,250,80,51,215,6,243,5,89,105,37,178,95,246,27,175,12,174,125,49,192,138,44,154,214,11,120,7,171,5,211,39,100,22,107,188,70,209,160,137,149,69,81,64,201,78,41,97,118,85,255,252,197,232,175,178,65,6,133,118,163,27,134,86,27,96,93,75,209,1,161,125,208,230,30,140,167,8,135,171,196,200,249,192,85,140,200,182,238,174,147,53,200,65,196,83,26,38,193,252,79,50,226,194,18,45,212,90,41,164,240,61,36,16,213,244,199,230,123,108,113,12,46,183,194,8,5,228,59,112,145,245,229,171,38,171,250,227,65,54,121,89,196,154,3,196,160,117,134,184,42,25,17,106,131,237,69,22,115,221,101,69,37,137,173,32,239,225,160,196,19,12,136,64,177,90,144,83,104,196,93,135,101,130,85,16,92,206,147,5,126,189,116,178,129,189,148,55,169,85,207,91,111,17,27,16,214,138,122,243,191,71,112,185,119,113,118,10,127,207,230,145,183,180,31,237,244,204,47,180,2,15,210,110,64,116,93,200,209,41,98,192,72,253,47,90,188,236,186,121,18,153,246,206,181,92,111,28,221,239,135,68,124,111,207,51,155,170,131,215,94,156,250,133,229,49,48,12,168,171,109,28,153,89,117,221,79,43,157,22,96,156,9,211,200,239,128,128,162,250,83,255,141,244,251,209,43,53,152,126,11,79,170,131,145,183,151,116,192,49,154,56,93,78,109,194,111,204,242,112,179,129,110,247,205,253,112,123,245,60,175,223,236,57,79,137,247,163,247,57,132,123,82,154,147,239,233,10,69,106,210,45,58,155,198,149,240,249,1,84,195,242,94,208,7,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("06f8b050-f68f-4336-acf7-4f1801ecd769"));
		}

		#endregion

	}

	#endregion

}

