namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ICategoryFromSupportMailBoxSchema

	/// <exclude/>
	public class ICategoryFromSupportMailBoxSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ICategoryFromSupportMailBoxSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ICategoryFromSupportMailBoxSchema(ICategoryFromSupportMailBoxSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f9f6082f-e4c2-4b11-b02e-75f27d626477");
			Name = "ICategoryFromSupportMailBox";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b11d550e-0087-4f53-ae17-fb00d41102cf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,145,209,74,195,48,20,134,175,45,244,29,206,165,130,52,15,176,210,11,39,22,47,132,193,4,175,179,246,180,59,216,36,229,156,100,91,17,223,221,100,235,166,76,193,16,8,39,249,243,229,255,79,172,54,40,163,110,16,94,145,89,139,235,124,177,116,182,163,62,176,246,228,108,158,125,228,217,77,16,178,61,172,39,241,104,22,87,117,212,15,3,54,73,44,69,141,22,153,154,168,137,42,165,20,148,18,140,209,60,85,115,189,98,183,163,22,65,194,56,58,246,96,52,13,176,113,7,20,216,147,223,66,163,61,246,142,167,226,124,95,253,0,140,97,51,80,3,100,61,114,151,76,63,47,103,249,19,59,179,62,33,95,34,241,193,29,162,60,57,255,101,226,184,81,163,255,215,1,116,145,9,114,202,120,33,169,107,84,201,232,3,91,169,30,233,216,131,120,6,251,45,50,194,59,78,64,242,215,59,186,109,25,37,174,182,133,157,30,2,38,221,37,121,169,206,200,244,198,55,182,20,207,177,237,247,80,7,106,171,148,97,142,138,242,22,141,207,173,32,148,219,187,244,71,159,121,22,103,26,95,209,177,216,229,229,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f9f6082f-e4c2-4b11-b02e-75f27d626477"));
		}

		#endregion

	}

	#endregion

}

