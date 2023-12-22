namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ISupportDefMailBoxSchema

	/// <exclude/>
	public class ISupportDefMailBoxSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ISupportDefMailBoxSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ISupportDefMailBoxSchema(ISupportDefMailBoxSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c365918f-f01b-41e0-998d-6395d5736989");
			Name = "ISupportDefMailBox";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("77fa8847-960e-4748-ad77-e37bb90e03a0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,93,141,193,10,131,48,12,134,207,10,190,67,142,219,197,62,192,196,195,54,24,59,236,228,94,160,74,42,5,219,74,146,130,50,246,238,107,25,142,97,8,4,254,124,249,226,181,67,158,245,128,240,68,34,205,193,72,125,9,222,216,49,146,22,27,124,85,190,170,178,152,99,63,217,1,172,23,36,147,233,123,23,231,57,144,92,209,60,180,157,206,97,73,84,38,11,165,20,52,28,157,211,180,182,91,112,67,1,254,94,128,75,60,244,97,1,67,193,1,175,44,152,6,138,88,63,214,63,131,218,43,26,66,137,228,185,237,118,158,186,81,219,42,179,44,148,68,249,227,225,120,74,193,187,42,83,255,215,7,154,36,224,19,244,0,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c365918f-f01b-41e0-998d-6395d5736989"));
		}

		#endregion

	}

	#endregion

}

