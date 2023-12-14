namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EntityActivitiesOwnerInfoSchema

	/// <exclude/>
	public class EntityActivitiesOwnerInfoSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EntityActivitiesOwnerInfoSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EntityActivitiesOwnerInfoSchema(EntityActivitiesOwnerInfoSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f495a412-7027-454b-a334-1948a1100b0a");
			Name = "EntityActivitiesOwnerInfo";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,146,95,107,131,48,20,197,159,21,252,14,23,250,174,239,237,24,140,50,134,47,109,193,125,129,44,94,109,192,36,146,27,39,34,251,238,203,159,214,201,24,221,58,31,132,156,28,207,249,229,26,197,36,82,207,56,194,43,26,195,72,55,54,223,107,213,136,118,48,204,10,173,178,116,206,210,100,32,161,90,168,38,178,40,119,89,234,148,141,193,214,109,195,190,99,68,91,120,86,86,216,233,137,91,241,46,172,64,58,142,10,77,169,26,29,204,69,81,192,3,13,82,50,51,61,94,214,149,213,6,9,132,243,24,25,170,64,33,71,34,231,1,171,129,159,153,106,17,180,15,2,221,0,139,217,83,126,205,43,86,129,253,240,214,9,14,220,195,220,98,73,230,192,179,208,159,140,238,209,120,211,22,78,33,35,238,127,7,14,66,89,163,75,110,68,228,193,208,146,47,238,53,206,149,231,101,16,245,5,167,172,97,134,22,237,14,200,191,62,126,233,105,60,121,232,209,93,189,156,61,78,227,15,157,199,174,142,167,254,111,171,194,241,254,214,3,142,247,182,30,220,253,251,154,38,16,63,163,100,183,171,200,26,127,25,227,88,171,240,65,72,249,161,114,131,170,142,127,58,172,163,186,22,147,44,117,162,127,62,1,61,182,173,240,9,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f495a412-7027-454b-a334-1948a1100b0a"));
		}

		#endregion

	}

	#endregion

}

