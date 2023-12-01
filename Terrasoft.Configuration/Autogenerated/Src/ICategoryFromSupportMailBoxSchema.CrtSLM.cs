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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,145,81,75,195,48,16,199,159,45,244,59,220,163,130,180,31,192,210,7,39,22,31,4,97,130,207,89,123,221,14,155,164,220,37,219,138,248,221,189,108,221,148,41,24,2,225,146,127,126,249,255,47,206,88,148,209,180,8,175,200,108,196,247,161,88,120,215,211,58,178,9,228,93,158,125,228,217,85,20,114,107,88,78,18,208,222,93,212,170,31,6,108,147,88,138,6,29,50,181,170,81,85,89,150,80,73,180,214,240,84,207,245,11,251,45,117,8,18,199,209,115,0,107,104,128,149,223,163,192,142,194,6,90,19,112,237,121,42,78,247,203,31,128,49,174,6,106,129,92,64,238,147,233,167,197,44,127,100,111,151,71,228,179,18,239,253,94,229,201,249,47,19,135,141,6,195,191,14,160,87,38,200,49,227,153,84,94,162,42,198,16,217,73,253,64,135,30,232,25,236,54,200,8,239,56,1,201,95,239,152,174,99,20,93,93,7,91,51,68,76,186,115,242,170,60,33,211,27,223,216,74,2,107,219,111,161,137,212,213,41,195,28,21,229,77,141,207,173,32,148,235,155,244,71,159,121,166,83,199,23,225,172,101,2,228,1,0,0 };
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

