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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,101,80,177,78,195,48,16,157,27,41,255,112,234,4,75,188,131,233,82,33,212,13,169,153,216,220,112,9,150,240,57,58,159,91,25,196,191,99,183,73,168,138,229,193,247,238,189,243,123,71,198,97,24,77,135,208,34,179,9,190,151,102,235,169,183,67,100,35,214,83,93,125,215,213,42,6,75,3,236,83,16,116,143,75,189,245,140,205,51,137,21,139,33,195,185,161,148,2,29,162,115,134,211,102,170,95,217,31,237,59,6,16,235,16,190,60,33,28,18,12,246,136,4,193,71,238,176,153,149,234,70,170,37,141,56,26,54,14,40,59,125,90,183,231,239,210,122,211,46,179,166,17,90,45,220,162,30,227,225,211,118,96,73,144,251,146,111,87,20,111,89,48,217,97,61,205,42,236,213,233,3,57,239,224,130,192,3,92,30,185,83,210,255,75,117,6,94,80,174,34,53,11,79,221,18,53,163,68,166,240,231,57,155,157,177,66,154,157,237,168,247,101,236,92,223,221,151,93,255,212,85,190,215,231,23,182,143,180,201,181,1,0,0 };
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

