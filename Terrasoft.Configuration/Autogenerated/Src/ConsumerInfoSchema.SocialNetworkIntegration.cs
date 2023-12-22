namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ConsumerInfoSchema

	/// <exclude/>
	public class ConsumerInfoSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ConsumerInfoSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ConsumerInfoSchema(ConsumerInfoSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("12a01026-e84b-495c-b275-01c91bdee21b");
			Name = "ConsumerInfo";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4e5fe717-963e-416c-b3c1-b2bb720a6449");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,144,65,75,196,48,16,133,207,45,244,63,132,221,139,94,250,3,118,241,180,94,100,81,150,173,120,17,15,179,113,90,130,77,82,102,38,66,93,252,239,78,83,21,149,21,193,156,38,239,189,249,194,75,0,143,60,128,69,115,139,68,192,177,149,122,19,67,235,186,68,32,46,134,186,137,214,65,95,149,199,170,44,18,187,208,153,102,100,65,95,239,83,16,231,177,110,144,52,224,94,114,124,93,149,154,91,18,118,122,49,155,30,152,87,70,129,156,60,210,85,104,99,246,239,47,65,64,85,33,176,242,160,194,144,14,189,179,198,78,249,31,241,226,152,87,62,153,59,138,3,146,56,84,240,46,175,205,126,102,94,163,63,32,157,221,104,43,115,97,22,79,56,46,206,39,254,199,3,44,52,53,216,226,104,166,62,69,209,161,172,243,192,239,195,235,239,52,70,75,40,39,129,77,182,254,193,124,70,98,109,117,18,122,55,123,127,80,151,24,30,231,175,201,247,89,253,46,170,246,245,188,1,85,80,222,119,244,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("12a01026-e84b-495c-b275-01c91bdee21b"));
		}

		#endregion

	}

	#endregion

}

