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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,145,193,78,195,48,12,134,207,171,212,119,176,198,5,36,212,222,161,244,130,54,84,193,97,18,188,64,214,186,149,69,147,84,78,138,168,16,239,142,179,176,173,83,33,167,216,249,255,255,75,98,163,52,186,65,213,8,111,200,172,156,109,125,246,104,77,75,221,200,202,147,53,217,150,122,172,244,96,217,167,201,87,154,172,70,71,166,131,215,201,121,212,34,237,123,172,131,206,101,79,104,144,169,190,79,19,81,93,49,118,210,133,202,120,228,86,242,239,160,218,49,105,197,211,198,120,242,211,150,76,131,28,180,162,206,243,28,10,55,234,112,92,254,214,65,0,248,73,206,3,9,202,129,146,218,161,135,214,50,196,11,197,164,236,24,144,207,18,134,113,223,83,13,116,196,255,67,95,133,23,45,240,103,254,16,77,128,39,210,18,21,59,131,98,165,193,200,119,62,172,15,123,20,178,91,151,241,166,112,110,101,69,126,40,254,182,190,227,228,162,69,190,118,212,70,18,158,113,130,58,22,23,222,15,75,13,188,88,213,92,188,236,58,186,119,39,222,12,125,11,213,198,140,26,89,237,123,44,230,152,18,22,224,27,25,228,234,59,14,19,77,19,231,25,74,233,133,245,3,144,8,36,231,58,2,0,0 };
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

