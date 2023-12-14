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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,229,83,77,139,219,48,16,61,103,97,255,195,224,61,108,2,69,190,103,147,64,234,46,244,208,143,5,111,79,165,135,137,60,118,84,100,41,72,114,74,88,250,223,171,143,104,217,4,167,93,122,42,212,39,107,62,222,188,121,79,82,216,147,221,33,39,120,36,99,208,234,214,177,74,171,86,116,131,65,39,180,186,190,122,186,190,154,12,86,168,238,164,196,208,221,133,56,187,87,78,56,65,246,143,5,236,126,79,202,93,174,171,93,26,227,243,55,134,58,207,6,42,137,214,206,225,65,27,135,178,210,114,232,213,154,115,178,246,131,176,46,194,133,31,82,100,98,91,89,150,176,176,67,223,163,57,172,142,231,92,0,173,54,112,59,142,116,11,20,56,30,128,34,67,150,161,202,51,172,133,37,66,105,53,112,67,237,178,248,253,158,236,45,90,138,177,195,9,211,2,202,128,247,117,36,53,173,249,150,122,252,228,93,130,37,20,227,100,139,217,55,223,190,27,54,82,112,224,65,160,215,232,3,115,184,192,199,131,61,69,245,158,85,255,72,110,171,155,160,123,28,146,146,231,218,198,192,123,84,141,36,155,229,171,113,79,77,18,145,61,247,148,231,77,139,29,26,236,65,249,45,151,133,37,213,120,77,86,145,18,164,19,91,148,177,100,188,131,138,213,227,150,162,23,217,135,249,69,39,34,175,117,235,200,196,1,107,211,217,160,63,8,101,29,42,255,14,184,86,14,133,10,215,209,109,41,15,140,43,64,131,14,79,184,28,69,215,123,63,78,52,4,123,45,26,248,172,226,218,83,189,249,78,60,175,240,6,198,70,3,205,32,188,175,201,100,227,189,96,185,51,183,208,236,46,38,83,43,236,94,184,234,175,195,52,133,103,169,58,85,214,245,67,77,124,48,193,83,213,9,69,172,146,132,166,66,127,143,154,181,148,250,7,53,9,192,78,95,194,177,47,150,140,127,248,202,51,246,142,167,185,63,95,111,244,59,146,228,254,71,171,143,139,255,149,217,185,247,223,178,251,198,227,167,119,31,207,41,122,26,140,177,240,253,2,173,54,143,9,63,6,0,0 };
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

