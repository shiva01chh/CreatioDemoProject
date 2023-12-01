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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,146,95,107,131,48,20,197,159,21,252,14,23,250,174,239,237,24,140,50,134,47,109,193,125,129,44,185,218,128,38,146,27,39,34,251,238,203,159,214,201,24,221,58,31,132,156,28,207,249,229,26,197,58,164,158,113,132,87,52,134,145,174,109,190,215,170,150,205,96,152,149,90,101,233,156,165,201,64,82,53,80,77,100,177,219,101,169,83,54,6,27,183,13,251,150,17,109,225,89,89,105,167,39,110,229,187,180,18,233,56,42,52,165,170,117,48,23,69,1,15,52,116,29,51,211,227,101,93,89,109,144,64,58,143,233,66,21,40,228,72,228,60,96,53,240,51,83,13,130,246,65,160,107,96,49,123,202,175,121,197,42,176,31,222,90,201,129,123,152,91,44,201,28,120,22,250,147,209,61,26,111,218,194,41,100,196,253,239,192,65,40,5,186,228,90,70,30,12,45,249,226,94,227,92,121,94,6,41,46,56,165,128,25,26,180,59,32,255,250,248,165,167,246,228,161,71,183,98,57,123,156,198,31,58,143,173,136,167,254,111,171,194,241,254,214,3,142,247,182,30,220,253,251,154,38,16,63,99,199,110,87,145,53,254,50,198,177,86,225,131,144,242,67,229,6,149,136,127,58,172,163,186,22,147,44,117,162,123,62,1,188,9,79,173,8,3,0,0 };
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

