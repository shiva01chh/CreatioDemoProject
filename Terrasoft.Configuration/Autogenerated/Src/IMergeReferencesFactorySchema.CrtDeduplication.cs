namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IMergeReferencesFactorySchema

	/// <exclude/>
	public class IMergeReferencesFactorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IMergeReferencesFactorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IMergeReferencesFactorySchema(IMergeReferencesFactorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3658508f-d4ef-48d0-af35-afb96664f468");
			Name = "IMergeReferencesFactory";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4c53ad23-c903-414d-89cd-b08703861304");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,145,193,74,196,48,16,134,207,45,244,29,6,188,232,165,185,235,178,151,21,101,15,138,44,190,64,76,38,221,64,147,41,147,68,40,178,239,110,210,90,173,148,205,33,48,63,51,63,223,63,227,165,195,48,72,133,240,142,204,50,144,137,237,129,188,177,93,98,25,45,249,246,17,117,26,122,171,166,170,169,191,154,186,169,171,27,198,46,151,112,244,17,217,228,241,123,56,190,32,119,120,66,131,140,94,97,120,146,42,18,143,83,187,16,2,118,33,57,39,121,220,255,212,111,76,159,86,99,0,135,241,76,58,128,33,6,244,209,198,17,248,215,5,116,98,235,187,220,148,205,97,96,202,90,104,23,75,177,242,28,210,71,166,4,187,16,93,7,170,114,134,106,195,52,9,39,140,137,125,0,69,125,143,170,36,6,50,107,156,2,185,97,217,194,204,10,207,110,251,195,21,183,118,39,150,150,50,243,159,119,53,244,140,241,47,198,109,136,211,70,130,58,163,147,175,249,126,119,15,211,146,47,144,191,114,27,244,122,62,79,145,47,77,93,222,55,87,225,255,79,232,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3658508f-d4ef-48d0-af35-afb96664f468"));
		}

		#endregion

	}

	#endregion

}

