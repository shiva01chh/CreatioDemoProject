namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IMLEntityPredictorSchema

	/// <exclude/>
	public class IMLEntityPredictorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IMLEntityPredictorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IMLEntityPredictorSchema(IMLEntityPredictorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4f591c48-2aae-4f89-af89-1090bb3a3146");
			Name = "IMLEntityPredictor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("73704ec6-562c-4400-8a4a-17477a18625f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,82,65,78,195,48,16,60,83,169,127,88,245,4,82,149,60,128,54,18,2,132,34,181,82,164,150,7,184,241,166,53,36,118,180,107,3,21,234,223,177,147,26,2,225,80,159,188,235,153,217,217,145,181,104,144,91,81,34,108,145,72,176,169,108,114,111,116,165,246,142,132,85,70,39,235,213,116,242,57,157,92,57,86,122,15,155,35,91,108,110,191,235,33,139,48,41,200,148,200,252,91,194,163,61,62,77,83,88,176,107,26,65,199,236,92,231,218,34,85,97,122,101,8,90,66,169,202,192,0,161,37,176,120,11,19,236,1,135,47,132,236,106,11,74,3,106,171,236,49,137,210,233,64,187,117,187,90,149,30,20,229,243,245,234,177,131,23,189,146,33,143,10,91,141,108,117,141,51,138,163,15,228,75,108,140,125,244,157,86,144,104,64,251,164,151,179,198,72,172,115,57,203,182,94,175,43,64,201,32,81,41,164,100,145,118,216,255,169,253,160,200,237,171,139,201,63,214,159,25,105,43,248,117,150,133,27,88,127,133,119,101,15,195,237,240,195,146,128,142,207,99,93,66,235,72,115,86,252,141,195,67,227,91,0,155,221,11,150,54,134,121,167,229,198,39,121,253,228,148,132,115,12,115,232,170,184,217,28,214,171,7,97,69,49,50,11,99,255,176,4,237,234,250,38,252,197,211,116,114,10,159,44,156,47,62,229,40,153,210,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4f591c48-2aae-4f89-af89-1090bb3a3146"));
		}

		#endregion

	}

	#endregion

}

