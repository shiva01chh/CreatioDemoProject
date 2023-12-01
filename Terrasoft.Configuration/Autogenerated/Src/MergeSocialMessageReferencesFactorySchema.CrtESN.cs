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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,82,209,74,195,48,20,125,222,96,255,112,169,15,110,48,218,119,157,123,208,77,25,56,17,231,155,136,196,244,182,11,180,73,201,77,39,69,246,239,222,37,115,179,184,194,250,144,146,155,147,147,115,206,189,90,148,72,149,144,8,175,104,173,32,147,185,248,206,232,76,229,181,21,78,25,29,207,87,79,131,254,247,160,223,171,73,233,28,86,13,57,44,25,83,20,40,119,0,138,31,80,163,85,242,250,128,233,162,154,97,90,87,133,146,126,119,26,110,49,190,23,210,25,171,144,24,193,152,11,139,57,195,97,137,54,199,149,145,74,20,75,36,18,57,190,96,134,22,181,68,10,87,26,143,79,146,4,38,84,151,165,176,205,116,191,127,182,102,163,82,36,32,127,31,202,64,112,73,32,242,156,249,133,67,176,7,182,24,126,105,146,63,60,111,51,204,68,93,184,91,165,83,86,61,116,77,133,38,27,46,188,174,127,82,70,99,120,226,104,225,6,162,51,132,71,163,119,126,161,170,63,57,28,144,133,32,58,199,46,92,65,199,235,76,246,237,195,56,164,119,175,176,72,233,138,147,80,27,118,27,14,171,176,1,114,220,17,201,9,136,212,232,162,129,54,233,177,213,240,113,12,137,157,105,252,234,134,238,38,166,215,11,107,47,106,25,137,198,254,234,163,34,55,33,103,57,204,233,30,206,200,185,118,202,53,139,52,10,133,173,255,249,117,123,189,183,132,58,13,174,218,22,151,232,214,198,123,244,57,134,67,223,70,165,215,60,160,46,53,50,153,122,223,33,232,78,237,15,232,142,145,14,131,68,32,185,198,82,236,154,58,130,155,233,223,40,78,235,218,134,233,109,21,185,198,223,15,209,56,45,83,116,3,0,0 };
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

