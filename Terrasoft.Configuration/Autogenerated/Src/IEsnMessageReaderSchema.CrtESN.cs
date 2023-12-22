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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,213,85,65,110,219,48,16,60,219,128,255,176,80,47,45,80,72,247,86,17,16,184,174,225,67,155,34,201,7,24,105,101,19,17,151,6,151,108,96,4,249,123,40,82,146,21,55,41,236,0,109,90,95,108,145,59,195,153,89,121,73,66,33,111,69,137,112,141,198,8,214,181,77,231,154,106,185,118,70,88,169,41,93,92,125,159,77,239,103,211,137,99,73,107,184,218,177,69,245,249,224,217,99,154,6,203,22,192,233,18,9,141,44,247,53,115,109,48,93,144,149,86,34,251,101,191,241,206,224,218,23,3,172,200,162,169,189,128,79,176,90,48,125,67,102,177,198,75,20,21,154,80,153,101,25,228,236,148,18,102,87,116,207,63,140,254,41,43,100,80,104,55,186,98,168,181,1,214,165,20,13,16,218,59,109,110,193,120,138,246,112,21,25,57,237,185,178,17,217,214,221,52,178,4,217,139,120,78,195,164,53,255,139,140,176,176,68,11,165,86,10,169,253,238,19,8,106,186,99,211,1,155,29,130,243,173,48,66,1,249,14,156,37,93,249,170,74,138,238,120,144,85,154,103,161,102,15,49,104,157,33,46,114,70,132,210,96,125,150,132,92,119,73,86,72,98,43,200,123,216,43,241,4,61,162,165,88,45,200,41,52,226,166,193,60,194,10,104,93,206,163,5,126,191,116,178,130,65,202,135,216,170,151,173,215,136,21,8,107,69,185,249,223,35,56,31,92,156,156,194,219,217,60,240,22,247,131,157,142,249,149,86,224,78,218,13,136,166,105,115,116,138,24,48,80,255,139,22,207,155,102,30,69,198,189,83,45,151,27,71,183,195,144,8,239,237,105,102,99,117,235,181,19,167,126,99,121,12,108,7,212,197,54,140,204,164,184,236,166,149,142,11,48,206,132,105,228,183,71,64,86,252,173,255,70,252,253,228,149,234,77,127,132,103,213,193,200,219,107,58,224,24,77,152,46,199,54,225,15,102,185,191,217,64,215,67,115,191,92,95,188,204,235,55,59,206,99,226,253,234,125,246,225,30,149,230,228,33,94,161,72,85,188,69,103,211,176,50,254,60,2,156,114,73,48,216,7,0,0 };
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

