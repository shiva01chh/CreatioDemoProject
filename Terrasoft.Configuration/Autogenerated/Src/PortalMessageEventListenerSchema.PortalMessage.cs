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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,84,193,138,219,48,16,61,39,144,127,24,220,195,218,176,216,247,108,18,216,77,151,110,161,73,11,73,123,41,61,76,236,113,162,98,143,130,36,187,152,101,255,189,178,100,155,58,36,91,31,12,154,121,51,239,233,205,216,140,37,233,51,166,4,123,82,10,181,204,77,188,150,156,139,99,165,208,8,201,179,233,235,108,58,169,180,224,35,236,26,109,168,124,24,206,255,150,40,138,63,62,221,76,61,179,17,70,144,254,47,32,126,174,137,77,139,179,200,15,138,142,86,2,172,11,212,122,14,223,164,50,88,108,72,107,60,146,195,125,17,86,16,147,114,232,36,73,96,161,171,178,68,213,172,186,115,15,128,92,42,184,27,53,184,3,106,57,27,32,199,24,247,29,146,139,22,11,77,132,133,150,144,42,202,151,193,251,186,227,39,212,228,98,205,72,96,0,73,219,239,231,149,84,184,75,79,84,226,214,14,2,150,16,140,52,6,209,47,91,117,174,14,133,72,33,109,93,120,199,4,152,195,13,118,219,227,213,89,52,56,186,33,115,146,89,235,169,18,53,26,234,178,196,153,7,220,66,59,37,62,121,105,183,11,188,32,103,5,233,222,218,29,214,148,121,131,227,161,38,185,44,90,156,81,97,9,108,29,88,6,218,106,176,126,173,220,5,192,159,226,69,226,32,215,43,40,88,237,79,228,230,212,207,104,126,115,74,78,215,99,110,72,57,130,71,117,212,237,108,64,176,54,200,246,51,72,37,27,20,220,174,168,57,81,79,232,174,0,25,26,28,105,233,38,35,107,75,39,50,130,90,138,12,190,178,187,118,40,15,191,41,237,175,112,15,215,168,129,34,104,63,175,201,228,96,39,23,247,149,125,9,69,15,46,233,75,161,244,67,183,91,18,250,72,228,129,30,36,242,176,3,196,159,200,236,155,51,101,107,89,84,37,255,192,162,162,197,65,202,98,21,6,159,245,86,26,55,70,125,162,44,136,34,79,63,81,100,42,197,190,211,155,123,215,168,128,165,17,185,176,171,181,4,166,63,227,221,219,118,185,158,181,211,218,150,149,200,54,208,87,117,248,23,187,140,82,53,27,159,27,180,126,215,164,236,15,135,173,85,118,213,238,7,202,174,93,215,42,118,108,77,232,163,111,87,215,213,71,199,65,27,131,217,180,125,254,2,241,105,98,57,233,4,0,0 };
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

