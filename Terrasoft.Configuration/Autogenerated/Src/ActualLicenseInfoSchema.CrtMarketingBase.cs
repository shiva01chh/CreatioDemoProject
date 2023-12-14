namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ActualLicenseInfoSchema

	/// <exclude/>
	public class ActualLicenseInfoSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ActualLicenseInfoSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ActualLicenseInfoSchema(ActualLicenseInfoSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d8f2556a-7b31-4323-98aa-de2f37e95af2");
			Name = "ActualLicenseInfo";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c92d8fca-4a0d-4385-86d2-4f5717aa816e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,146,193,106,195,48,12,134,207,11,244,29,4,189,55,247,109,12,74,118,25,244,144,67,95,64,113,148,76,144,216,193,150,11,91,217,187,79,177,151,208,110,99,108,243,193,32,233,255,127,62,44,91,28,41,76,104,8,142,228,61,6,215,201,174,114,182,227,62,122,20,118,118,83,156,55,197,166,184,217,122,234,181,132,106,192,16,110,97,111,36,226,192,175,212,170,186,229,172,84,89,89,150,112,31,226,56,162,127,121,248,168,147,5,140,179,130,108,3,176,237,156,31,83,56,96,227,162,0,26,225,19,101,133,17,24,216,144,13,180,91,226,202,139,188,41,54,58,6,147,34,51,196,33,203,159,52,86,5,153,118,197,173,189,155,200,11,147,50,215,201,155,231,159,57,83,227,248,76,96,227,216,144,7,215,193,132,220,46,76,51,53,136,142,47,216,190,194,45,116,108,5,106,117,87,217,92,185,168,141,51,244,36,119,16,230,235,237,215,16,215,79,243,119,140,125,242,255,27,164,69,161,25,67,159,123,221,11,156,112,136,20,102,180,244,5,210,38,127,38,9,226,217,246,235,167,73,142,199,57,250,27,150,45,217,54,47,47,213,185,123,221,212,222,124,222,1,87,233,229,215,188,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d8f2556a-7b31-4323-98aa-de2f37e95af2"));
		}

		#endregion

	}

	#endregion

}

