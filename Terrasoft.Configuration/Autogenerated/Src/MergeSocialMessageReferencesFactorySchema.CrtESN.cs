namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MergeSocialMessageReferencesFactorySchema

	/// <exclude/>
	public class MergeSocialMessageReferencesFactorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MergeSocialMessageReferencesFactorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MergeSocialMessageReferencesFactorySchema(MergeSocialMessageReferencesFactorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e48291b4-a733-42d9-a644-93ba7e513590");
			Name = "MergeSocialMessageReferencesFactory";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b66b5ae8-46e0-4931-ad78-c2c1ba5fd6ea");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,82,77,107,2,49,16,61,91,240,63,12,219,67,21,100,247,110,213,67,91,21,161,74,169,189,149,82,210,236,236,26,216,77,150,76,214,178,20,255,123,199,196,250,65,21,220,67,150,76,94,94,222,123,51,90,148,72,149,144,8,111,104,173,32,147,185,248,209,232,76,229,181,21,78,25,29,143,151,139,246,205,79,251,166,85,147,210,57,44,27,114,88,50,166,40,80,110,1,20,79,81,163,85,242,126,143,185,68,245,132,105,93,21,74,250,221,121,184,197,120,34,164,51,86,33,49,130,49,183,22,115,134,195,28,109,142,75,35,149,40,230,72,36,114,124,197,12,45,106,137,20,174,52,30,159,36,9,12,168,46,75,97,155,209,110,255,98,205,90,165,72,64,254,62,148,129,224,142,64,228,57,243,11,135,96,247,108,49,252,209,36,71,60,239,79,152,137,186,112,15,74,167,172,186,227,154,10,77,214,153,121,93,255,164,116,123,176,224,104,97,8,209,21,194,163,238,7,191,80,213,95,28,14,200,66,16,93,99,23,250,112,225,117,38,251,241,97,236,211,155,40,44,82,234,115,18,106,205,110,195,97,21,54,64,142,59,34,57,1,145,26,93,52,112,74,122,104,53,124,30,66,98,103,26,191,47,67,183,19,211,106,133,181,21,157,24,137,122,254,234,179,34,55,32,103,57,204,209,14,206,200,177,118,202,53,179,52,10,133,141,255,249,117,115,191,179,132,58,13,174,78,45,206,209,173,140,247,232,115,12,135,190,141,74,175,120,64,93,106,100,50,242,190,67,208,23,181,79,209,29,34,237,4,137,64,114,133,165,216,54,181,11,195,209,113,20,231,117,109,194,244,158,20,185,118,252,253,2,224,189,136,164,125,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e48291b4-a733-42d9-a644-93ba7e513590"));
		}

		#endregion

	}

	#endregion

}

