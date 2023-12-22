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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,145,221,74,195,64,16,133,175,13,228,29,134,122,163,32,201,189,173,129,162,22,122,33,20,218,23,24,187,147,116,49,187,19,102,39,45,85,124,119,243,211,148,180,162,115,55,103,103,62,206,217,1,143,142,66,133,91,130,13,137,96,224,92,147,103,246,185,45,106,65,181,236,147,21,139,98,249,70,33,96,65,11,34,19,71,95,113,116,83,7,235,11,88,31,131,146,155,198,81,163,220,10,21,205,2,192,210,43,73,222,48,31,97,121,177,29,230,91,173,177,180,159,36,221,70,154,166,48,11,181,115,40,199,236,212,175,132,247,214,80,0,71,186,99,19,32,103,129,3,203,7,28,172,238,160,234,120,205,99,15,4,60,19,147,1,152,142,136,85,253,94,218,45,216,193,209,127,134,110,218,88,215,158,224,84,173,60,55,141,29,46,205,47,19,202,224,233,0,106,29,149,214,83,114,230,84,40,232,160,253,227,167,137,65,165,133,176,155,100,107,69,81,104,251,100,150,118,35,217,159,27,27,158,100,175,222,92,79,143,109,141,3,15,250,158,173,129,115,184,203,204,119,47,45,183,241,10,131,165,7,184,144,54,124,63,237,81,223,253,97,201,155,254,182,113,212,41,227,250,1,178,161,199,7,66,2,0,0 };
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

