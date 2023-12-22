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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,145,209,74,195,48,20,134,175,45,244,29,206,165,130,52,15,96,233,133,19,139,23,130,48,193,235,172,61,237,14,107,146,114,78,178,173,136,239,110,178,117,115,76,193,16,8,39,249,243,229,255,79,172,54,40,163,110,16,222,145,89,139,235,124,177,112,182,163,62,176,246,228,108,158,125,230,217,77,16,178,61,44,39,241,104,30,174,234,168,31,6,108,146,88,138,26,45,50,53,81,19,85,74,41,40,37,24,163,121,170,230,250,141,221,150,90,4,9,227,232,216,131,209,52,192,202,237,81,96,71,126,13,141,246,216,59,158,138,211,125,117,1,24,195,106,160,6,200,122,228,46,153,126,89,204,242,103,118,102,121,68,190,70,226,163,219,71,121,114,254,203,196,97,163,70,255,175,3,232,34,19,228,152,241,76,82,215,168,146,209,7,182,82,61,209,161,7,241,12,118,107,100,132,13,78,64,242,215,59,186,109,25,37,174,182,133,173,30,2,38,221,57,121,169,78,200,244,198,15,182,20,207,177,237,247,80,7,106,171,148,97,142,138,242,17,141,207,173,32,148,219,187,244,71,95,121,22,231,229,248,6,117,39,69,145,237,1,0,0 };
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

