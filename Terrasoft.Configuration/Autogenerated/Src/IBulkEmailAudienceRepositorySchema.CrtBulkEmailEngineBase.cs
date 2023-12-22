namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IBulkEmailAudienceRepositorySchema

	/// <exclude/>
	public class IBulkEmailAudienceRepositorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IBulkEmailAudienceRepositorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IBulkEmailAudienceRepositorySchema(IBulkEmailAudienceRepositorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a06eeb92-03f3-e55d-a005-1861571a3c8a");
			Name = "IBulkEmailAudienceRepository";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("8ded9bc0-26e3-4d8b-ab12-46857e761bcf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,147,219,110,194,48,12,134,175,65,226,29,44,118,179,73,168,189,223,88,165,13,16,226,98,218,129,237,1,66,235,130,181,54,233,114,208,84,77,123,247,185,41,45,133,34,150,187,56,241,151,223,191,29,41,114,52,133,136,17,222,81,107,97,84,106,131,153,146,41,109,157,22,150,148,28,13,127,70,195,129,51,36,183,176,46,141,197,252,174,221,119,83,52,6,11,105,201,18,154,195,5,31,41,103,42,203,48,174,96,112,15,71,55,131,211,11,156,202,201,87,26,183,213,237,149,180,168,83,22,119,11,171,71,151,125,46,114,65,217,131,75,8,101,140,111,88,40,67,86,233,210,231,132,97,8,83,227,242,92,232,50,218,239,231,104,98,77,27,52,144,58,233,249,34,227,231,32,85,26,196,30,3,42,5,187,67,216,48,31,176,122,32,104,104,97,7,87,184,77,70,49,80,163,232,31,65,131,31,47,170,173,228,9,237,78,37,230,22,94,60,167,62,60,149,236,3,75,180,230,130,56,248,38,187,131,196,21,76,17,22,33,86,50,161,170,50,19,180,200,240,148,57,45,132,22,57,72,238,245,253,120,211,232,94,37,227,232,67,210,151,67,160,4,185,17,41,161,62,99,199,52,244,233,231,105,104,190,198,209,26,171,246,1,147,116,121,70,114,83,205,101,82,91,211,123,89,224,56,106,92,237,212,106,249,224,50,67,21,222,138,83,69,117,180,159,170,209,58,45,77,212,25,80,86,175,49,166,130,223,230,62,244,205,182,130,177,7,187,152,217,64,42,106,111,222,107,29,77,45,215,75,71,9,116,26,48,217,255,144,117,188,99,171,94,189,90,118,116,82,177,6,189,1,155,119,29,130,35,191,206,128,158,235,170,155,234,111,238,246,19,137,50,169,135,210,239,127,235,15,215,9,2,175,209,208,199,187,235,15,221,131,150,29,41,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a06eeb92-03f3-e55d-a005-1861571a3c8a"));
		}

		#endregion

	}

	#endregion

}

