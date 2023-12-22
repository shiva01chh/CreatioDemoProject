namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IFileCacheManagerSchema

	/// <exclude/>
	public class IFileCacheManagerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IFileCacheManagerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IFileCacheManagerSchema(IFileCacheManagerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0e5e91d3-bc10-4f37-b040-4d4f5d89326c");
			Name = "IFileCacheManager";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("3c624d29-361c-47f2-ac8f-7824eb3cde6f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,145,193,106,195,48,12,134,239,133,190,131,96,151,21,66,30,96,57,109,101,45,134,149,13,186,176,179,19,43,169,33,177,131,236,28,186,176,119,159,237,208,197,89,151,78,135,96,73,127,244,203,159,21,111,209,116,188,68,120,71,34,110,116,101,211,173,86,149,172,123,226,86,106,149,238,100,131,91,94,158,240,192,21,175,145,214,171,97,189,2,23,189,145,170,134,227,217,88,108,179,235,82,202,94,103,213,91,243,243,174,209,92,44,202,9,111,180,210,103,101,165,149,104,22,52,126,126,250,88,24,75,188,244,134,94,55,42,239,8,107,87,0,166,44,82,229,24,60,0,187,190,173,87,142,223,174,47,26,89,130,188,200,151,212,195,197,32,54,121,35,221,33,249,61,227,110,161,117,3,204,28,251,178,68,99,152,114,23,225,141,252,12,100,96,128,26,109,6,95,179,113,168,196,56,241,47,147,3,218,147,22,51,7,54,241,101,170,210,240,226,14,59,210,109,88,251,62,55,72,238,57,20,6,52,142,93,156,38,16,208,158,143,78,217,114,192,40,73,96,114,240,177,239,165,128,202,57,49,145,192,147,84,156,206,31,36,29,39,40,162,100,147,77,127,253,98,176,71,235,48,132,217,97,51,241,223,106,193,49,94,41,103,98,147,45,161,242,249,15,199,184,17,138,113,124,3,165,53,147,248,17,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0e5e91d3-bc10-4f37-b040-4d4f5d89326c"));
		}

		#endregion

	}

	#endregion

}

