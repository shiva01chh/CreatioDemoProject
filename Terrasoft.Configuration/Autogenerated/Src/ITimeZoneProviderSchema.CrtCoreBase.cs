namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ITimeZoneProviderSchema

	/// <exclude/>
	public class ITimeZoneProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ITimeZoneProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ITimeZoneProviderSchema(ITimeZoneProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("dfa2b430-c6c6-4cf0-9146-f9cae961564f");
			Name = "ITimeZoneProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b11d550e-0087-4f53-ae17-fb00d41102cf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,101,80,177,78,195,48,16,157,27,41,255,112,234,4,75,188,23,211,165,66,168,27,18,153,216,220,112,9,150,234,115,116,62,183,50,136,127,199,110,147,128,138,229,193,247,238,189,243,123,71,198,97,24,77,135,208,34,179,9,190,151,102,231,169,183,67,100,35,214,83,93,125,213,213,42,6,75,3,188,166,32,232,30,150,122,231,25,155,39,18,43,22,67,134,115,67,41,5,58,68,231,12,167,237,84,191,176,63,217,119,12,32,214,33,124,122,66,56,36,24,236,9,9,130,143,220,97,51,43,213,141,84,75,26,113,52,108,28,80,118,250,184,110,47,223,165,245,182,93,102,77,35,180,90,184,69,61,198,195,209,118,96,73,144,251,146,111,95,20,111,89,48,217,97,61,205,42,236,213,249,3,57,239,224,138,192,6,174,143,220,41,233,255,165,186,0,207,40,127,34,53,11,79,221,18,53,163,68,166,240,235,57,155,157,177,66,154,157,237,169,247,101,236,92,223,221,151,93,127,215,85,190,229,252,0,86,58,4,142,173,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("dfa2b430-c6c6-4cf0-9146-f9cae961564f"));
		}

		#endregion

	}

	#endregion

}

