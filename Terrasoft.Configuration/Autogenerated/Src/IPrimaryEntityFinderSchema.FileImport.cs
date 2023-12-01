namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IPrimaryEntityFinderSchema

	/// <exclude/>
	public class IPrimaryEntityFinderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IPrimaryEntityFinderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IPrimaryEntityFinderSchema(IPrimaryEntityFinderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8ef9a048-2ae1-43c0-b555-ed097820e198");
			Name = "IPrimaryEntityFinder";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,145,193,78,195,48,12,134,207,171,212,119,176,198,5,36,212,222,161,244,130,54,84,193,97,18,188,64,214,186,149,69,147,84,78,130,168,16,239,142,187,176,173,83,33,167,216,249,255,255,75,98,163,52,186,65,213,8,111,200,172,156,109,125,246,104,77,75,93,96,229,201,154,108,75,61,86,122,176,236,211,228,43,77,86,193,145,233,224,117,116,30,181,72,251,30,235,73,231,178,39,52,200,84,223,167,137,168,174,24,59,233,66,101,60,114,43,249,119,80,237,152,180,226,113,99,60,249,113,75,166,65,158,180,162,206,243,28,10,23,244,116,92,254,214,147,0,240,147,156,7,18,148,3,37,181,67,15,173,101,136,23,138,73,217,49,32,159,37,12,97,223,83,13,116,196,255,67,95,77,47,90,224,207,252,33,154,0,79,164,37,42,118,6,197,74,131,145,239,124,88,31,246,40,100,183,46,227,77,225,220,202,138,252,80,252,109,125,199,209,69,139,124,109,208,70,18,158,113,132,58,22,23,222,15,75,13,188,88,213,92,188,236,58,186,119,39,222,12,125,11,213,198,4,141,172,246,61,22,115,76,9,11,240,141,12,114,245,29,135,137,166,137,243,156,74,233,201,250,1,34,231,79,147,57,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8ef9a048-2ae1-43c0-b555-ed097820e198"));
		}

		#endregion

	}

	#endregion

}

