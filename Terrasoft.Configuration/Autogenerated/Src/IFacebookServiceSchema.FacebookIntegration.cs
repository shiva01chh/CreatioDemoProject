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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,229,88,77,79,227,48,16,61,23,137,255,96,149,75,145,80,126,0,136,3,109,233,170,72,45,136,84,226,128,56,184,206,52,181,154,216,193,30,119,183,66,252,119,166,118,83,37,124,100,181,199,77,114,137,242,252,102,50,239,37,227,216,81,60,7,91,112,1,108,1,198,112,171,87,24,141,180,90,201,212,25,142,82,171,40,214,66,242,236,244,228,237,244,164,231,172,84,41,139,119,22,33,143,98,48,91,41,96,166,19,200,174,154,6,163,27,129,114,235,179,53,243,158,96,73,4,162,156,25,72,137,205,166,10,193,172,168,186,75,54,157,208,105,169,245,230,16,225,121,207,135,11,170,24,13,23,56,152,147,28,118,205,250,159,200,253,243,23,98,23,110,153,73,193,100,153,244,155,156,189,55,159,247,88,192,12,112,173,19,123,201,30,124,108,24,124,190,47,32,152,83,222,247,197,195,84,254,84,109,245,6,6,33,108,95,200,195,125,188,232,95,176,71,120,117,96,113,162,77,206,145,112,162,206,192,90,158,66,128,162,59,171,213,5,27,234,100,23,227,46,131,26,229,136,70,79,134,23,5,36,251,124,182,208,202,66,115,66,175,186,87,123,156,7,165,101,60,139,1,111,132,160,200,5,213,173,6,225,97,207,1,127,107,179,57,114,125,237,204,132,243,249,213,127,233,66,69,229,81,252,175,46,139,159,72,149,116,67,125,99,3,140,12,112,132,32,158,236,208,78,97,139,173,168,233,156,170,149,174,246,194,151,193,78,26,177,239,139,46,57,209,216,29,99,200,160,59,221,209,60,81,172,65,108,186,226,196,144,91,90,84,229,57,87,9,133,185,12,41,122,95,229,200,25,3,170,35,95,205,175,38,220,254,1,225,176,4,91,44,61,6,110,196,186,174,58,96,45,22,93,238,6,110,21,74,148,96,171,223,198,57,109,80,236,152,35,111,177,254,31,223,247,33,71,177,110,255,75,63,134,165,75,191,91,42,251,129,78,77,125,205,86,116,195,131,191,175,6,70,92,5,73,208,110,27,172,203,193,124,222,45,84,241,127,145,127,6,42,9,127,87,252,245,123,248,225,83,3,9,171,30,31,26,31,145,136,164,18,0,0 };
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

