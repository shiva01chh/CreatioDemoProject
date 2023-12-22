namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DataProviderResponseSchema

	/// <exclude/>
	public class DataProviderResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DataProviderResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DataProviderResponseSchema(DataProviderResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("128127f7-43f7-4cf4-9f1d-06f7c505c1c3");
			Name = "DataProviderResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("120fd877-7905-4e7f-9414-1956e0c20629");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,80,203,106,195,64,12,60,199,224,127,16,233,221,190,247,145,75,218,99,33,148,252,128,186,150,157,165,177,214,72,235,132,18,250,239,149,119,237,96,74,247,176,160,145,52,154,25,198,158,116,64,71,112,36,17,212,208,198,106,31,184,245,221,40,24,125,224,234,40,232,190,60,119,101,113,43,139,178,216,60,8,117,134,195,254,140,170,143,240,138,17,15,18,46,190,33,249,48,170,192,74,105,174,174,107,120,214,177,239,81,190,119,115,189,12,128,155,150,161,13,98,35,100,165,80,251,178,93,46,173,41,183,245,14,144,27,240,124,34,241,145,154,188,74,90,45,39,234,213,141,97,252,60,123,55,179,255,175,108,147,93,220,109,216,196,64,18,61,153,151,67,90,207,253,191,242,19,96,201,68,244,172,96,89,153,118,139,78,177,35,184,158,136,97,162,73,137,129,87,24,89,71,231,172,93,221,185,214,58,23,161,26,197,252,194,219,196,246,62,147,221,160,163,248,4,58,125,63,179,86,226,38,203,77,117,70,215,96,66,214,239,23,226,194,125,13,215,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("128127f7-43f7-4cf4-9f1d-06f7c505c1c3"));
		}

		#endregion

	}

	#endregion

}

