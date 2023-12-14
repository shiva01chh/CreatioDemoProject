namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IPortalMessagesActualizerSchema

	/// <exclude/>
	public class IPortalMessagesActualizerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IPortalMessagesActualizerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IPortalMessagesActualizerSchema(IPortalMessagesActualizerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("33d6d3a2-74fe-4824-b31f-88dc01a91284");
			Name = "IPortalMessagesActualizer";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("32031062-b6bd-4fa4-a14f-d8d66f99305f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,145,221,106,194,64,16,133,175,13,228,29,6,123,211,66,73,238,171,13,72,91,193,139,130,160,47,48,117,39,113,105,118,39,204,78,20,91,250,238,205,143,17,181,216,185,155,179,51,31,231,236,128,71,71,161,194,13,193,154,68,48,112,174,201,11,251,220,22,181,160,90,246,201,146,69,177,124,167,16,176,160,57,145,137,163,239,56,26,213,193,250,2,86,135,160,228,38,113,212,40,119,66,69,179,0,176,240,74,146,55,204,39,88,92,108,135,217,70,107,44,237,23,73,183,145,166,41,76,67,237,28,202,33,59,246,75,225,157,53,20,192,145,110,217,4,200,89,96,207,242,9,123,171,91,168,58,94,243,216,3,1,79,196,100,0,166,103,196,170,254,40,237,6,236,224,232,63,67,163,54,214,181,39,56,86,43,207,76,99,135,75,243,199,132,50,120,218,131,90,71,165,245,148,156,56,21,10,58,104,255,248,121,108,80,105,46,236,198,217,74,81,20,218,62,153,166,221,72,118,115,99,205,227,236,205,155,235,233,115,91,231,129,7,125,199,214,192,41,220,101,230,251,215,150,219,120,133,193,210,35,92,72,107,126,152,244,168,159,254,176,228,77,127,219,56,234,148,182,126,1,9,119,55,58,58,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("33d6d3a2-74fe-4824-b31f-88dc01a91284"));
		}

		#endregion

	}

	#endregion

}

