namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IMLServiceConfigSchema

	/// <exclude/>
	public class IMLServiceConfigSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IMLServiceConfigSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IMLServiceConfigSchema(IMLServiceConfigSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8a29f714-7093-46e2-bff1-7dfd2aecc270");
			Name = "IMLServiceConfig";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b54cb82a-9c72-40e4-855f-14a0ef44684e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,81,75,106,195,48,16,93,199,224,59,12,222,52,133,98,29,160,182,55,89,180,6,27,10,201,5,20,101,148,136,216,146,209,72,129,80,114,247,74,182,251,113,104,171,141,208,104,222,103,222,104,222,35,13,92,32,236,208,90,78,70,186,124,99,180,84,71,111,185,83,70,231,109,147,38,239,105,178,242,164,244,17,182,87,114,216,63,167,73,168,12,126,223,41,1,74,59,180,50,82,212,109,179,69,123,81,2,39,138,208,19,145,43,198,24,20,228,251,158,219,107,245,89,216,156,80,156,65,73,160,9,2,98,150,197,3,72,99,129,76,119,137,138,238,132,112,84,23,212,129,2,67,151,69,89,102,109,243,102,205,190,195,126,119,29,48,99,85,254,37,195,238,117,138,129,91,222,131,14,131,150,217,240,141,170,15,89,53,147,128,11,239,188,96,99,231,239,64,17,221,238,44,87,58,120,202,170,90,66,33,42,103,61,22,76,84,48,254,82,28,70,185,7,186,159,196,205,176,133,194,222,152,14,106,90,228,21,17,235,23,175,14,176,240,249,4,99,243,194,2,148,32,121,71,248,56,173,226,159,136,71,91,33,68,139,193,89,216,23,106,66,112,6,124,184,218,6,102,3,127,4,56,10,191,114,106,38,220,58,202,173,110,105,114,131,52,249,121,62,0,185,125,48,106,71,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8a29f714-7093-46e2-bff1-7dfd2aecc270"));
		}

		#endregion

	}

	#endregion

}

