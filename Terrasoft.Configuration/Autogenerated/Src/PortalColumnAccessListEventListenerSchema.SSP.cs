namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: PortalColumnAccessListEventListenerSchema

	/// <exclude/>
	public class PortalColumnAccessListEventListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public PortalColumnAccessListEventListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public PortalColumnAccessListEventListenerSchema(PortalColumnAccessListEventListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("67f28e51-44e9-4af8-8454-8ad240db235e");
			Name = "PortalColumnAccessListEventListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d7352345-17a4-46e8-b32e-306ac0453d7a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,229,83,77,139,219,48,16,61,103,97,255,195,224,61,108,2,69,190,103,147,64,154,46,244,208,143,5,111,79,165,135,137,60,118,84,228,81,144,228,148,176,244,191,87,150,226,37,9,78,187,236,105,161,62,89,243,241,230,205,123,18,99,67,110,139,146,224,145,172,69,103,42,47,86,134,43,85,183,22,189,50,124,125,245,116,125,53,106,157,226,250,164,196,210,221,133,184,184,103,175,188,34,247,207,2,113,191,35,246,151,235,10,159,198,132,252,141,165,58,176,129,149,70,231,166,240,96,172,71,189,50,186,109,120,41,37,57,247,73,57,31,225,186,31,98,178,177,45,207,115,152,185,182,105,208,238,23,135,115,95,0,149,177,112,59,140,116,11,212,113,220,3,69,134,162,135,202,207,176,102,142,8,181,51,32,45,85,243,236,239,123,138,247,232,40,198,246,39,76,51,200,59,188,239,3,169,113,33,55,212,224,151,224,18,204,33,27,38,155,77,126,132,246,109,187,214,74,130,236,4,122,137,62,48,133,11,124,2,216,83,84,239,89,245,207,228,55,166,236,116,143,67,82,242,92,219,24,248,136,92,106,114,189,124,5,238,168,76,34,138,231,158,252,188,105,182,69,139,13,112,216,114,158,57,226,50,104,178,136,148,32,157,196,44,143,37,195,29,148,45,30,55,20,189,232,125,152,94,116,34,242,90,86,158,108,28,176,180,181,235,244,7,197,206,35,135,119,32,13,123,84,220,93,71,191,161,126,96,92,1,74,244,120,194,229,32,186,217,133,113,170,36,216,25,85,194,87,142,107,143,205,250,39,201,126,133,119,48,52,26,104,2,221,251,26,141,214,193,11,209,119,246,45,52,185,139,201,212,10,219,35,87,195,117,24,167,240,36,85,167,202,162,120,40,72,182,182,243,148,107,197,36,86,154,208,174,48,220,163,114,169,181,249,69,101,2,112,227,99,56,241,205,145,13,15,159,3,227,224,120,154,251,251,229,70,127,32,77,254,127,180,250,176,248,171,204,238,123,223,150,221,55,1,63,189,251,120,78,209,211,96,140,29,127,127,0,71,101,164,219,71,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("67f28e51-44e9-4af8-8454-8ad240db235e"));
		}

		#endregion

	}

	#endregion

}

