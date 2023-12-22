namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ICampaignJobDispatcherSchema

	/// <exclude/>
	public class ICampaignJobDispatcherSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ICampaignJobDispatcherSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ICampaignJobDispatcherSchema(ICampaignJobDispatcherSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("bc8d4fc1-fb96-4b0b-924c-b75865ecfbef");
			Name = "ICampaignJobDispatcher";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,229,85,61,111,219,48,16,157,29,32,255,225,160,14,109,129,66,218,227,216,139,131,20,42,208,34,77,220,185,160,196,147,196,64,36,85,126,196,117,141,252,247,158,40,75,182,236,4,245,96,116,137,54,30,143,239,221,123,188,163,20,147,104,27,150,35,44,209,24,102,117,225,226,133,86,133,40,189,97,78,104,117,121,177,185,188,152,120,43,84,9,15,107,235,80,78,135,245,66,27,92,48,217,48,81,170,135,188,66,201,96,54,194,49,24,247,251,241,56,113,7,242,221,51,227,254,208,154,34,239,12,150,196,9,169,114,104,10,170,234,10,210,254,220,23,157,221,8,42,213,209,121,19,178,147,36,129,107,235,165,100,102,61,223,174,239,177,49,104,81,57,11,18,93,165,185,133,66,27,120,212,153,125,15,146,41,86,162,164,221,184,63,158,236,157,111,124,86,139,28,68,79,254,42,247,100,19,248,135,114,239,140,110,208,56,129,246,10,238,2,72,183,127,88,96,8,164,202,58,166,8,93,23,180,137,8,185,193,98,22,165,173,47,220,215,104,162,100,14,43,225,42,80,116,55,251,41,63,243,61,11,67,234,55,202,104,211,73,33,199,130,249,58,8,59,86,54,217,161,195,226,16,4,54,80,162,155,194,51,108,85,161,226,157,176,177,202,175,157,159,39,72,236,161,45,40,252,237,90,243,195,37,184,10,193,54,152,139,66,32,135,94,204,43,21,135,72,195,12,147,193,135,89,100,67,223,68,243,101,53,50,229,184,7,131,33,217,35,230,46,176,174,68,94,1,93,32,52,53,83,54,190,78,2,232,203,28,133,48,184,20,18,187,9,136,230,183,180,6,71,1,200,67,164,239,165,17,202,147,22,124,144,76,68,31,94,24,139,174,248,79,131,249,183,35,34,24,243,126,156,158,224,237,57,173,205,71,197,254,72,121,231,178,87,226,151,71,16,156,6,166,5,54,109,203,246,185,91,73,52,45,93,59,255,15,99,63,123,177,19,55,20,123,14,87,239,81,234,39,234,87,187,101,227,225,197,56,163,181,167,121,218,6,221,26,86,85,219,179,237,221,218,74,251,154,67,134,52,223,53,58,228,199,6,117,165,147,61,118,236,79,202,255,161,216,14,83,250,22,6,116,167,247,156,35,122,240,86,62,119,127,177,81,48,196,246,191,191,237,26,152,236,115,7,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("bc8d4fc1-fb96-4b0b-924c-b75865ecfbef"));
		}

		#endregion

	}

	#endregion

}

