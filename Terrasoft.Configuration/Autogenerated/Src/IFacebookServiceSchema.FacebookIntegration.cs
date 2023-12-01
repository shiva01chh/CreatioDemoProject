namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IFacebookServiceSchema

	/// <exclude/>
	public class IFacebookServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IFacebookServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IFacebookServiceSchema(IFacebookServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("653008e5-9c4b-409b-9e2f-8dcc34086cdd");
			Name = "IFacebookService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("42c3ed99-d529-4b29-9a2a-6514376125eb");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,229,88,77,111,226,48,16,61,83,169,255,193,162,23,42,85,249,1,173,246,80,160,172,168,4,173,54,72,61,84,61,24,103,8,22,137,157,218,99,118,81,181,255,125,7,155,32,210,143,172,246,184,113,46,81,158,223,76,230,189,100,28,59,138,151,96,43,46,128,45,192,24,110,245,10,147,145,86,43,153,59,195,81,106,149,164,90,72,94,156,159,189,157,159,245,156,149,42,103,233,206,34,148,73,10,102,43,5,204,116,6,197,77,219,96,114,43,80,110,125,182,118,222,19,44,137,64,148,11,3,57,177,217,84,33,152,21,85,119,205,166,19,58,45,181,222,28,34,60,239,249,112,65,21,163,225,2,7,115,146,195,190,177,254,59,114,255,242,133,216,149,91,22,82,48,89,39,253,36,103,239,205,231,61,22,48,3,92,235,204,94,179,71,31,27,6,159,31,42,8,230,212,247,125,241,48,149,63,85,91,189,129,65,8,219,23,242,248,144,46,250,87,236,7,188,58,176,56,209,166,228,72,56,81,103,96,45,207,33,64,201,189,213,234,138,13,117,182,75,113,87,64,131,114,68,147,39,195,171,10,178,125,62,91,105,101,161,61,161,87,221,107,60,206,131,210,58,158,165,128,183,66,80,228,130,234,86,131,240,176,231,128,63,181,217,28,185,190,118,102,194,249,242,230,191,116,225,68,229,81,252,247,152,197,79,164,202,226,80,223,218,0,35,3,28,33,136,39,59,180,83,216,97,43,26,58,167,106,165,79,123,225,195,96,148,70,236,251,34,38,39,90,187,99,12,5,196,211,29,237,19,197,26,196,38,22,39,134,220,210,162,170,44,185,202,40,204,21,72,209,251,42,71,206,24,80,145,124,53,63,154,112,247,11,132,195,26,236,176,244,20,184,17,235,166,234,128,117,88,116,189,27,184,83,40,81,130,61,253,54,206,105,131,98,199,28,121,135,245,127,249,190,15,57,138,117,247,95,250,49,44,93,254,217,82,217,15,68,53,245,181,91,17,135,7,127,95,13,140,184,10,146,160,219,54,88,87,130,121,191,91,56,197,255,69,254,5,168,44,252,93,241,215,191,195,15,159,6,72,24,29,127,0,111,69,92,117,155,18,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("653008e5-9c4b-409b-9e2f-8dcc34086cdd"));
		}

		#endregion

	}

	#endregion

}

