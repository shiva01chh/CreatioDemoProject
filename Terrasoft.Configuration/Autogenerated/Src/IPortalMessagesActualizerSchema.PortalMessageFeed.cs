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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,145,193,106,195,48,12,134,207,13,228,29,68,118,217,96,36,247,181,11,148,109,133,30,6,133,246,5,180,90,73,205,98,43,200,78,67,55,246,238,115,146,166,180,29,157,110,250,45,125,252,191,5,22,13,185,26,183,4,27,18,65,199,133,79,95,216,22,186,108,4,189,102,155,174,88,60,86,239,228,28,150,180,32,82,113,244,29,71,147,198,105,91,194,250,224,60,153,105,28,5,229,78,168,12,11,0,75,235,73,138,192,124,130,229,197,182,155,111,125,131,149,254,34,233,55,178,44,131,153,107,140,65,57,228,199,126,37,188,215,138,28,24,242,59,86,14,10,22,104,89,62,161,213,126,7,117,207,11,143,3,16,240,68,76,71,96,118,70,172,155,143,74,111,65,143,142,254,51,52,233,98,93,123,130,99,117,242,92,5,59,92,169,63,38,60,131,165,22,188,54,84,105,75,233,137,83,163,160,129,238,143,159,19,133,158,22,194,38,201,215,30,197,67,215,167,179,172,31,201,111,110,108,56,201,223,172,186,158,62,183,117,30,120,212,247,172,21,156,194,93,102,190,127,237,184,193,43,140,150,30,225,66,218,240,195,116,64,253,12,135,37,171,134,219,198,81,175,132,250,5,77,183,76,141,57,2,0,0 };
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

