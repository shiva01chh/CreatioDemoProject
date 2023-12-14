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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,229,88,77,79,227,48,16,61,23,137,255,96,149,75,145,80,126,0,136,3,109,233,170,72,45,136,84,226,128,56,184,206,52,181,154,216,193,30,119,183,66,252,119,38,113,83,53,124,100,181,199,141,115,137,242,252,102,50,239,37,227,216,81,60,7,91,112,1,108,1,198,112,171,87,24,141,180,90,201,212,25,142,82,171,40,214,66,242,236,244,228,237,244,164,231,172,84,41,139,119,22,33,143,98,48,91,41,96,166,19,200,174,218,6,163,27,129,114,91,101,107,231,61,193,146,8,68,57,51,144,18,155,77,21,130,89,81,117,151,108,58,161,211,82,235,205,62,162,226,61,239,47,168,98,52,92,224,96,78,114,216,53,235,127,34,247,207,95,136,93,184,101,38,5,147,117,210,111,114,246,222,170,188,135,2,102,128,107,157,216,75,246,80,197,250,193,231,251,2,188,57,245,125,95,42,152,202,159,170,173,222,192,192,135,149,133,60,220,199,139,254,5,123,132,87,7,22,39,218,228,28,9,39,234,12,172,229,41,120,40,186,179,90,93,176,161,78,118,49,238,50,104,80,14,104,244,100,120,81,64,82,230,179,133,86,22,218,19,86,170,123,141,199,185,87,90,199,179,24,240,70,8,138,92,80,221,106,224,31,246,28,240,183,54,155,3,183,170,157,25,127,62,191,250,47,93,56,82,121,16,255,43,100,241,19,169,146,48,212,183,54,192,200,0,71,240,226,201,14,237,20,118,216,138,134,206,169,90,233,227,94,248,50,24,164,17,101,95,132,228,68,107,119,140,33,131,112,186,163,125,162,88,131,216,132,226,196,144,91,90,84,229,57,87,9,133,185,12,41,186,172,114,228,140,1,21,200,87,243,171,9,183,127,64,56,172,193,14,75,143,129,27,177,110,170,246,88,135,69,215,187,129,91,133,18,37,216,227,111,227,156,54,40,118,204,145,119,88,255,143,239,251,144,163,88,119,255,165,31,195,210,165,223,45,149,171,129,160,166,190,118,43,194,240,224,239,171,129,17,87,94,18,116,219,6,235,114,48,159,119,11,199,248,191,200,63,3,149,248,191,43,213,245,187,255,225,211,0,9,43,143,15,31,38,175,239,156,18,0,0 };
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

