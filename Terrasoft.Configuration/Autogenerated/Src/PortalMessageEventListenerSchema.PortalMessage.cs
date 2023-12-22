namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: PortalMessageEventListenerSchema

	/// <exclude/>
	public class PortalMessageEventListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public PortalMessageEventListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public PortalMessageEventListenerSchema(PortalMessageEventListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7651591f-a66d-4dfa-8f74-cd990454a314");
			Name = "PortalMessageEventListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c85d2d65-6230-4aeb-9934-bfac9785d42f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,84,193,106,219,64,16,61,219,224,127,24,212,67,36,8,210,221,177,13,137,19,154,66,237,22,236,244,82,122,24,75,35,123,131,52,107,118,87,42,34,228,223,187,218,149,76,100,236,84,7,193,206,188,153,247,246,205,72,140,37,233,35,166,4,91,82,10,181,204,77,188,148,156,139,125,165,208,8,201,147,241,219,100,60,170,180,224,61,108,26,109,168,188,59,157,63,150,40,138,31,31,174,166,158,216,8,35,72,255,23,16,63,213,196,166,197,89,228,23,69,123,43,1,150,5,106,61,133,159,82,25,44,86,164,53,238,201,225,190,11,43,136,73,57,116,146,36,48,211,85,89,162,106,22,221,185,7,64,46,21,220,12,26,220,0,181,156,13,144,99,140,251,14,201,89,139,153,38,194,66,75,72,21,229,243,224,115,221,241,3,106,114,177,102,32,48,128,164,237,247,251,66,42,220,164,7,42,113,109,7,1,115,8,6,26,131,232,143,173,58,86,187,66,164,144,182,46,124,98,2,76,225,10,187,237,241,230,44,58,57,186,34,115,144,89,235,169,18,53,26,234,178,196,153,7,92,67,59,37,62,121,110,183,11,60,35,103,5,233,222,218,13,214,148,121,131,227,83,77,114,94,52,59,162,194,18,216,58,48,15,180,213,96,253,90,184,11,128,63,197,179,196,65,46,87,80,176,216,30,200,205,169,159,209,244,234,148,156,174,251,220,144,114,4,247,106,175,219,217,128,96,109,144,237,103,144,74,54,40,184,93,81,115,160,158,208,93,1,50,52,56,208,210,77,70,214,150,78,100,4,181,20,25,252,96,119,237,80,238,94,41,237,175,112,11,151,168,129,34,104,63,175,209,104,103,39,23,247,149,125,9,69,119,46,233,75,161,244,67,183,91,18,250,72,228,129,30,36,242,176,3,196,95,201,108,155,35,101,75,89,84,37,255,194,162,162,217,78,202,98,17,6,223,244,90,26,55,70,125,160,44,136,34,79,63,82,100,42,197,190,211,187,123,215,168,128,165,17,185,176,171,53,7,166,191,195,221,91,119,185,158,181,211,218,150,149,200,54,208,87,117,248,103,187,140,82,53,43,159,59,105,125,209,164,236,15,135,173,85,118,213,110,79,148,93,187,174,85,236,216,154,208,71,223,47,174,171,143,14,131,54,6,147,241,199,231,31,74,170,75,7,241,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7651591f-a66d-4dfa-8f74-cd990454a314"));
		}

		#endregion

	}

	#endregion

}

