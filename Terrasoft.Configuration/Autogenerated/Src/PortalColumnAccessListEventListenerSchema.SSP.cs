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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,229,83,77,139,219,48,16,61,103,97,255,195,224,61,108,2,69,190,103,147,64,234,46,244,208,143,5,111,79,165,135,137,60,118,84,228,81,144,228,148,176,244,191,87,150,226,101,19,156,118,233,169,80,159,172,249,120,243,230,61,137,177,37,183,67,73,240,72,214,162,51,181,23,133,225,90,53,157,69,175,12,95,95,61,93,95,77,58,167,184,57,41,177,116,119,33,46,238,217,43,175,200,253,177,64,220,239,137,253,229,186,210,167,49,33,127,99,169,9,108,160,208,232,220,28,30,140,245,168,11,163,187,150,215,82,146,115,31,148,243,17,174,255,33,38,27,219,242,60,135,133,235,218,22,237,97,117,60,15,5,80,27,11,183,227,72,183,64,61,199,3,80,100,40,6,168,252,12,107,225,136,80,59,3,210,82,189,204,126,191,167,120,139,142,98,236,112,194,52,131,188,199,251,58,146,154,150,114,75,45,126,10,46,193,18,178,113,178,217,236,91,104,223,117,27,173,36,200,94,160,215,232,3,115,184,192,39,128,61,69,245,158,85,255,72,126,107,170,94,247,56,36,37,207,181,141,129,247,200,149,38,55,200,87,226,158,170,36,162,120,238,201,207,155,22,59,180,216,2,135,45,151,153,35,174,130,38,171,72,9,210,73,44,242,88,50,222,65,217,234,113,75,209,139,193,135,249,69,39,34,175,117,237,201,198,1,107,219,184,94,127,80,236,60,114,120,7,210,176,71,197,253,117,244,91,26,6,198,21,160,66,143,39,92,142,162,155,125,24,167,42,130,189,81,21,124,230,184,246,212,108,190,147,28,86,120,3,99,163,129,102,208,191,175,201,100,19,188,16,67,231,208,66,179,187,152,76,173,176,123,225,106,184,14,211,20,158,165,234,84,89,150,15,37,201,206,246,158,114,163,152,68,161,9,109,129,225,30,85,107,173,205,15,170,18,128,155,190,132,19,95,28,217,240,240,57,48,14,142,167,185,63,95,111,244,59,210,228,255,71,171,143,139,255,149,217,67,239,191,101,247,77,192,79,239,62,158,83,244,52,24,99,225,251,5,32,246,16,54,62,6,0,0 };
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

